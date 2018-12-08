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
            stock.ProductSelect(productList);
            stock.LocationSelect(productLocation);
        }

        public void ValidateForm()
        {
             
        }

        public void ProductList()
        {

        }

        private void Ok_Click(object sender, EventArgs e)
        {
            int barcode = Convert.ToInt16(productBarcode.Text);
            int location = stock.GetLocationListId()[productLocation.SelectedIndex];
            int quantity = Convert.ToInt16(productQantity.Text);

            MessageBox.Show(location.ToString());
            MessageBox.Show(stock.checkIfProductInStock(barcode, location).ToString());

            if (stock.checkIfProductInStock(barcode, location))
            {
                MessageBox.Show("Item already exists in stock");
            }
            else
            {
                MessageBox.Show("Item added to stock successfully.");
                stock.NewStockItem(barcode, location, quantity);
                Close();
            }

        }


        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddItemToStock_Load(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        //update textbox selected product id
        private void productList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var BarcodeList = stock.GetBarcodeList();

            productBarcode.Text = BarcodeList.ToArray()[productList.SelectedIndex].ToString();

        }
    }
}