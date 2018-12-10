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
    public partial class InsertCategoryForm : Form
    {
        BCategory category = new BCategory();

        public InsertCategoryForm()
        {
            InitializeComponent();


        }

        private void InsertCategory_Click(object sender, EventArgs e)
        {
            try
            {
                string categoryN = txtcategory.Text;

                category.InsertNewCategory(categoryN);
                MessageBox.Show("Category was successfully inserted!", "Insert Category", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Insert a new category", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
