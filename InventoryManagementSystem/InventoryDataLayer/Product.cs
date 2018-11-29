using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryDataLayer
{
    class Product
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
    }
}
