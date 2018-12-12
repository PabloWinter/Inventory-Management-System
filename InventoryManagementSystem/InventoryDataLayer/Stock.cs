using System;
using System.Collections;
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
                                 stock.StockID,
                                 stock.BarcodeID,
                                 stock.Quantity,
                                 LocationName = d.Name,
                                 TotalValue = "$" + p.Price * stock.Quantity,
                                 stock.LocationID
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

            var query = from products in db.TProductGroups select products.Barcode;

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
            return (from stock in db.TInStocks select Convert.ToInt32(stock.BarcodeID)).ToList(); 
        }

        public IEnumerable<TInStock> GetStock()
        {
            DataLinqToSQLDataContext conn = new DataLinqToSQLDataContext();
            string sql = "SELECT StockID, BarcodeID, LocationID, Quantity FROM TInStock";

           return conn.ExecuteQuery<TInStock>(sql);

            
        }

        //new stock item
        public void NewStockItem (int barcode, int location, int quantity, string totalcost, DateTime date)
        {
            DataLinqToSQLDataContext connect = new DataLinqToSQLDataContext();

            TInStock newStock = new TInStock
            {
                BarcodeID = barcode,
                LocationID = location,
                Quantity = quantity
            };

            TPurchaseLog newLog = new TPurchaseLog
            {
                BarcodeID = barcode,
                LocationID = location,
                Quantity = quantity,
                Date = date,
                TotalCost = Convert.ToDecimal(totalcost)
            };

            // Add the new object to the Orders collection.
            connect.TInStocks.InsertOnSubmit(newStock);
            connect.TPurchaseLogs.InsertOnSubmit(newLog);

            // Submit the change to the database.
            try
            {
                connect.SubmitChanges();

                MessageBox.Show("Item added to stock successfully.");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        //EDITING STOCK ITEM METHODS

        public object StockNames()
        {
            return from stock in db.TInStocks
                                    join p in db.TProductGroups on stock.BarcodeID equals p.Barcode                                   
                                      select p.Name;
        }

        //locations 
        public List<int> StockLocation()
        {

            return (from stock in db.TInStocks select Convert.ToInt32(stock.LocationID)).ToList();
        }

        public List<string> StockLocationName(int id)
        {
            return (from stock in db.TInStocks
                   join p in db.TLocations on stock.LocationID equals p.LocationID
                   select p.Name).ToList();
        }

        public List<int> StockQuantities()
        {
            return (from stock in db.TInStocks select stock.Quantity).ToList();
        }


        //edit stock item
        public void StockToEdit (int barcode, int location, int quantity)
        {
            var query = from stock in db.TInStocks where stock.BarcodeID == barcode && stock.LocationID == location
                        select stock;

            foreach (TInStock stock in query)
            {               
                stock.Quantity = quantity;
               
            }
                               
            //submit changes
            try
            {
                db.SubmitChanges();
                MessageBox.Show("Item edited successfully.");
            }
            catch (Exception e)
            {
                MessageBox.Show("An error has occured trying to edit this stock item");
                MessageBox.Show(e.ToString());
            }
        }


        public void StockToEditWithLog(int barcode, int location, int quantity, string totalcost, DateTime date)
        {
            var query = from stock in db.TInStocks
                        where stock.BarcodeID == barcode && stock.LocationID == location
                        select stock;

            List<int> oldQuantity = (from stock in db.TInStocks
                                          where stock.BarcodeID == barcode && stock.LocationID == location
                                          select stock.Quantity).ToList();

            int difference = Math.Abs(quantity - oldQuantity[0]);



            MessageBox.Show(difference.ToString());

            foreach (TInStock stock in query)
            {
                stock.Quantity = quantity;

            }

            TPurchaseLog newLog = new TPurchaseLog
            {
                BarcodeID = barcode,
                LocationID = location,
                Date = date,
                Quantity = difference,
                TotalCost = Convert.ToDecimal(totalcost)
            };

            // Add the new object to the Orders collection.
            db.TPurchaseLogs.InsertOnSubmit(newLog);

            //submit changes
            try
            {
                db.SubmitChanges();
                MessageBox.Show("Item edited successfully.");
            }
            catch (Exception e)
            {
                MessageBox.Show("An error has occured trying to edit this stock item");
                MessageBox.Show(e.ToString());
            }
        }

        //delete stock item       
        public void DeleteStockItem (int barcode, int locationid)
        {
            var query = from stock in db.TInStocks
                        where stock.BarcodeID == barcode && stock.LocationID == locationid
                        select stock;
            foreach (TInStock stockItem in query)
            {
                db.TInStocks.DeleteOnSubmit(stockItem);
            }

            try
            {
                db.SubmitChanges();
            }
            catch (Exception e)
            {
                MessageBox.Show("Failed to delete stock item");
                MessageBox.Show(e.ToString());
                //  
            }
        }      
    }
}
