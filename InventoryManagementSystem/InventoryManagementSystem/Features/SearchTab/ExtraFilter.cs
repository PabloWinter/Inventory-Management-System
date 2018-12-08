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
    public partial class ExtraFilter : UserControl
    {
        string[] listOfOperators = { "=", "<", "<=", ">=", ">", "!=" };

        string[] listOfLogicalOperators = { "OR", "AND" };

        public ExtraFilter()
        {
            InitializeComponent();
            ExLogicalBox.DataSource = listOfLogicalOperators;
            ExOpBox.DataSource = listOfOperators;
        }

        private string exTableName;

        public string ExTableName
        {
            get { return exTableName; }
            set
            {
                exTableName = value;
                RefreshColumns(exTableName);
            }
        }

        public string ExLogicalBoxText
        {
            get
            {
                return ExLogicalBox.Text;
            }
        }

        public string ExColumnBoxText
        {
            get
            {
                return ExColumnBox.Text;
            }
        }

        public string ExOpBoxText
        {
            get
            {
                return ExOpBox.Text;
            }
        }

        public string ExValueBoxText
        {
            get
            {
                return ExValueBox.Text;
            }
        }

        private void RefreshColumns(string newTableName)
        {
            SearchBL.PopulateColumnBox(ExColumnBox, newTableName);
        }

        private void ExColumnBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchBL.CheckColumnType(ExTableName, ExColumnBoxText, ExOpBox);
        }

        private void ExColumnBox_SelectedValueChanged(object sender, EventArgs e)
        {
            ExOpBox.Text = "=";
        }
    }
}
