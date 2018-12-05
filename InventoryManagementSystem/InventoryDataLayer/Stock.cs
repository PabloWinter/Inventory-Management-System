using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace InventoryDataLayer
{
    public class Stock
    {
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

        public IEnumerable<TInStock> GetProducts()
        {
            DataLinqToSQLDataContext connect = new DataLinqToSQLDataContext();

            var query = connect.ExecuteQuery<TInStock>(@"SELECT * FROM TInStock");

            return query;
        }

        public IEnumerable<TInStock> GetProductList()
        {
            DataLinqToSQLDataContext connect = new DataLinqToSQLDataContext();

            var query = connect.ExecuteQuery<TInStock>(@"SELECT * FROM TInStock");


            //var query = from product in TProductGroup
            //            join p in TProduct on product.Barcode equals p.Barcode
            //            select product.Name;

            return query;
        }


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

        //public IEnumerable<TProductGroup> NewStockItem()
        //{
        //    DataLinqToSQLDataContext connect = new DataLinqToSQLDataContext();

        //    //var query = connect.ExecuteQuery<TProductGroup>(@"SELECT * FROM TProductGroup");

        //    TProductGroup newP = new TProductGroup
        //    {


        //    };

        //    return query;
        //}
    }
}
