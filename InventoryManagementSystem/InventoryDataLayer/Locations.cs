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



    }
}
