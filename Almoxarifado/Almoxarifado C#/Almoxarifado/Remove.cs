using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Remove : Form
    {
        public Remove()
        {
            InitializeComponent();
            nUD_RmvQtd.Maximum = int.MaxValue;
            nUD_RmvQtd.Minimum = 1;
        }

        private void Remove_Load(object sender, EventArgs e)
        {
            var products = Database.GetAllProducts();
            cB_RtProduto.Items.AddRange(products.OrderBy(x => x.Name).ToArray());
            cB_RtProduto.ValueMember = "Name";
            cB_RtProduto.SelectedIndex = 0;

            EmployeesComboBox.Items.AddRange(Database.GetAllEmployees().Where(x => !string.IsNullOrWhiteSpace(x.Name)).OrderBy(x => x.Name).ToArray());
            EmployeesComboBox.ValueMember = "Name";
            EmployeesComboBox.SelectedIndex = 0;
            EmployeesComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void Btn_Remove_Click(object sender, EventArgs e)
        {
            var product = (Product)cB_RtProduto.SelectedItem;
            var employee = (Employee)EmployeesComboBox.SelectedItem;
            var quantity = (int)nUD_RmvQtd.Value;
            if (quantity > product.Quantity)
            {
                MessageBox.Show("Não é possível remover mais do que o disponível! \r\nQuantidade disponível no estoque: " + product.Quantity);
                return;
            }
            else
                MessageBox.Show(product.Name + " retirado da lista de produtos: " + quantity);
                this.Close();
            
                
            Database.RemoveProduct(product, quantity, employee);
            
        }              

        private void EmployeesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_Setor.Text = ((Employee)EmployeesComboBox.SelectedItem).Sector;
        }

        private void btn_AddEmp_Click(object sender, EventArgs e)
        {
            Advanced adv = new Advanced();
            adv.ShowDialog();
        }
    }
}
