using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using InventoryDataLayer;

namespace InventoryBusinessLayer
{
    public class BReturn
    {
        Return returned = new Return();

        public void GetReturned(DataGridView dataView)
        {
            dataView.DataSource = returned.GetReturnList();
        }

        public void NewReturnItem(int barcode, int location, int quantity)
        {
            //NewReturnedItem (int barcode, int location, int quantity)
            returned.NewReturnedItem(barcode, location, quantity);
        }

        //for letting user pick a product to add to return
        public void ProductSelect(ComboBox cbox)
        {
            cbox.DataSource = returned.GetProductList();
        }

        public List<int> GetBarcodeList()
        {
            return returned.GetBarcode();
        }

        public List<int> GetReturnBarcodeList()
        {
            return returned.GetReturnedBarcode();
        }

        public List<int> GetLocationListId()
        {
            return returned.GetLocationListId();
        }

        public void LocationSelect(ComboBox cbox)
        {
            cbox.DataSource = returned.GetLocationList();
        }

        public Boolean checkIfProductInReturn(int id, int location)
        {
            bool has = returned.GetReturn().Any(st => st.BarcodeID == id && st.LocationID == location);
            return has;
        }

        public void GetAllReturns(ComboBox cbox)
        {
            cbox.DataSource = returned.ReturnNames();
        }

        public List<int> ReturnedLocationId()
        {
            return returned.ReturnLocation();
        }

        public List<string> ReturnedLocationName(int id)
        {
            return returned.ReturnedLocationName(id);
        }

        public List<int> ReturnedQuantities()
        {
            return returned.ReturnQuantities();
        }

        public void DeleteReturnedItem(int barcode, int locationid)
        {
            returned.DeleteReturnItem(barcode, locationid);
        }

        public void EditReturnedItem(int barcode, int locationid, int quantity)
        {
            returned.ReturnToEdit(barcode, locationid, quantity);
        }

        
    }
}
