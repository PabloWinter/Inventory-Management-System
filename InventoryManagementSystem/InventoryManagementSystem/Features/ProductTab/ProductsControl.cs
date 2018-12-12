using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventoryBusinessLayer;

namespace InventoryManagementSystem.Features.ProductTab
{
    public partial class ProductsControl : UserControl
    {
        BProduct product = new BProduct();

        public ProductsControl()
        {
            InitializeComponent();

            product.FillDataGridProduct(ViewDataList);
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            InsertProductForm newProductForm = new InsertProductForm();
            newProductForm.Show();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            UpdateProductForm newUpdateForm = new UpdateProductForm();
            newUpdateForm.Show();
        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            product.FillDataGridProduct(ViewDataList);
        }
    }
}
