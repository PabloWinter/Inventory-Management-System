using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventoryDataLayer;

namespace InventoryBusinessLayer
{
    public class BDashboard
    {
        Dashboard dashboard = new Dashboard();

        public void GetStockQuantity (Label label)
        {
            label.Text = dashboard.StockCount().ToString();
        }

        public void GetOutOfStockQuantity(Label label)
        {
            label.Text = dashboard.OutOfStockCount().ToString();
        }

        public void GetLowInStockQuantitiy(Label label)
        {
            label.Text = dashboard.RunningLowInStock().ToString();
        }

        public void StockItemCount(Label label)
        {
            label.Text = dashboard.StockItemCount().ToString();
        }

        public void LocationCount(Label label)
        {
            label.Text = dashboard.LocationCount().ToString();
        }

        public void StockValue(Label label)
        {
            label.Text = "$" + dashboard.TotalStockValue().ToString("0.##");
        }
    }
}
