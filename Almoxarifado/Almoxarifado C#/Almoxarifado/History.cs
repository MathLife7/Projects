using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace WindowsFormsApplication1
{
    public partial class History : Form
    {
        private Transaction[] _transactions;

        public History()
        {
            InitializeComponent();
            _transactions = Database.GetTransactions();

            UpdateResults();

        }



        bool addTrue = false;
        bool removeTrue = false;
        private StringReader myReader;


        private void UpdateResults()
        {
            var searchText = SearchTextBox.Text.ToLower();

            var search = _transactions.Where(x => x.Product.Name.ToLower().StartsWith(searchText) ||
                                                  x.Employee.Name.ToLower().StartsWith(searchText) ||
                                                  x.Employee.Sector.ToLower().StartsWith(searchText)
            );


            if (search.Count() == 0)
            {
                Results.Items.Clear();
                Results.Items.Add("Nenhum resultado");
                return;
            }

            StartDatePicker.MinDate = search.Min(x => x.Date);
            StartDatePicker.MaxDate = search.Max(x => x.Date);

            EndDatePicker.MinDate = search.Min(x => x.Date);
            EndDatePicker.MaxDate = search.Max(x => x.Date);

            if (!StartDateCheckbox.Checked)
            {
                StartDatePicker.Value = StartDatePicker.MinDate;
                EndDatePicker.Value = EndDatePicker.MaxDate;
            }
            else
            {
                if (!EndDateCheckbox.Checked)
                {
                    EndDatePicker.Value = StartDatePicker.Value;
                }
            }

            var totalResults = search.Count();

            search = search.Where(x => x.Date.Date >= StartDatePicker.Value.Date && x.Date.Date <= EndDatePicker.Value.Date);

            if (addTrue)
            {
                search = search.Where(x => x.Type == Transaction.TransactionType.ProductAdded);
            }
            else if (removeTrue)
            {
                search = search.Where(x => x.Type == Transaction.TransactionType.ProductRemoved);
            }

            Results.Items.Clear();
            Results.Items.Add(string.Format("{0} resultados:", search.Count()));
            Results.Items.Add("");

            foreach (var transaction in search.OrderByDescending(x => x.Date).ToArray())
            {
                try
                {
                    Results.Items.Add(FormatTransaction(transaction));
                }
                catch (Exception)
                {
                    
                }
            }
        }

        private string FormatTransaction(Transaction transaction)
        {
            if (transaction.Type == Transaction.TransactionType.ProductAdded)
            {
                return string.Format("{0} :: Adicionado {1} {2} de {3}", transaction.Date, transaction.Quantity, transaction.Quantity > 1 ? "unidades" : "unidade", transaction.Product.Name);
            }
            else if (transaction.Type == Transaction.TransactionType.ProductRemoved)
            {
                return string.Format("{0} :: {1} ({2}) removeu {3} {4} de {5}", transaction.Date, transaction.Employee.Name, transaction.Employee.Sector, transaction.Quantity, transaction.Quantity > 1 ? "unidades" : "unidade", transaction.Product.Name);
            }
            else
            {
                return null;
            }
        }


        private void StartDateCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            StartDatePicker.Enabled = StartDateCheckbox.Checked;

            if (!StartDateCheckbox.Checked)
            {
                EndDateCheckbox.Checked = false;
                EndDatePicker.Enabled = false;
                EndDateCheckbox.Enabled = false;
            }
            else
            {
                EndDateCheckbox.Enabled = true;
            }

            UpdateResults();
        }

        protected void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs ev)
        {
            float linesPerPage = 0;
            float yPosition = 0;
            int count = 0;
            float leftMargin = ev.MarginBounds.Left;
            float topMargin = ev.MarginBounds.Top;
            string line = null;
            Font printFont = this.Results.Font;
            SolidBrush myBrush = new SolidBrush(Color.Black);

            linesPerPage =
               ev.MarginBounds.Height / printFont.GetHeight(ev.Graphics);

            while (count < linesPerPage && ((line = myReader.ReadLine()) != null))
            {
                yPosition = topMargin + (count * printFont.GetHeight(ev.Graphics));


                ev.Graphics.DrawString(line, printFont,
                                       myBrush, leftMargin,
                                       yPosition, new StringFormat());
                count++;
            }

            if (line != null)
                ev.HasMorePages = true;
            else
                ev.HasMorePages = false;

            myBrush.Dispose();
        }

        private void EndDateCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            EndDatePicker.Enabled = EndDateCheckbox.Checked;
            UpdateResults();
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateResults();
        }

        private void StartDatePicker_ValueChanged(object sender, EventArgs e)
        {
            UpdateResults();
        }

        private void EndDatePicker_ValueChanged(object sender, EventArgs e)
        {
            UpdateResults();
        }

        private void Results_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void InButton_Click(object sender, EventArgs e)
        {
            if (addTrue == false)
            {
                addTrue = true;
                removeTrue = false;
            }
            else if (addTrue == true)
            {
                addTrue = false;
            }

            UpdateResults();
        }

        private void OutButton_Click(object sender, EventArgs e)
        {
            if (removeTrue == false)
            {
                addTrue = false;
                removeTrue = true;
            }
            else if (removeTrue == true)
            {
                removeTrue = false;
            }

            UpdateResults();
        }
               

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string strText = "";
            foreach (object x in Results.Items)
            {
                strText = strText + x.ToString() + "\n";
            }

            myReader = new StringReader(strText);
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                this.printDocument1.Print();
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
