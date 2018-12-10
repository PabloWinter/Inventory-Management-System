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

            var test3 = connect.ExecuteQuery<TBrand>(   @"SELECT *
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
                // Using this if to remove a sensitive table that was added later on the development process. This should not be displayed to the users.
                if (!result.RowType.ToString().Contains("TManagerInventory"))
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

        public static object GetAllProducts()
        {
            DataLinqToSQLDataContext connect = new DataLinqToSQLDataContext();

            var result = from product in connect.TProductGroups
                         select new
                         {
                             ID = product.Barcode, // If this tag is modified it will impact on the string splitting (Substring) that happens in TrimID located at SearchBL
                             product.Name,
                         };
            
            return result.ToList();
        }

        public static object GetLocationsWithProductId(int value)
        {
            DataLinqToSQLDataContext connect = new DataLinqToSQLDataContext();

            var result =    from product in connect.TPurchaseLogs
                            join location in connect.TLocations
                            on product.LocationID equals location.LocationID
                            where product.BarcodeID == value
                            select new
                            {
                                LocID = product.LocationID,
                                Base = location.Name,
                            };

            var distinctResult = result.Distinct().ToList();

            // Adding extra line in the result so we can query independently from product's location;
            var emptyObj = new { LocID = (int?)0, Base = "All Locations" };

            distinctResult.Add(emptyObj);

            return distinctResult.ToList();
        }


        public static object GetUnitCost(int barcode, DateTime startDate, DateTime endDate, int location)
        {
            DataLinqToSQLDataContext connect = new DataLinqToSQLDataContext();

            if (location != 0)
            {
                var result = from pl in connect.TPurchaseLogs
                             join lo in connect.TLocations
                             on pl.LocationID equals lo.LocationID
                             join pg in connect.TProductGroups
                             on pl.BarcodeID equals pg.Barcode
                             where pl.BarcodeID == barcode &&
                             pl.Date >= startDate &&
                             pl.Date <= endDate &&
                             pl.LocationID == location
                             select new JoinResultGetUnitCostMethod
                             {
                                 TrNmb = pl.TransactionID,
                                 ProductName = pg.FullProductName,
                                 Location = lo.Name,
                                 Quantity = pl.Quantity,
                                 TotalCost = pl.TotalCost
                             };

                return result.ToList();
            }

            else
            {
                var result = from pl in connect.TPurchaseLogs
                             join lo in connect.TLocations
                             on pl.LocationID equals lo.LocationID
                             join pg in connect.TProductGroups
                             on pl.BarcodeID equals pg.Barcode
                             where pl.BarcodeID == barcode &&
                             pl.Date >= startDate &&
                             pl.Date <= endDate
                             select new JoinResultGetUnitCostMethod
                             {
                                 TrNmb = pl.TransactionID,
                                 ProductName = pg.FullProductName,
                                 Location = lo.Name,
                                 Quantity = pl.Quantity,
                                 TotalCost = pl.TotalCost
                             };

                return result.ToList();
            }
        }

        public class JoinResultGetUnitCostMethod
        {
            public int TrNmb { get; set; }
            public string ProductName { get; set; }
            public string Location { get; set; }
            public int Quantity { get; set; }

            private decimal _totalCost;

            public decimal TotalCost {
                get {
                    var temp = decimal.Round(_totalCost, 2);
                    return temp;
                }
                set { _totalCost = value; }
            }
        }
    }
}
