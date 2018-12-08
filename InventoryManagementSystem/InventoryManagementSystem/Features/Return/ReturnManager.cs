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
    }
}
