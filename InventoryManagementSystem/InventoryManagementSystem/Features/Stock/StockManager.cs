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

namespace InventoryManagementSystem.Features.Stock
{
    public partial class StockManager : UserControl
    {
        BStock Stock = new BStock();

        public StockManager()
        {
            InitializeComponent();
        }

        private void StockManager_Load(object sender, EventArgs e)
        {
            Stock.GetProducts(dataGridView1);
        }
    }
}
