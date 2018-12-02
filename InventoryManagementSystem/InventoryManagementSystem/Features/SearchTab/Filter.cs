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

namespace InventoryManagementSystem.Features.SearchTab
{
    public partial class Filter : UserControl
    {
        public Filter()
        {
            InitializeComponent();
            SearchBL.PopulateTableBox(TableBox);
        }

        private void TableBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchBL.PopulateColumnBox(ColumnBox, TableBox.Text);
        }
    }
}
