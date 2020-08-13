using CarClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarShop
{
    public partial class Form1 : Form
    {
        Store myStore = new Store();
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btn_create_a_car_Click(object sender, EventArgs e)
        {
            Car c = new Car(txt_make.Text, txt_model.Text, decimal.Parse(txt_price.Text));
            MessageBox.Show(c.ToString());
        }
    }
}
