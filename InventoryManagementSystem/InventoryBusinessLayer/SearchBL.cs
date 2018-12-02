using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryDataLayer;
using System.Windows.Forms;

namespace InventoryBusinessLayer
{
    public class SearchBL
    {
        public static void PopulateGrid(DataGridView dataGridView)
        {
            dataGridView.DataSource = SearchDL.AllProducts().ToList();
        }

        public static void GetAProductGroup(DataGridView dataGridView, string column, string parameter, string value)
        {
            dataGridView.DataSource = SearchDL.GetAProductGroup(column, parameter, value).ToList();
        }

        public static void GetColumnNames(DataGridView dataGridView, string tableName)
        {
            dataGridView.DataSource = SearchDL.GetColumnNames(tableName).ToList();
        }

        public static void PopulateColumnBox(ComboBox comboBox, string tableName)
        {
            comboBox.DataSource = SearchDL.GetColumnNames(tableName);
        }

        public static void PopulateTableBox(ComboBox comboBox)
        {
            comboBox.DataSource = SearchDL.GetTableNames();
        }

        //public static void GetResult(DataGridView dataGridView, string table, string column, string value)
        //{
        //    dataGridView.DataSource = SearchDL.GetResult(table, column, value);
        //}
    }
}