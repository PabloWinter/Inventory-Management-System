using InventoryDataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryBusinessLayer
{
    public class BBrand
    {
        Brand brand = new Brand();

        public void FillDataGridBrand(DataGridView dataview)
        {
            dataview.DataSource = brand.ShowBrands();
        }

        public void InsertIntoDatabase(string name)
        {
            brand.InsertNewBrand(name);
        }

        public void FillComboBoxBrand(ComboBox combo)
        {
            combo.DataSource = brand.ShowComboBrand();
            combo.DisplayMember = "Name";
        }

        public void UpdateBrand(int brandId, string name)
        {
            brand.UpdateBrand(brandId, name);
        }

        public List<int> GetIDBrand()
        {
            return brand.GetBrandId();
        }
    }
}