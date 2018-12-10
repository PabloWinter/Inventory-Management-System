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

namespace InventoryManagementSystem.Features.CategoryTab
{
    public partial class UpdateCategoryForm : Form
    {
        BCategory category = new BCategory();

        public UpdateCategoryForm()
        {
            InitializeComponent();

            category.FillComboBoxCategory(categoryComboBox);
        }

        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var listCategoryID = category.GetCategoryId();

            categoryIdTxt.Text = listCategoryID[categoryComboBox.SelectedIndex].ToString();
        }

        private void UpdateCategory_Click(object sender, EventArgs e)
        {
            try
            {
                int categoryId = Convert.ToInt32(categoryIdTxt.Text);
                string categoryName = categoryComboBox.Text;

                //brand.UpdateBrand(brandId, brandName);
                category.UpdateCategory(categoryId, categoryName);
                MessageBox.Show("Category was successfully updated", "Update Category", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Insert a new Category", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}