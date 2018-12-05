using InventoryBusinessLayer;
using System;
using System.Windows.Forms;

namespace InventoryManagementSystem.Features.Stock
{
    public partial class AddItemToStock : Form
    {
        BStock stock = new BStock();
         
        public AddItemToStock()
        {
            InitializeComponent();
        }

        public void ValidateForm()
        {
             
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            int barcode = Convert.ToInt16(productBarcode.Text);
            MessageBox.Show(productLocation.SelectedText);
            int location = Convert.ToInt16(productLocation.SelectedItem);
            int quantity = Convert.ToInt16(productQantity.Text);
            stock.NewStockItem(barcode, location, quantity);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddItemToStock_Load(object sender, EventArgs e)
        {

        }
    }
}