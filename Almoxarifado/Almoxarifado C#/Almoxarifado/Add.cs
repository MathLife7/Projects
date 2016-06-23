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
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
            nUD_AddQtd.Maximum = int.MaxValue;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            var name = txt_AddProduto.Text;
            var quantity = (int)nUD_AddQtd.Value;

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Adicione um produto!");
            }
            else
            {
                Database.AddProduct(name, quantity);
                if (quantity > 1)
                {
                    MessageBox.Show(quantity + " unidades de " + name.ToUpper() + " foram adicionadas ao estoque!");
                }
                else
                {
                    MessageBox.Show(quantity + " unidade de " + name.ToUpper() + " foi adicionada ao estoque!");
                }
            }                       
           
        }

        private void Add_Load(object sender, EventArgs e)
        {
            var products = Database.GetAllProducts();
            var txtAutoCompleteCollection = new AutoCompleteStringCollection();
            txtAutoCompleteCollection.AddRange(products.Select(x => x.Name).ToArray());
            txt_AddProduto.AutoCompleteCustomSource = txtAutoCompleteCollection;
        }

    }
}
