using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryDataLayer
{
    public class Category
    {
        public object ShowCategories()
        {
            DataLinqToSQLDataContext category = new DataLinqToSQLDataContext();

            var query = from categories in category.TCategories
                         select new
                         {
                             categories.Name                          
                         };

            return query.ToList();
        }

        public void UpdateCategory(int categoryId, string cateName)
        {
            using (DataLinqToSQLDataContext category = new DataLinqToSQLDataContext())
            {
                TCategory editCategory = category.TCategories.SingleOrDefault(x => x.CategoryID == categoryId);

                editCategory.Name = cateName;

                category.SubmitChanges();
            }
        }

        public void InsertCategory(string categoryName)
        {
            using (DataLinqToSQLDataContext category = new DataLinqToSQLDataContext())
            {
                TCategory newCategory = new TCategory
                {
                    Name = categoryName
                };

                category.TCategories.InsertOnSubmit(newCategory);
                category.SubmitChanges();
            }
        }

        public object ShowComboCategory()
        {
            DataLinqToSQLDataContext category = new DataLinqToSQLDataContext();

            var result = from categories in category.TCategories
                         select new
                         {
                             categories.Name
                         };

            return result.ToList();
        }

        public List<int> GetCategories()
        {
            DataLinqToSQLDataContext category = new DataLinqToSQLDataContext();

            var result = from cat in category.TCategories
                        select cat.CategoryID;

            return result.ToList();
        }
    }
}
