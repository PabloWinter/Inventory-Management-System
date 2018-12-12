using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventoryDataLayer;

namespace InventoryBusinessLayer
{
    public class BProduct
    {
        Product product = new Product();

        public void FillDataGridProduct(DataGridView data)
        {
            // Fill Data grid view with products from database
           data.DataSource = product.ShowInventoryProduct();
        }

        public void InsertIntoDatabase(string name, decimal price, decimal tax, decimal discount, string description, int FKcategory, int FKbrand, string fullName, string shortName)
        {
            // Inserting new product
            product.InsertNewProduct(name, price, tax, discount, description, FKcategory, FKbrand, fullName, shortName);
        }

        public void UpdateDatabase(int barcode, string name, decimal price, decimal tax, decimal discount, string description, int pCategoryID, int pBrand, string fullName, string shortName)
        {
            // updating product
            product.UpdateProduct(barcode, name, price, tax, discount, description, pCategoryID, pBrand, fullName, shortName);
        }

        public void FillComboBoxCategory(ComboBox comboCat)
        {
            comboCat.DataSource = product.ShowComboCategory();
            comboCat.DisplayMember = "Name";
        }

        public void FillComboBoxBrand(ComboBox comboBrand)
        {
            comboBrand.DataSource = product.ShowComboBrand();
            comboBrand.DisplayMember = "Name";
        }

        public void FillComboBoxProduct(ComboBox comboProd, string value)
        {
            comboProd.DataSource = product.PopulateComboProduct(value);
            comboProd.DisplayMember = value;
        }

        public void FillTComboBarcode(ComboBox combo, string barcode)
        {
            combo.DataSource = product.PopulateComboBarcode(barcode);
            combo.DisplayMember = barcode;
        }

        public List<int> GetBarcodeList()
        {
            return product.GetListBarcode();
        }
    }
}
