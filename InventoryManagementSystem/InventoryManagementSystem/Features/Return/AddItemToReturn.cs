using InventoryBusinessLayer;
using System;
using System.Windows.Forms;


namespace InventoryManagementSystem.Features.Return
{
    public partial class AddItemToReturn : Form
    {
        BReturn returned = new BReturn();
        public AddItemToReturn()
        {
            InitializeComponent();
            returned.ProductSelect(productList);
            returned.LocationSelect(productLocation);
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            int barcode = Convert.ToInt16(productBarcode.Text);
            int location = returned.GetLocationListId()[productLocation.SelectedIndex];
            int quantity = Convert.ToInt16(productQantity.Text);

            if (returned.checkIfProductInReturn(barcode, location))
            {
                MessageBox.Show("Item already exists in return");
            }
            else
            {           
                returned.NewReturnItem(barcode, location, quantity);
                Close();
            }
        }

        private void productList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var BarcodeList = returned.GetBarcodeList();

            productBarcode.Text = BarcodeList.ToArray()[productList.SelectedIndex].ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
