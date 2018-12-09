using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryDataLayer
{
    public class Brand
    {
        public object ShowBrands()
        {
            DataLinqToSQLDataContext brands = new DataLinqToSQLDataContext();

            var result = from brand in brands.TBrands
                         select new
                         {
                             brand.BrandID,
                             brand.Name
                         };

            return result.ToList();
        }

        public void InsertNewBrand(string brandName)
        {
            using (DataLinqToSQLDataContext brands = new DataLinqToSQLDataContext())
            {
                TBrand newBrand = new TBrand
                {
                    Name = brandName
                };

                brands.TBrands.InsertOnSubmit(newBrand);
                brands.SubmitChanges();
            }
        }

        public void UpdateBrand(int brandId, string name)
        {
            // Updating product information

            using (DataLinqToSQLDataContext brands = new DataLinqToSQLDataContext())
            {
                TBrand editBrand = brands.TBrands.SingleOrDefault(x => x.BrandID == brandId);

                editBrand.Name = name;

                brands.SubmitChanges();
            }
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

        public List<int> GetBrandId()
        {
            DataLinqToSQLDataContext brand = new DataLinqToSQLDataContext();

            var query = from brandId in brand.TBrands
                        select brandId.BrandID;

            return query.ToList();
        }
    }
}