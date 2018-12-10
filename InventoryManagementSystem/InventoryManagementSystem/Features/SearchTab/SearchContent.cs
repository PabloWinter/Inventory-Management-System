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
    public partial class SearchContent : UserControl
    {
        public string requestedTableName;

        public event Action TableChanged;

        public SearchContent()
        {
            InitializeComponent();

            InitialFilter();
        }

        private void InitialFilter()
        {
            InitialFilter aFilter = new InitialFilter();

            requestedTableName = aFilter.TableBoxText;

            // it sets the comboboxes value inside the Initial filter and refreshes it whenever it is updated

            aFilter.OnChangeTable += () => requestedTableName = aFilter.TableBoxText; // !!!!!!!!!!!!!!!!!!!!!!!!!

            // when OnChangeTable occurs inside of InitialFilter it should update the value of the columns inside the ExtraFilters

            requestedTableName = aFilter.TableBoxText;

            aFilter.OnChangeTable += () => requestedTableName = aFilter.TableBoxText;

            aFilter.OnChangeTable += () => TableChanged();

            TableChanged += () => UpdateExtraFilters(requestedTableName, FilterPanel);

            FilterPanel.Controls.Add(aFilter);
        }

        private void UpdateExtraFilters(string name, FlowLayoutPanel panel)
        {
            foreach (ExtraFilter filter in FilterPanel.Controls.OfType<ExtraFilter>())
            {
                filter.ExTableName = name;
                filter.Refresh();
            }
        }

        private void AddFilter_Click(object sender, EventArgs e)
        {

            ExtraFilter extraFilter = new ExtraFilter();
            extraFilter.ExTableName = requestedTableName;

            // whenever TableChanged happens it triggers an update on the value of ExTableName inside extraFilter. ExTableName constructor calls an update on the content of the columns comboBox
            TableChanged += () => extraFilter.ExTableName = requestedTableName;
            FilterPanel.Controls.Add(extraFilter);
            
        }

        private void TestButton_Click(object sender, EventArgs e)
        {
            if (FilterPanel.Controls.Count > 0)
            {
                DataGridView grid = ResultView;
                string tableName = "";
                string columnName = "";
                string operation = "";
                string value = "";
                List<string[]> whereClauses = new List<string[]>();

                foreach (InitialFilter item in FilterPanel.Controls.OfType<InitialFilter>())
                {
                    tableName = item.TableBoxText;
                    columnName = item.ColumnBoxText;
                    operation = item.OpBoxText;
                    value = item.ValueBoxText;
                    

                    // Adjusting for string query LIKE % %
                    if (SearchBL.IsColumnTypeString(item.TableBoxText, item.ColumnBoxText))
                    {
                        value = "%" + item.ValueBoxText + "%";
                    }

                    SearchBL.GetResultSetWithWhereClauses(grid, tableName, columnName, operation, value, whereClauses);
                }

                if (FilterPanel.Controls.Count > 1)
                {
                    foreach (ExtraFilter exFilter in FilterPanel.Controls.OfType<ExtraFilter>())
                    {
                        string[] whereArguments = new string[4];
                        whereArguments[0] = exFilter.ExLogicalBoxText; // AND or OR
                        whereArguments[1] = exFilter.ExColumnBoxText; // Column
                        whereArguments[2] = exFilter.ExOpBoxText; // Operator
                        whereArguments[3] = exFilter.ExValueBoxText; // Value
                        

                        // Adjusting for string query LIKE % %
                        if (SearchBL.IsColumnTypeString(tableName, whereArguments[1]))
                        {
                            whereArguments[3] = "%" + whereArguments[3] + "%";
                        }

                        whereClauses.Add(whereArguments);
                    }
                    SearchBL.GetResultSetWithWhereClauses(grid, tableName, columnName, operation, value, whereClauses);
                }
            }
            
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            FilterPanel.Controls.Clear();
            FilterPanel.Refresh();
            InitialFilter();
            ResultView.DataSource = null;
        }
    }
}

