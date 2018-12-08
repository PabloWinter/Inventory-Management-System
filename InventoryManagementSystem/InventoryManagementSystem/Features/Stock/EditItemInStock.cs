using InventoryBusinessLayer;
using System;
using System.Windows.Forms;

namespace InventoryManagementSystem.Features.Stock
{
    public partial class EditItemInStock : Form
    {
        BStock stock = new BStock();
        public EditItemInStock()
        {
            InitializeComponent();
            stock.GetAllStock(productList);
          
        }

        //when different item is selected to be edited
        private void productList_SelectedIndexChanged(object sender, EventArgs e)
        { 

            productBarcode.Text = stock.GetStockBarcodeList()[productList.SelectedIndex].ToString();
            int productindex = productList.SelectedIndex;
            productLocation.Text = stock.StockLocationName(stock.StockLocationId()[productindex])[productindex];
            productQantity.Text = stock.StockQuantities()[productindex].ToString();


        }

        private void Ok_Click(object sender, EventArgs e)
        {
            stock.EditStockItme(Convert.ToInt16(productBarcode.Text), Convert.ToInt16(stock.StockLocationId()[productList.SelectedIndex]), Convert.ToInt32(productQantity.Value));
            MessageBox.Show("Item edited successfully.");
            Close();
        }

        //delete stock item
        private void button1_Click(object sender, EventArgs e)
        {
            stock.DeleteStockItem(Convert.ToInt16(productBarcode.Text), Convert.ToInt16(stock.StockLocationId()[productList.SelectedIndex]));
            MessageBox.Show("Item deleted.");
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
