using System.Collections.Generic;
using System.Linq;

namespace InventoryDataLayer
{
    public class Stock
    {
        private void ShowProduct()
        {
            using (DataLinqToSQLDataContext products = new DataLinqToSQLDataContext())
            {
                var query = from product in products.TProductGroups
                            select product;

                IQueryable<TProductGroup> prodQuery =
                                       from prod in products.TProductGroups
                                       orderby prod.BrandID
                                       select prod;

                var lambaQuery = products.TProductGroups.OrderBy(x => x.DESCRIPTION).ThenByDescending(x => x.CategoryID);
            }
        }

        public IEnumerable<TProductGroup> GetProducts()
        {
            DataLinqToSQLDataContext connect = new DataLinqToSQLDataContext();

            var query = connect.ExecuteQuery<TProductGroup>(@"SELECT * FROM TProductGroup");

            return query;
        }
    }
}
