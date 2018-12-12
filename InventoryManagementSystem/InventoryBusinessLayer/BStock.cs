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

        public void NewStockItem (int barcode, int location, int quantity, string totalcost, DateTime date)
        {
            //NewStockItem (int barcode, int location, int quantity)
            stock.NewStockItem(barcode, location, quantity, totalcost, date);          
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

        public List<int> GetStockBarcodeList()
        {
            return stock.GetStockBarcode();
        }

        public List<int> GetLocationListId()
        {
            return stock.GetLocationListId();
        }


        public void LocationSelect(ComboBox cbox)
        {
            cbox.DataSource = stock.GetLocationList();
        }

        public Boolean checkIfProductInStock(int id, int location)
        {
            bool has = stock.GetStock().Any(st => st.LocationID == location && st.BarcodeID == id);

          
            return has;
        }


        public List<TInStock> STocks()
        {
            return stock.GetStock().ToList();
        }

        public void GetAllStock(ComboBox cbox)
        {
            cbox.DataSource = stock.StockNames();
        }

        public List<int>StockLocationId()
        {
            return stock.StockLocation();
        }

        public List<string> StockLocationName(int id)
        {
            return stock.StockLocationName(id);
        }

        public List<int> StockQuantities()
        {
            return stock.StockQuantities();
        }

        public void DeleteStockItem (int barcode, int locationid)
        {
            stock.DeleteStockItem(barcode, locationid);
        }


        public void EditStockItme (int barcode, int locationid, int quantity)
        {
            stock.StockToEdit(barcode, locationid, quantity);
        }

        public void EditStockItmeWithLog(int barcode, int locationid, int quantity, string totalprice, DateTime date)
        {
            stock.StockToEditWithLog(barcode, locationid, quantity, totalprice, date);
        }


        
    }
}
