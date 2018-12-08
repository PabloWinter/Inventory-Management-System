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
    public partial class InitialFilter : UserControl
    {
        string[] listOfOperators = { "=", "<", "<=", ">=", ">", "!=" };

        public event Action OnChangeTable;

        public InitialFilter()
        {
            InitializeComponent();
            SearchBL.PopulateTableBox(TableBox);
            OpBox.DataSource = listOfOperators;
        }

        public string TableBoxText
        {
            get
            {
                return TableBox.Text;
            }
        }

        public string ColumnBoxText
        {
            get
            {
                return ColumnBox.Text;
            }
        }

        public string OpBoxText
        {
            get
            {
                return OpBox.Text;
            }
        }

        public string ValueBoxText
        {
            get
            {
                return ValueBox.Text;
            }
        }

        private void TableBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchBL.PopulateColumnBox(ColumnBox, TableBox.Text);
            
        }

        private void ColumnBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchBL.CheckColumnType(TableBox.Text, ColumnBox.Text, OpBox);
        }

        private void ColumnBox_SelectedValueChanged(object sender, EventArgs e)
        {
            OpBox.Text = "=";
        }

        private void TableBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            OnChangeTable();
        }
    }
}
