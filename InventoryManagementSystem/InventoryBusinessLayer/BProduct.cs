using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventoryDataLayer;

namespace InventoryBusinessLayer
{
    public class BProduct
    {
        Product product = new Product();

        public void FillDataGridProduct(DataGridView data)
        {
            // Fill Data grid view with products from database
           data.DataSource = product.ShowInventoryProduct();
        }


    }
}
