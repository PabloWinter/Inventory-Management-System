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

        public void LocationList (DataGridView datagrid)
        {
            datagrid.DataSource = location.LocationList();
        }
    }
}
