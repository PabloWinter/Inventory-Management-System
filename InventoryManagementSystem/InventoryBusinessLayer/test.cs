using InventoryDataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryBusinessLayer
{
    public partial class test : Form
    {
        public test()
        {
            InitializeComponent();

            using (DataLinqToSQLDataContext products = new DataLinqToSQLDataContext())
            {
                var query = from product in products.TProductGroups
                            select product;

                //return query;

                dataGridView1.DataSource = query;
            }
        }
    }
}
