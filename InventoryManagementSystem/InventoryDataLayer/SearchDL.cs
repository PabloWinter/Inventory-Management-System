using System;
using System.Collections.Generic;
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

            var result = connect.ExecuteQuery<TProductGroup>(@"SELECT *
                                                        FROM TProductGroup");
            return result;
        }
    }
}
