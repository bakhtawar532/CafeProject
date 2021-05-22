using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void LoginFormbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
        }

        private void AddPersonalInfobutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Personal_Detail personaldetail = new Personal_Detail();
            personaldetail.Show();
        }

        private void AddItemsbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ItemsDetails itemdetail = new ItemsDetails();
            itemdetail.Show();
        }

        private void PlaceOrderbutton_Click(object sender, EventArgs e)
        {

            this.Hide();
            PlaceOrder placeorder = new PlaceOrder();
            placeorder.Show();
        }
    }
}
