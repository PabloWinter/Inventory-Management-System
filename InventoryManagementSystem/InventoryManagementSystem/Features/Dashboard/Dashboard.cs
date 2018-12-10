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

namespace InventoryManagementSystem.Features.Dashboard
{
    public partial class Dashboard : UserControl
    {
        BDashboard dashboard = new BDashboard();
        public Dashboard()
        {
            InitializeComponent();
            dashboard.GetStockQuantity(stockCount);
            dashboard.GetOutOfStockQuantity(outOfStockCount);
            dashboard.GetLowInStockQuantitiy(runningLowCount);
            dashboard.StockItemCount(totalStockItemCount);
            dashboard.LocationCount(locationCount);
            dashboard.StockValue(stockValue);
            dashboard.GetReturnQuantity(returnCount);
            dashboard.ReturnValue(returnValue);
            dashboard.CategoryCount(categoryCount);
            dashboard.BrandCount(brandCount);
            dashboard.ProductCount(productCount);
            dashboard.PurchaseCost(purchaseCost);
            dashboard.PurchaseLogCount(purchaseLogCount);

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        //reload
        private void button3_Click(object sender, EventArgs e)
        {
            dashboard.GetStockQuantity(stockCount);
            dashboard.GetOutOfStockQuantity(outOfStockCount);
            dashboard.GetLowInStockQuantitiy(runningLowCount);
            dashboard.StockItemCount(totalStockItemCount);
            dashboard.LocationCount(locationCount);
            dashboard.StockValue(stockValue);
            dashboard.GetReturnQuantity(returnCount);
            dashboard.ReturnValue(returnValue);
            dashboard.CategoryCount(categoryCount);
            dashboard.BrandCount(brandCount);
            dashboard.ProductCount(productCount);
            dashboard.PurchaseCost(purchaseCost);
            dashboard.PurchaseLogCount(purchaseLogCount);
        }
    }
}
