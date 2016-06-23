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
    public partial class Almoxarifado : Form
    {
        public Almoxarifado()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Check chk=new Check();
            chk.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Add add = new Add();
            add.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Remove rmv = new Remove();
            rmv.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            History hst = new History();
            hst.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Credits crd = new Credits();
            crd.ShowDialog();
        }
               
    }
}
