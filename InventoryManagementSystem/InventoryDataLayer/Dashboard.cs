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


        public int ReturnCount()
        {
            var query = (from returned in db.TReturneds where returned.Quantity > 0 select returned).ToList();
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

        public int CategoryCount()
        {
            var query = (from l in db.TCategories select l).ToList();
            return query.ToList().Count;
        }

        public int ProductCount()
        {
            var query = (from l in db.TProductGroups select l).ToList();
            return query.ToList().Count;
        }

        public int BrandCount()
        {
            var query = (from l in db.TBrands select l).ToList();
            return query.ToList().Count;
        }

        public int PurchaseLogCount()
        {
            var query = (from l in db.TPurchaseLogs select l).ToList();
            return query.ToList().Count;
        }

        public decimal PurchaseCost()
        {
            var query = from purchases in db.TPurchaseLogs
                        select purchases.TotalCost;
            return query.ToList().Sum();
        }

        public decimal TotalStockValue()
        {
            var query = from stock in db.TInStocks
                        join p in db.TProductGroups on stock.BarcodeID equals p.Barcode
                        where stock.Quantity > 1
                        select (p.Price * stock.Quantity);
            return query.ToList().Sum();
        }

        public decimal TotalReturnValue()
        {
            var query = from returned in db.TReturneds
                        join p in db.TProductGroups on returned.BarcodeID equals p.Barcode
                        where returned.Quantity > 1
                        select (p.Price * returned.Quantity);
            return query.ToList().Sum();
        }
    }
}
