using System;
using System.Collections.Generic;
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
                listOfTables.Add(result.TableName);
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
                if (result.TableName.Equals(tableName))
                {
                    foreach (var tableDetails in result.RowType.DataMembers)
                    {
                        Debug.WriteLine(tableDetails.MappedName);
                        listOfColumns.Add(tableDetails.MappedName);
                    }
                    return listOfColumns;
                }
            }

            return null;
        }


        public static IEnumerable<TProductGroup> GetAProductGroup(string column, string parameter, string value)
        {
            DataLinqToSQLDataContext connect = new DataLinqToSQLDataContext();

            string sqlStatement = "SELECT * FROM TProductGroup WHERE TProductGroup." + column + " " + parameter + " " + "'" + value + "'";

            var query = connect.ExecuteQuery<TProductGroup>(sqlStatement);

            return query;
        }


        //public static IQueryable GetResult(string table, string column, string theValue)
        //{
        //    //IEnumerable<TProductGroup> GetAProductGroup(string column, string theValue)
        //    //{
        //        DataLinqToSQLDataContext connect = new DataLinqToSQLDataContext();

        //        string sqlStatement = "SELECT " + table + " FROM TProductGroup WHERE TProductGroup." + column + " = " + "'" + theValue + "'";

        //        //Type queryType = Type.GetType(table);
        //        Type queryType = Type.GetType(table);

        //        var query = connect.ExecuteQuery<TProductGroup>(sqlStatement);

        //        return (IQueryable)query;
        //    //}

        //    //return null;
        //}


    }
}