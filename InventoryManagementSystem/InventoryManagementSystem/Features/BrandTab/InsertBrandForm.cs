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

namespace InventoryManagementSystem.Features.BrandTab
{
    public partial class InsertBrandForm : Form
    {
        BBrand brand = new BBrand();

        public InsertBrandForm()
        {
            InitializeComponent();
        }

        private void InsertBrand_Click(object sender, EventArgs e)
        {
            try
            {
                string brandName = txtBrandName.Text;

                brand.InsertIntoDatabase(brandName);
                MessageBox.Show("Brand was successfully inserted!", "Insert Brand", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Insert a new product", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
