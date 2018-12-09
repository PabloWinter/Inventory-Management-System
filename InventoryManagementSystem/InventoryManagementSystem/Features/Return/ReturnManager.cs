using System;
using System.Windows.Forms;
using InventoryBusinessLayer;

namespace InventoryManagementSystem.Features.Return
{
    public partial class ReturnManager : UserControl
    {
        BReturn returned = new BReturn();
        
        public ReturnManager()
        {
            InitializeComponent();
            returned.GetReturned(dataGridView1);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        { 

        }

       

        private void button3_Click(object sender, EventArgs e)
        {
            returned.GetReturned(dataGridView1);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AddItemToReturn returned = new AddItemToReturn();
            returned.Show();

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            returned.GetReturned(dataGridView1);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditItemInReturn edit = new EditItemInReturn();
            edit.Show();
        }
    }
}
