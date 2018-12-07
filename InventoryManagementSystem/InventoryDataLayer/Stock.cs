using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace InventoryDataLayer
{
    public class Stock
    {
        DataLinqToSQLDataContext db = new DataLinqToSQLDataContext();

        private void ShowProduct()
        {
            using (DataLinqToSQLDataContext products = new DataLinqToSQLDataContext())
            {

                var query = from product in products.TProductGroups
                            select product;

                IQueryable<TProductGroup> prodQuery =
                                       from prod in products.TProductGroups
                                       orderby prod.BrandID
                                       select prod;

                var lambaQuery = products.TProductGroups.OrderBy(x => x.DESCRIPTION).ThenByDescending(x => x.CategoryID);
            }
        }

        public object GetStockList()
        {     

           var table1 = db.GetTable<TProductGroup>();
            var tab2 = db.GetTable<TInStock>();
            var tab3 = db.GetTable<TLocation>();
            //db.GetTable<TInStock>();
            var prodQuery = (from stock in tab2
                             join p in table1 on stock.BarcodeID equals p.Barcode
                             join d in tab3 on stock.LocationID equals d.LocationID
                             select new 
                             {
                                 p.Name,
                                 stock.Quantity,
                                 LocationName = d.Name
                             }).ToList();

           //var query = db.ExecuteQuery(@"
           //  SELECT BarcodeID, Name, Quantity FROM TInStock
           //  LEFT JOIN TProductGroup ON
           //  TInStock.BarcodeID = TProductGroup.Barcode");

            return prodQuery;
        }

        public IQueryable GetProductList()
        {
            DataLinqToSQLDataContext db = new DataLinqToSQLDataContext();

            var query = from prodcuts in db.TProductGroups select prodcuts.Name;
            
            return query;
        }


        public List<int> GetBarcode()
        {
            DataLinqToSQLDataContext db = new DataLinqToSQLDataContext();

            var query = from prodcuts in db.TProductGroups select prodcuts.Barcode;

            return query.ToList();
        }


        public IQueryable GetLocationList()
        {        
            var query = from locations in db.TLocations select locations.Name;

            return query;
        }

        public List<int> GetLocationListId()
        {
            var query = from locations in db.TLocations select locations.LocationID;

            return query.ToList();
        }

        public List<int> GetStockBarcode ()
        {
            return (from stock in db.TInStocks select stock.BarcodeID).ToList(); 
        }

        //new stock item
        public void NewStockItem (int barcode, int location, int quantity)
        {
            DataLinqToSQLDataContext connect = new DataLinqToSQLDataContext();

            TInStock newStock = new TInStock
            {
                BarcodeID = barcode,
                LocationID = location,
                Quantity = quantity
            };

            // Add the new object to the Orders collection.
            connect.TInStocks.InsertOnSubmit(newStock);

            // Submit the change to the database.
            try
            {
                connect.SubmitChanges();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                // Make some adjustments.
                // ...
                // Try again.
                connect.SubmitChanges();
            }
        }
    }
}
