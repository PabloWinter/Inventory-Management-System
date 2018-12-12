using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace InventoryDataLayer
{
    public class Return
    {
        DataLinqToSQLDataContext db = new DataLinqToSQLDataContext();

        public object GetReturnList()
        {
            var table1 = db.GetTable<TProductGroup>();
            var tab2 = db.GetTable<TReturned>();
            var tab3 = db.GetTable<TLocation>();
            //db.GetTable<TInStock>();
            var prodQuery = (from returned in tab2
                             join p in table1 on returned.BarcodeID equals p.Barcode
                             join d in tab3 on returned.LocationID equals d.LocationID
                             select new
                             {
                                 returned.BarcodeID,
                                 p.Name,
                                 returned.Quantity,
                                 LocationName = d.Name,
                                 returned.LocationID
                             }).ToList();
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

        public List<int> GetReturnedBarcode()
        {
            return (from returned in db.TReturneds select Convert.ToInt32(returned.BarcodeID)).ToList();
        }

        public List<TReturned> GetReturn()
        {
            return (from returned in db.TReturneds select returned).ToList();
        }


        //new stock item
        public void NewReturnedItem(int barcode, int location, int quantity)
        {

            TReturned newReturn = new TReturned
            {
                BarcodeID = barcode,
                LocationID = location,
                Quantity = quantity
            };

            // Add the new object to the Orders collection.
            db.TReturneds.InsertOnSubmit(newReturn);

            // Submit the change to the database.
            try
            {
                db.SubmitChanges();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                 
                db.SubmitChanges();
            }
        }

        //EDITING RETURN ITEM METHODS

        public object ReturnNames()
        {
            return from returned in db.TReturneds
                   join p in db.TProductGroups on returned.BarcodeID equals p.Barcode
                   select p.Name;
        }

        //locations 
        public List<int> ReturnLocation()
        {
            return (from returned in db.TInStocks select Convert.ToInt32(returned.LocationID)).ToList();
        }

        public List<string> ReturnedLocationName(int id)
        {
            return (from returned in db.TReturneds
                    join p in db.TLocations on returned.LocationID equals p.LocationID
                    select p.Name).ToList();
        }

        public List<int> ReturnQuantities()
        {
            return (from returned in db.TReturneds select returned.Quantity).ToList();
        }


        //edit return item
        public void ReturnToEdit(int barcode, int location, int quantity)
        {
            var query = from returned in db.TReturneds
                        where returned.BarcodeID == barcode && returned.LocationID == location
                        select returned;

            foreach (TReturned returned in query)
            {
                returned.Quantity = quantity;
            }

            //submit changes
            try
            {
                db.SubmitChanges();
                MessageBox.Show("return item edited successfully.");
            }
            catch (Exception e)
            {
                MessageBox.Show("An error has occured trying to edit this return item");
                MessageBox.Show(e.ToString());
            }
        }

        //delete stock item       
        public void DeleteReturnItem(int barcode, int locationid)
        {
            var query = from returned in db.TReturneds
                        where returned.BarcodeID == barcode && returned.LocationID == locationid
                        select returned;
            foreach (TReturned stockItem in query)
            {
                db.TReturneds.DeleteOnSubmit(stockItem);
            }
            try
            {
                db.SubmitChanges();
                MessageBox.Show("Item deleted successfully.");
            }
            catch (Exception e)
            {
                MessageBox.Show("Failed to delete return item");
                MessageBox.Show(e.ToString());
                //  
            }
        }
    }
}
