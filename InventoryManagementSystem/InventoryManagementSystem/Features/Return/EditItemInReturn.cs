using InventoryBusinessLayer;
using System;
using System.Globalization;
using System.Windows.Forms;


namespace InventoryManagementSystem.Features.Return
{
    public partial class EditItemInReturn : Form
    {
        BReturn returned = new BReturn();
        public EditItemInReturn()
        {
            InitializeComponent();
            returned.GetAllReturns(productList);
        }

        private void EditItemInReturn_Load(object sender, EventArgs e)
        {

        }

        private void Ok_Click(object sender, EventArgs e)
        {
            returned.EditReturnedItem(Convert.ToInt16(productBarcode.Text), Convert.ToInt16(returned.ReturnedLocationId()[productList.SelectedIndex]), Convert.ToInt32(productQantity.Value)); 
            Close();
        }

        private void productList_SelectedIndexChanged(object sender, EventArgs e)
        {

            productBarcode.Text = returned.GetReturnBarcodeList()[productList.SelectedIndex].ToString();
            int productindex = productList.SelectedIndex;
            productLocation.Text = returned.ReturnedLocationName(returned.ReturnedLocationId()[productindex])[productindex];
            productQantity.Text = returned.ReturnedQuantities()[productindex].ToString();
        }
    }
}
