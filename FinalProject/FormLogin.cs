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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        

        private void Loginbutton_Click(object sender, EventArgs e)
        {
            if (OwnerradioButton.Checked)
            {
            }
            else
            {
            }
            string UserNameText = UserNametextBox.Text.ToString();
            if(UserNameText.Equals(""))
            {
                MessageBox.Show("Please enter username");
                return;
            }
            string PassWordText = PasswordtextBox.Text.ToString();
            if(PassWordText.Equals(""))
            {
                MessageBox.Show("Please enter Password");
                return;
            }


            MessageBox.Show(" You Have Successfully LogedIn");
            //MessageBox.Show(LoginTypeText+"\n"+
            //UserNameText+"\n"+
            ///PassWordText);
            ///

            {
                this.Hide();
                PlaceOrder placeorder = new PlaceOrder();
                placeorder.Show();
            }
        }

        private void Resetbutton_Click(object sender, EventArgs e)
        {
            UserNametextBox.Text = "";
            PasswordtextBox.Text = "";
            OwnerradioButton.Checked = true;
            EmplyeeradioButton.Checked = false;
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            {
                this.Hide();
                MainForm mainform = new MainForm();
                mainform.Show();
            }
        }
    }
}
