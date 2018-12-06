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

        public void InsertIntoDatabase(string name, decimal price, decimal tax, decimal discount, string description, int FKcategory, int FKbrand, string fullName, string shortName)
        {
            product.InsertNewProduct(name, price, tax, discount, description, FKcategory, FKbrand, fullName, shortName);
        }


    }
}
