using System;
using System.Windows.Forms;
using InventoryBusinessLayer;

namespace InventoryManagementSystem.Features.Location
{
    public partial class AddNewLocation : Form
    {
        BLocations location = new BLocations();
        public AddNewLocation()
        {
            InitializeComponent();
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            int phone = 0;
            if (int.TryParse(locationPhone.Text, out phone))
            {
                location.NewLocation(locationName.Text, locationAddress.Text, locationCity.Text, phone);
                Close();
            }
            else
            {
                MessageBox.Show("Invalid phone number");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
