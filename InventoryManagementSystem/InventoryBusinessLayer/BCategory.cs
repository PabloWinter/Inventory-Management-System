using InventoryDataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryBusinessLayer
{
    public class BCategory
    {
        Category category = new Category();

        public void FillDataGridCategory(DataGridView dataview)
        {
            dataview.DataSource = category.ShowCategories();
        }

        public void InsertNewCategory(string categoryName)
        {
            category.InsertCategory(categoryName);
        }

        public void FillComboBoxCategory(ComboBox combo)
        {
            combo.DataSource = category.ShowComboCategory();
            combo.DisplayMember = "Name";
        }

        public void UpdateCategory(int categoryId, string name)
        {
            category.UpdateCategory(categoryId, name);
        }

        public List<int> GetCategoryId()
        {
            return category.GetCategories();
        }
    }
}
