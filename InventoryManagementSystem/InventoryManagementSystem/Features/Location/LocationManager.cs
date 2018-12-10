using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventoryBusinessLayer;

namespace InventoryManagementSystem.Features.Location
{
    public partial class LocationManager : UserControl
    {

        BLocations locations = new BLocations();
        public LocationManager()
        {
            InitializeComponent();
            locations.LocationListSet(dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddNewLocation newlocation = new AddNewLocation();
            newlocation.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            locations.LocationListSet(dataGridView1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditLocation edit = new EditLocation();
            edit.Show();
        }
    }
}
