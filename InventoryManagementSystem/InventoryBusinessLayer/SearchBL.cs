using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryDataLayer;
using System.Windows.Forms;

namespace InventoryBusinessLayer
{
    public class SearchBL
    {
        public static void PopulateGrid(DataGridView dataGridView)
        {
            dataGridView.DataSource = SearchDL.AllProducts();
        }
    }
}