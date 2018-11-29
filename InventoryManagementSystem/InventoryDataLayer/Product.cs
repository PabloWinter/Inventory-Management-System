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
                // dataGridView1.DataSource = employee.GetTable<TOrderItem>();

                var query = from product in products.TProductGroups
                            select product;

                IQueryable<TProductGroup> prodQuery =
                                       from prod in products.TProductGroups
                                       orderby prod.BrandID
                                       select prod;

                //var query = item.PR_Employees.OrderBy(x => x.FirstName).ThenByDescending(x => x.HourlyRate);

                dataGridView1.DataSource = custQuery;

            }

        }
    }
}
