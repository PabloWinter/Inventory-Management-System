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
            dataView.DataSource = stock.GetProductList().ToList();
        }


        public void NewStockItem (int barcode, int location, int quantity)
        {
            //NewStockItem (int barcode, int location, int quantity)
            stock.NewStockItem(barcode, location, quantity);
           
        }


    }
}
