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
                MessageBox.Show("return added to stock successfully.");
                returned.NewReturnItem(barcode, location, quantity);
                Close();
            }
        }
    }
}
