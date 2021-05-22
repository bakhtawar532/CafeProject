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
    public partial class ItemsDetails : Form
    {
        DataAccess dataAccess;
        List<ItemsCoffee> listOfAllItemsCoffee;
        public ItemsDetails()
        {
            InitializeComponent();
            dataAccess = new DataAccess();
            loadDataFromDB();
        }


        private void loadDataFromDB()
        {
            listOfAllItemsCoffee = dataAccess.getAllItemsCoffee();
            ItemsGV.DataSource = listOfAllItemsCoffee;
        }
          

        private void AddItembutton_Click(object sender, EventArgs e)
        {
            string ItemNumber = ItemNumbertextBox.Text;
            string ItemName = ItemNametextBox.Text;
            int Price = int.Parse(ItemPricetextBox.Text);


            int received = dataAccess.InsertDataIntoItemsCoffee(ItemNumber, ItemName, Price);
            if(received == 1)
            {
                MessageBox.Show("Data is Successfully Saved");
                loadDataFromDB();
            }
            // MessageBox.Show($"{ItemNumber}-{ItemName}-{Price}");


            {
                DealForm dealform = new DealForm();
                dealform.Show();
            }
        }

        private void RemoveItembutton_Click(object sender, EventArgs e)
        {
            ItemNumbertextBox.Text = "";
            ItemNametextBox.Text = "";
            ItemPricetextBox.Text = "";
        }

        private void ItemsDetails_Load(object sender, EventArgs e)
        {

        }

        private void ExitItemsbutton_Click(object sender, EventArgs e)
        {
            {
                this.Hide();
                MainForm mainform = new MainForm();
                mainform.Show();
            }
        }
    }
    
}
