using System;
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
            Stock.GetStock(dataGridView1);
        }

        private void StockManager_Load(object sender, EventArgs e)
        {
          
        }

        //launch add item to stock form
        private void button1_Click(object sender, EventArgs e)
        {
            AddItemToStock form = new AddItemToStock();
            form.Show();
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditItemInStock form = new EditItemInStock();
            form.Show();
        }

        //refresh the data grid
        private void button3_Click(object sender, EventArgs e)
        {
            Stock.GetStock(dataGridView1);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
