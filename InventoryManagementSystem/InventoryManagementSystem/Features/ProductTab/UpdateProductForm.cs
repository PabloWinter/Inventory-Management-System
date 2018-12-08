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
    public partial class UpdateProductForm : Form
    {
        BProduct product = new BProduct();

        public UpdateProductForm()
        {
            InitializeComponent();

            // Parameters
            string name = "Name";
            string description = "DESCRIPTION";
            string fullName = "FullProductName";
            string shortName = "ShortProductName";

            // Populating ComboBox with information from database
            // it is easier for user to update products this way.
            product.FillComboBoxProduct(comboName, name);
            product.FillComboBoxProduct(comboDescription, description);
            product.FillComboBoxCategory(comboCategory);
            product.FillComboBoxBrand(comboBrand);
            product.FillComboBoxProduct(comboFullName, fullName);
            product.FillComboBoxProduct(comboShortName, shortName);

        }

        private void comboName_SelectedIndexChanged(object sender, EventArgs e)
        {
            var list = product.GetBarcodeList();

            barcodeTxt.Text = list[comboName.SelectedIndex].ToString();
        }

        private void UpdateProduct_Click(object sender, EventArgs e)
        {
            try
            {
                int pBarcode = Convert.ToInt32(barcodeTxt.Text);
                string pName = comboName.Text;
                decimal pPrice = Convert.ToDecimal(txtPrice.Text);
                decimal pTax = Convert.ToDecimal(txtTax.Text);
                decimal pDiscount = Convert.ToDecimal(txtDiscount.Text);
                string pDescription = comboDescription.Text;
                int pCategoryID = Convert.ToInt32(comboCategory.SelectedIndex + 1);
                int pBrandID = Convert.ToInt32(comboBrand.SelectedIndex + 1);
                string pFullProductName = comboFullName.Text;
                string pShortProductName = comboShortName.Text;

                product.UpdateDatabase(pBarcode, pName, pPrice, pTax, pDiscount, pDescription, pCategoryID, pBrandID, pFullProductName, pShortProductName);
                MessageBox.Show("Product was successfully updated", "Inventory Management", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Insert a new product", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
