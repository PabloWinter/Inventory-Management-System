using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventoryDataLayer;

namespace InventoryBusinessLayer
{
    public class BStock
    {
        Stock stock = new Stock();


        public void GetProducts(DataGridView dataView)
        {
            dataView.DataSource = stock.GetProducts().ToList();
        }

        
    }
}
