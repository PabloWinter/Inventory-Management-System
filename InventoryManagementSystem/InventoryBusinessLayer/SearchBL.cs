using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryDataLayer;
using System.Windows.Forms;
using System.Diagnostics;

namespace InventoryBusinessLayer
{
    public class SearchBL
    {
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

        public static void CheckColumnType(string tableName, string column, ComboBox comboBox)
        {
            
            var columnType = SearchDL.CheckColumnType("dbo." + tableName, column);
            
            if (columnType == typeof(System.String))
            {
                comboBox.DropDownStyle = ComboBoxStyle.DropDown;
                comboBox.Text = "LIKE";
                comboBox.Enabled = false;
            }
            else
            {
                comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
                comboBox.Enabled = true;
            }
        }

        public static bool IsColumnTypeString(string tableName, string column)
        {
            var columnType = SearchDL.CheckColumnType("dbo." + tableName, column);

            if (columnType == typeof(System.String))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void GetProductGroup(DataGridView dataGrid, string column, string operation, string value)
        {
            dataGrid.DataSource = SearchDL.GetProductGroup(column, operation, value).ToList();
        }

        public static void GetResultSet(DataGridView dataGrid, string table, string column, string operation, string value)
        {
            Type tableType = Type.GetType("InventoryDataLayer." + table + ", InventoryDataLayer");
            var t1 = typeof(SearchDL).GetMethod("GetResultSet");
            var t2 = t1.MakeGenericMethod(tableType);
            var t3 = t2.Invoke(null, new object[] { table, column, operation, value });
            var obj = t3;
            dataGrid.DataSource = obj;
        }

        public static void GetResultSetWithWhereClauses(DataGridView dataGrid, string table, string column, string operation, string value, List<string[]> list)
        {
            Type tableType = Type.GetType("InventoryDataLayer." + table + ", InventoryDataLayer");
            var t1 = typeof(SearchDL).GetMethod("GetResultSetWithWhereClauses");
            var t2 = t1.MakeGenericMethod(tableType);
            var t3 = t2.Invoke(null, new object[] { table, column, operation, value, list });
            var obj = t3;
            dataGrid.DataSource = obj;
        }
    }
}