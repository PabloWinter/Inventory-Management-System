using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryDataLayer
{
    public class Dashboard
    {
        DataLinqToSQLDataContext db = new DataLinqToSQLDataContext();

        public int StockCount ()
        {
            var query = (from stock in db.TInStocks where stock.Quantity > 0 select stock).ToList();
            return query.ToList().Count;
        }

        public int OutOfStockCount()
        {
            var query = (from stock in db.TInStocks where stock.Quantity == 0 select stock).ToList();
            return query.ToList().Count;
        }

        public int RunningLowInStock()
        {
            var query = (from stock in db.TInStocks where stock.Quantity < 5 && stock.Quantity >= 1 select stock).ToList();
            return query.ToList().Count;
        }

        public int StockItemCount()
        {
            var query = (from stock in db.TInStocks select stock).ToList();
            return query.ToList().Count;
        }

        public int LocationCount()
        {
            var query = (from l in db.TLocations select l).ToList();
            return query.ToList().Count;
        }

        public decimal TotalStockValue()
        {
            var query = from stock in db.TInStocks
                        join p in db.TProductGroups on stock.BarcodeID equals p.Barcode
                        where stock.Quantity > 1
                        select (p.Price * stock.Quantity);
            return query.ToList().Sum();
        }
    }
}
