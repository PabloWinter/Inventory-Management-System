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
        public object ShowInventoryProduct()
        {
            DataLinqToSQLDataContext products = new DataLinqToSQLDataContext();

            var result = from product in products.TProductGroups
                        select new
                        {
                            product.Barcode,
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

        public void UpdateProduct(int barcode, string name, decimal price, decimal tax, decimal discount, string description, int category, int brand, string fullName, string shortName)
        {
            // Updating product information
            
            using (DataLinqToSQLDataContext product = new DataLinqToSQLDataContext())
            {
                TProductGroup editProduct = product.TProductGroups.SingleOrDefault(x => x.Barcode == barcode);

                editProduct.Name = name;
                editProduct.Price = price;
                editProduct.Tax = tax;
                editProduct.Discount = discount;
                editProduct.DESCRIPTION = description;
                editProduct.CategoryID = category;
                editProduct.BrandID = brand;
                editProduct.FullProductName = fullName;
                editProduct.ShortProductName = shortName;

                product.SubmitChanges();
            }
        }

        public object ShowComboCategory()
        {
            DataLinqToSQLDataContext combo = new DataLinqToSQLDataContext();

            var result = from combos in combo.TCategories
                         select new
                         {
                             combos.Name
                         };

            return result.ToList();
        }

        public object ShowComboBrand()
        {
            DataLinqToSQLDataContext brand = new DataLinqToSQLDataContext();

            var result = from brands in brand.TBrands
                         select new
                         {
                             brands.Name
                         };

            return result.ToList();
        }

        public object PopulateComboProduct(string param)
        {
            DataLinqToSQLDataContext products = new DataLinqToSQLDataContext();

            string query = "SELECT Barcode, " + param + " FROM TProductGroup";

            var result = products.ExecuteQuery<TProductGroup>(query);

            return result.ToList();
        }

        public object PopulateComboBarcode(string param)
        {
            DataLinqToSQLDataContext products = new DataLinqToSQLDataContext();

            string query = "SELECT Barcode, " + param + " FROM TProductGroup";

            var result = products.ExecuteQuery<TProductGroup>(query);

            return result.ToList();
        }

        // Get primary key to display in a combo box

        public List<int> GetListBarcode()
        {
            DataLinqToSQLDataContext products = new DataLinqToSQLDataContext();

            var query = from barcode in products.TProductGroups
                        select barcode.Barcode;

            return query.ToList();
        }
    }
}
