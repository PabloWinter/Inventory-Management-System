using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventoryDataLayer;

namespace InventoryBusinessLayer
{
    public class BLocations
    {
        Locations location = new Locations();

        public void LocationListSet (DataGridView datagrid)
        {
            datagrid.DataSource = location.LocationList();
        }

        public List<TLocation> LocationList()
        {
           return location.LocationList();
        }

        public void NewLocation (string name, string address, string city, int phone)
        {
            location.NewLocation(name, address, city, phone);
        }

        public void GetLocationName(ComboBox cbox)
        {
            cbox.DataSource = location.GetLocationName();
        }

        public List<int> GetLocationID()
        {
            return location.GetLocationID();
        }

        public void EditLocation  (int id, string name, string address, string city, int phone)
        {
            location.EditLocation(id, name, address, city, phone);
        }
       
    }
}
