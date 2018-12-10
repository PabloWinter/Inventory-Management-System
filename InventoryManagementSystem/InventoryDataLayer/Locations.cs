using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace InventoryDataLayer
{
    public class Locations
    {
        DataLinqToSQLDataContext db = new DataLinqToSQLDataContext();

        public List<TLocation> LocationList()
        {
            return (from location in db.TLocations select location).ToList();
        }


        public List<string> GetLocationName()
        {
            return (from location in db.TLocations select location.Name).ToList();
        }

        public List<int> GetLocationID()
        {
            return (from location in db.TLocations select location.LocationID).ToList();
        }


        public void NewLocation(string name, string address, string city, int phone)
        {
            TLocation newLocation = new TLocation
            {
                Name = name,
                Address = address,
                City = city,
                Phone = phone
            };

            db.TLocations.InsertOnSubmit(newLocation);

            // Submit the change to the database.
            try
            {
                db.SubmitChanges();
                MessageBox.Show("Successfully added new location");
            }
            catch (Exception e)
            {
                MessageBox.Show("Failed to insert the new location.");
                MessageBox.Show(e.ToString());            
                db.SubmitChanges();
            }
        }

        public void EditLocation(int id, string name, string address, string city, int phone)
        {
            var query = (from location in db.TLocations
                         where location.LocationID == id
                         select location).ToList();

            foreach (TLocation locations  in query)
            {
                locations.Name = name;
                locations.Phone = phone;
                locations.Address = address;
            };

            try
            {
                db.SubmitChanges();
                MessageBox.Show("Item edited successfully.");
            }
            catch (Exception e)
            {
                MessageBox.Show("An error has occured trying to edit this location");
                MessageBox.Show(e.ToString());
            }
        }

    }
}
