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
    }
}
