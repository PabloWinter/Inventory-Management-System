using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryDataLayer
{
    public class SearchDL
    {
        DataLinqToSQLDataContext connect = new DataLinqToSQLDataContext();

        public void BrandById(int value)
        {
            var test1 = connect.TBrands.Select(r => r.BrandID == value);

            var test2 = from r in connect.TBrands
                        where r.BrandID == value
                        select r;

            var test3 = connect.ExecuteQuery<TBrand>(@"SELECT *
                                                        FROM TBrand
                                                        WHERE BrandID = {0}", value);


        }

        public static IEnumerable<TProductGroup> AllProducts()
        {
            DataLinqToSQLDataContext connect = new DataLinqToSQLDataContext();

            var query = connect.ExecuteQuery<TProductGroup>("SELECT * FROM TProductGroup");

            return query;
        }

        public static List<string> GetTableNames()
        {
            DataLinqToSQLDataContext connect = new DataLinqToSQLDataContext();

            var dataModel = connect.Mapping;

            List<string> listOfTables = new List<string>();

            foreach (var result in dataModel.GetTables())
            {
                listOfTables.Add(result.RowType.ToString());
            }

            return listOfTables;
        }


        public static List<string> GetColumnNames(string tableName)
        {
            DataLinqToSQLDataContext connect = new DataLinqToSQLDataContext();

            var dataModel = connect.Mapping;

            List<string> listOfColumns = new List<string>();

            foreach (var result in dataModel.GetTables())
            {
                if (result.TableName.Equals("dbo." + tableName))
                {
                    foreach (var tableDetails in result.RowType.DataMembers)
                    {
                        // Using this if to remove columns with "_" because they belong to foreing keys. This should not be displayed to user.
                        if (!tableDetails.MappedName.Contains("_"))
                        {
                            listOfColumns.Add(tableDetails.MappedName);
                        }
                    }
                    return listOfColumns;
                }
            }
            return null;
        }

        public static Type CheckColumnType(string tableName, string column)
        {
            DataLinqToSQLDataContext connect = new DataLinqToSQLDataContext();

            var dataModel = connect.Mapping;

            foreach (var result in dataModel.GetTables())
            {
                if (result.TableName.Equals(tableName))
                {
                    foreach (var tableDetails in result.RowType.DataMembers)
                    {
                        if (tableDetails.MappedName == column)
                        {
                            return tableDetails.Type;
                        }
                    }
                }
            }

            return null;
        }

        protected static MetaTable GetTableType(string tableName)
        {
            DataLinqToSQLDataContext connect = new DataLinqToSQLDataContext();

            var dataModel = connect.Mapping;

            foreach (var result in dataModel.GetTables())
            {
                if (result.TableName.Equals(tableName))
                {
                    return result;
                }
            }

            return null;
        }

        public static IEnumerable<TProductGroup> GetProductGroup(string column, string parameter, string value)
        {
            DataLinqToSQLDataContext connect = new DataLinqToSQLDataContext();

            string sqlStatement = "SELECT * FROM TProductGroup WHERE TProductGroup." + column + " " + parameter + " " + "'" + value + "'";

            var query = connect.ExecuteQuery<TProductGroup>(sqlStatement);
            
            return query;
        }

        public static IEnumerable<T> GetResultSetWithWhereClauses<T>(string table, string column, string parameter, string value, List<string[]> list)
        {
            DataLinqToSQLDataContext connect = new DataLinqToSQLDataContext();

            StringBuilder sb = new StringBuilder();

            foreach (string[] clause in list)
            {
                string whereClause = clause[0] + " " + table + "." + clause[1] + " " + clause[2] + "'" + clause[3] + "' ";
                sb.Append(whereClause);
            }

            string sqlStatement = "SELECT * FROM dbo." + table + " WHERE " + table + "." + column + " " + parameter + " " + "'" + value + "' " + sb.ToString();

            var query = connect.ExecuteQuery<T>(sqlStatement);

            return query.ToList();
        }

        //public static IQueryable GetResultSet(string table, string column, string operation, string value)
        //{
        //    DataLinqToSQLDataContext connect = new DataLinqToSQLDataContext();

        //    // I have to find a way to select the right returning type. It must be selected based on user's search.
        //    var tableType2 = GetTableType(table);

        //    Debug.WriteLine(tableType2 + "111111");

        //    Type tableType = tableType2;//Type.GetType(table.Substring(4));
        //    Debug.WriteLine(tableType + "*******");

        //    string sqlStatement = "SELECT * FROM " + table + " WHERE " + table + "." + column + " " + operation + " " + "'" + value + "'";

        //    var query = connect.ExecuteQuery(tableType, sqlStatement);

        //    return (IQueryable)query;
        //}


    }
}