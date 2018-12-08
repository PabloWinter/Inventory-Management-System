using InventoryBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem.Features.ProductTab
{
    public partial class InsertProductForm : Form
    {
        BProduct product = new BProduct();

        public InsertProductForm()
        {
            InitializeComponent();

            product.FillComboBoxCategory(comboCategory);
            product.FillComboBoxBrand(comboBrand);
        }

        private void InsertProduct_Click(object sender, EventArgs e)
        {
            try
            {
                string pName = txtProductName.Text;
                decimal pPrice = Convert.ToDecimal(txtPrice.Text);
                decimal pTax = Convert.ToDecimal(txtTax.Text);
                decimal pDiscount = Convert.ToDecimal(txtDiscount.Text);
                string pDescription = txtDescription.Text;
                int pCategoryID = Convert.ToInt32(comboCategory.SelectedIndex + 1);
                int pBrandID = Convert.ToInt32(comboBrand.SelectedIndex + 1);
                string pFullProductName = txtFullName.Text;
                string pShortProductName = txtShortName.Text;

                product.InsertIntoDatabase(pName, pPrice, pTax, pDiscount, pDescription, pCategoryID, pBrandID, pFullProductName, pShortProductName);
                MessageBox.Show("Product was successfully inserted");

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Insert a new product", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        
    }
}
