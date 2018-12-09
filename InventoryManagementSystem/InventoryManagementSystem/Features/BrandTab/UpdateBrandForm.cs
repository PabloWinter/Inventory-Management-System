using System;
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

namespace InventoryManagementSystem.Features.BrandTab
{
    public partial class UpdateBrandForm : Form
    {
        BBrand brand = new BBrand();

        public UpdateBrandForm()
        {
            InitializeComponent();

            brand.FillComboBoxBrand(brandComboBox);
        }

        private void brandComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            var listBrand = brand.GetIDBrand();

            brandTxt.Text = listBrand[brandComboBox.SelectedIndex].ToString();
        }

        private void UpdateBrand_Click(object sender, EventArgs e)
        {
            try
            {
                int brandId = Convert.ToInt32(brandTxt.Text);
                string brandName = brandComboBox.Text;


                brand.UpdateBrand(brandId, brandName);
                MessageBox.Show("Brand was successfully updated", "Update brand", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Insert a new product", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}

