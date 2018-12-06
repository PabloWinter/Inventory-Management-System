using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryDataLayer
{
    public class Product
    {
        // EXAMPLE QUERY
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

        public object ShowInventoryProduct()
        {
            DataLinqToSQLDataContext products = new DataLinqToSQLDataContext();

            var result = from product in products.TProductGroups
                        select new
                        {
                            product.Name,
                            product.Price,
                            product.Tax,
                            product.Discount,
                            product.DESCRIPTION,
                            product.CategoryID,
                            product.BrandID,
                            product.FullProductName,
                            product.ShortProductName
                        }; 

            return result.ToList();
        }

        public void InsertNewProduct(string name, decimal price, decimal tax, decimal discount, string description, int FKcategory, int FKbrand, string fullName, string shortName)
        {
            // Using 'using' to dispose connection after the new product
            // gets inserted into the database.

            using (DataLinqToSQLDataContext product = new DataLinqToSQLDataContext())
            {
                // instantiating a new object that will be inserted into database
                TProductGroup newProduct = new TProductGroup
                {
                    Name = name,
                    Price = price,
                    Tax = tax,
                    Discount = discount,
                    DESCRIPTION = description,
                    CategoryID = FKcategory,
                    BrandID = FKbrand,
                    FullProductName = fullName,
                    ShortProductName = shortName
                };

                product.TProductGroups.InsertOnSubmit(newProduct);
                product.SubmitChanges();
            }
        }

        public void UpdateProduct(int indexEditProduct, string name, decimal price, decimal tax, decimal discount, string description, string fullName, string shortName)
        {
            // Updating product information
            
            using (DataLinqToSQLDataContext product = new DataLinqToSQLDataContext())
            {
                TProductGroup editProduct = product.TProductGroups.SingleOrDefault(x => x.Barcode == indexEditProduct);

                editProduct.Name = name;
                editProduct.Price = price;
                editProduct.Tax = tax;
                editProduct.Discount = discount;
                editProduct.DESCRIPTION = description;
                editProduct.FullProductName = fullName;
                editProduct.ShortProductName = shortName;
                
                product.SubmitChanges();
            }
        }
    }
}
