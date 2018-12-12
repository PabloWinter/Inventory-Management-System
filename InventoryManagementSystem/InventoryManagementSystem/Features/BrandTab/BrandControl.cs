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

namespace InventoryManagementSystem.Features.BrandTab
{
    public partial class BrandControl : UserControl
    {
        BBrand brand = new BBrand();

        public BrandControl()
        {
            InitializeComponent();

            brand.FillDataGridBrand(ViewDataList);
        }

        private void InsertBrand_Click_1(object sender, EventArgs e)
        {
            InsertBrandForm brandInsert = new InsertBrandForm();
            brandInsert.Show();
        }

        private void UpdateBrand_Click_1(object sender, EventArgs e)
        {
            UpdateBrandForm updateBrandForm = new UpdateBrandForm();
            updateBrandForm.Show();
        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            brand.FillDataGridBrand(ViewDataList);
        }
    }
}