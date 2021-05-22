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
    public partial class DealForm : Form
    {

        private DataAccess dataAccess;
        private List<ItemsCoffee> allAvailableItemsCoffee;

        public DealForm()
        {
            InitializeComponent();
            dataAccess = new DataAccess();

            getAllTheItemsCoffee();
            SelectItemscomboBox.DataSource = allAvailableItemsCoffee;
            SelectItemscomboBox.DisplayMember = "Name";

            dataAccess.getNextIdFordealCoffee();

            loadAlldealCoffee();
        }

        private void getAllTheItemsCoffee()
        {
            allAvailableItemsCoffee = dataAccess.getAllItemsCoffee();
        }
         private void loadAlldealCoffee()
        {
            DealdataGridView.DataSource = dataAccess.getAlldealCoffee();
        }
        private void SelectItemscomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ItemPricetextBox.Text = "" + allAvailableItemsCoffee[SelectItemscomboBox.SelectedIndex].Price;
        }

        private void DealForm_Load(object sender, EventArgs e)
        {

        }

        private void AddItemsbutton_Click(object sender, EventArgs e)
        {
            int ItemsQuantity = int.Parse(ItemQuantitytextBox.Text);
            string ItemName = allAvailableItemsCoffee[SelectItemscomboBox.SelectedIndex].Name;
            int id_dealform = dataAccess.getNextIdFordealCoffee();
            dataAccess.InsertDataIntodealCoffee(id_dealform, ItemName,
                ItemsQuantity * allAvailableItemsCoffee[SelectItemscomboBox.SelectedIndex].Price);
            loadAlldealCoffee();


            MessageBox.Show("Data Is successfully Saved");
            
        }

        private void RemoveItemsbutton_Click(object sender, EventArgs e)
        {
            SelectItemscomboBox.SelectedIndex = 1;
            ItemQuantitytextBox.Text = "";
            ItemPricetextBox.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainform = new MainForm();
            mainform.Show();
        }

        private void BacktoItemDetailbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ItemsDetails itemdetail = new ItemsDetails();
            itemdetail.Show();
        }
    } 
}
