using InventoryBusinessLayer;
using System;
using System.Globalization;
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


        public bool MoneyValidate (string text)
        {
            float money = 0;
            return float.TryParse(text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-CA"), out money);
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            int barcode = Convert.ToInt16(productBarcode.Text);
            int location = stock.GetLocationListId()[productLocation.SelectedIndex];
            int quantity = Convert.ToInt16(productQantity.Text);      

            float num = 0;

            if (!MoneyValidate(totalCost.Text))
            {
                MessageBox.Show("Incorrect Total cost format");
            }
            else
            {
                if (stock.checkIfProductInStock(barcode, location))
                {
                    MessageBox.Show("Item already exists in stock");
                }
                else
                {
                    stock.NewStockItem(barcode, location, quantity, totalCost.Text, date.Value);
                    Close();
                }
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

            productBarcode.Text = BarcodeList[productList.SelectedIndex].ToString();
        }
    }
}