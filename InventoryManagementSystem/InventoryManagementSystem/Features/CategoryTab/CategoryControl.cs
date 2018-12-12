using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventoryBusinessLayer;

namespace InventoryManagementSystem.Features.CategoryTab
{
    public partial class CategoryControl : UserControl
    {
        BCategory category = new BCategory();

        public CategoryControl()
        {
            InitializeComponent();

            category.FillDataGridCategory(ViewDataList);
        }

        private void InsertCategory_Click(object sender, EventArgs e)
        {
            InsertCategoryForm newCategory = new InsertCategoryForm();
            newCategory.ShowDialog();
        }

        private void UpdateCategory_Click(object sender, EventArgs e)
        {
            UpdateCategoryForm newCategory = new UpdateCategoryForm();
            newCategory.ShowDialog();
        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            category.FillDataGridCategory(ViewDataList);
        }
    }
}
