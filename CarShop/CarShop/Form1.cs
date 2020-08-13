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
        BindingSource carInventoryBindingSource = new BindingSource();
        BindingSource cartBindingSource = new BindingSource();


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
            //MessageBox.Show(c.ToString());
            myStore.CarList.Add(c);
            carInventoryBindingSource.ResetBindings(false);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            carInventoryBindingSource.DataSource = myStore.CarList;

            cartBindingSource.DataSource = myStore.ShoppingList;

            lst_car_inventory.DataSource = carInventoryBindingSource;
            lst_car_inventory.DisplayMember = ToString();

            lst_shopping_cart.DataSource = cartBindingSource;
            lst_shopping_cart.DisplayMember = ToString();
        }

        private void btn_add_to_cart_Click(object sender, EventArgs e)
        {
            Car selected = (Car) lst_car_inventory.SelectedItem;
            myStore.ShoppingList.Add(selected);

            cartBindingSource.ResetBindings(false);

        }

        private void btn_checkout_Click(object sender, EventArgs e)
        {
            decimal total = myStore.checkout();
            lbl_total.Text = "$" + total.ToString();

            cartBindingSource.ResetBindings(false);
        }
    }
}
