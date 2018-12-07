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

        
        public void GetStock(DataGridView dataView)
        {
            dataView.DataSource = stock.GetStockList();
        }

        public void NewStockItem (int barcode, int location, int quantity)
        {
            //NewStockItem (int barcode, int location, int quantity)
            stock.NewStockItem(barcode, location, quantity);          
        }


        //for letting user pick a product to add to stock
        public void ProductSelect (ComboBox cbox)
        {
            cbox.DataSource = stock.GetProductList();
        }

        public List<int> GetBarcodeList()
        {
            return stock.GetBarcode();
        }

        public List<int> GetLocationListId()
        {
            return stock.GetLocationListId();
        }

        public void LocationSelect(ComboBox cbox)
        {
            cbox.DataSource = stock.GetLocationList();
        }

        public Boolean checkIfProductInStock (int id)
        {
            bool has = stock.GetStockBarcode().Any(st => st == id);
            return has;
        }

        public void GetAllStock(ComboBox cbox, NumericUpDown nud)
        {
          
        }
    }
}
