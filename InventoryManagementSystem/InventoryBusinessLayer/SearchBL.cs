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
        public static void PopulateGrid(DataGridView dataGridView)
        {
            dataGridView.DataSource = SearchDL.AllProducts();
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

        public static void GetResultSetWithWhereClauses(DataGridView dataGrid, string table, string column, string operation, string value, List<string[]> list)
        {
            Type tableType = Type.GetType("InventoryDataLayer." + table + ", InventoryDataLayer");
            var t1 = typeof(SearchDL).GetMethod("GetResultSetWithWhereClauses");
            var t2 = t1.MakeGenericMethod(tableType);
            var t3 = t2.Invoke(null, new object[] { table, column, operation, value, list });
            var obj = t3;
            dataGrid.DataSource = obj;
        }

        public static void GetAllProducts(ComboBox box)
        {
            box.DataSource = SearchDL.GetAllProducts();
        }

        public void GetLocations(ComboBox box, string text)
        {
            box.DataSource = SearchDL.GetLocationsWithProductId(TrimID(text, 7));
        }

        public string GetUnitCost(string barcode, DateTime startDate, DateTime endDate, string location, DataGridView grid)
        {
            // Populate Grid with every record according to user's input parameteres
            grid.DataSource = SearchDL.GetUnitCost(TrimID(barcode, 7), startDate, endDate, TrimID(location, 10));

            // Calculate the average based on the result set obtained from the query
            decimal dividend = 0;
            int divisor = 0;

            for (int i = 0; i < grid.RowCount; i++)
            {
                divisor += Convert.ToInt32(grid.Rows[i].Cells[3].Value); // cell 3 = quantity = divisor
                dividend += Convert.ToDecimal((grid.Rows[i].Cells[4].Value)); // cell 4 = totalcost = dividend
            }

            string mod1 = location.Substring((location.LastIndexOf("=") + 2));
            string locationName = mod1.Substring(0, mod1.LastIndexOf("}") - 1);

            if (divisor != 0)
            {
                decimal averageCost = dividend / Convert.ToDecimal(divisor);
                string result = "The average cost per unit was " + averageCost.ToString("c") + " in " + locationName + ".\r\n" +
                    "Total of Units: " + divisor + ". Total Cost: " + dividend.ToString("c") +". \r\n" +
                    "Start Date: " + startDate.ToShortDateString() + ". End Date: " + endDate.ToShortDateString();
                return result;
            }
            else
            {
                string result = "There are no records in " + locationName + " in the given period of time.";
                return result;
            }

        }

        private int TrimID(string text, int index)
        {
            string mod1 = text.Substring(index);
            string mod2 = mod1.Substring(0, mod1.LastIndexOf(","));
            int convertedValue = Convert.ToInt32(mod2);
            return convertedValue;
        }

    }
}
