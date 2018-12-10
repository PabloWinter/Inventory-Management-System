using InventoryBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem.Features.Location
{
    public partial class EditLocation : Form
    {
        BLocations location = new BLocations();
        public EditLocation()
        {
            InitializeComponent();
            location.GetLocationName(locationName);
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            int phone = 0;
            if (Int32.TryParse(locationPhone.Text, out phone))
            {
                location.EditLocation(location.LocationList()[locationName.SelectedIndex].LocationID, newLocartionName.Text, locationAddress.Text, locationCity.Text, phone);
                Close();
            }
            else
            {
                MessageBox.Show("Invalid phone number");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            newLocartionName.Text = location.LocationList()[locationName.SelectedIndex].Name;
            locationAddress.Text = location.LocationList()[locationName.SelectedIndex].Address;
            locationCity.Text = location.LocationList()[locationName.SelectedIndex].City;
            locationPhone.Text = location.LocationList()[locationName.SelectedIndex].Phone.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
