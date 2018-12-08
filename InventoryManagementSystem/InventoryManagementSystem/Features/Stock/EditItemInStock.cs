using InventoryBusinessLayer;
using System;
using System.Globalization;
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

        public bool MoneyValidate(string text)
        {
            float money = 0;
            return float.TryParse(text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-CA"), out money);
        }

        private void Ok_Click(object sender, EventArgs e)
        {

            if (checkBox1.Checked)
            {
                if (!MoneyValidate(totalCost.Text))
                {
                    MessageBox.Show("Incorrect Total cost format, format is 9.99 for $9.99");
                }
                else
                {
                    stock.EditStockItmeWithLog(Convert.ToInt16(productBarcode.Text), Convert.ToInt16(stock.StockLocationId()[productList.SelectedIndex]), Convert.ToInt32(productQantity.Value), totalCost.Text, date.Value);
                    Close();
                }               
            }
            else
            {
                stock.EditStockItme(Convert.ToInt16(productBarcode.Text), Convert.ToInt16(stock.StockLocationId()[productList.SelectedIndex]), Convert.ToInt32(productQantity.Value));
                Close();
            }
          
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

        //if new purchase or not
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {         
                if (checkBox1.Checked)
                {
                    totalCost.Enabled = true;
                    date.Enabled = true;
                }
                else
                {
                    totalCost.Enabled = false;
                    date.Enabled = false;
                }
            }
        }
    }
 
