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
    public partial class Advanced : Form
    {
        public Advanced()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddEmployeeButton_Click(object sender, EventArgs e)
        {
            var employeeName = EmployeeNameTextBox.Text.ToUpper();
            var employeeSector = EmployeeSectorTextBox.Text.ToUpper();


            if (string.IsNullOrWhiteSpace(employeeName))
            {
                MessageBox.Show("Nome não pode ser vazio");
                return;
            }

            else if (string.IsNullOrWhiteSpace(employeeSector))
            {
                MessageBox.Show("Setor não pode ser vazio");
                return;
            }

            if (Database.GetEmployee(employeeName, employeeSector) != null)
            {
                MessageBox.Show("Já existe um funcionário com esse nome no setor "+ employeeSector);
                return;
            }

            else
            {
                MessageBox.Show("Usuário cadastrado com sucesso!");
                Database.AddEmployee(employeeName, employeeSector);
                Close();
            }



        }

        private void Advanced_Load(object sender, EventArgs e)
        {

        }
    }
}
