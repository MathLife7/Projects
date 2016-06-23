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
    public partial class Check : Form
    {
        public Check()
        {
            InitializeComponent();
        }

        private StringReader myReader;

        private void Check_Load(object sender, EventArgs e)
        {
            UpdateResults();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        protected void printDocument1_PrintPage(object sender,
        System.Drawing.Printing.PrintPageEventArgs ev)
        {
            float linesPerPage = 0;
            float yPosition = 0;
            int count = 0;
            float leftMargin = ev.MarginBounds.Left;
            float topMargin = ev.MarginBounds.Top;
            string line = null;
            Font printFont = this.listBox1.Font;
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
        
        private void UpdateResults()
        {
            var products = Database.GetAllProducts().Where(x => x.Name.ToLower().StartsWith(txt_Search.Text.ToLower())).OrderBy(x => x.Name);
            listBox1.Items.Clear();
            listBox1.Items.AddRange(products.Select(x => string.Format("{0} - Quantidade: {1}", x.Name, x.Quantity)).ToArray());
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            UpdateResults();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string strText = "";
            foreach (object x in listBox1.Items)
            {
                strText = strText + x.ToString() + "\n";
            }

            myReader = new StringReader(strText);
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                this.printDocument1.Print();
            }
        }
    }
}
