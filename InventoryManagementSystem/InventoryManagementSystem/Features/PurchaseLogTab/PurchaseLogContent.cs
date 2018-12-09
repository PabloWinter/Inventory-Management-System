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
using System.Diagnostics;

namespace InventoryManagementSystem.Features.PurchaseLogTab
{
    public partial class PurchaseLogContent : UserControl
    {
        SearchBL bl = new SearchBL();

        public PurchaseLogContent()
        {
            InitializeComponent();
            SearchBL.GetAllProducts(ProductBox);
        }

        private void RunQuery_Click(object sender, EventArgs e)
        {
            ResultLabel.Text = bl.GetUnitCost(ProductBox.Text, InitialDatePicker.Value.Date, FinalDatePicker.Value.Date, LocationBox.Text, ResultView);
        }

        private void ProductBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var comboBoxText = ProductBox.SelectedValue.ToString();
            bl.GetLocations(LocationBox, comboBoxText);
        }
    }
}
