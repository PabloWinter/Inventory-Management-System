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
        }

        private void productList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Ok_Click(object sender, EventArgs e)
        {

        }
    }
}
