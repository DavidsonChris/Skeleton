using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsSupplierCollection
    {
        public clsSupplierCollection()
        {
            Int32 index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("selectAll");
            RecordCount = DB.Count;
            while (index < RecordCount)
            {
                clssupplier clssupplier = new clssupplier();

                clssupplier.supplier_id = Convert.ToInt32(DB.DataTable.Rows[0]["Supplier_Id"]);
                clssupplier.sup_Name = Convert.ToString(DB.DataTable.Rows[0]["supplier_Name"]);
                clssupplier.Sup_Start_Date = Convert.ToDateTime(DB.DataTable.Rows[0]["Supplier_Start_Date"]);
                clssupplier.available = Convert.ToByte(DB.DataTable.Rows[0]["Availibilty"]);
                clssupplier.Phones_Supplied = Convert.ToString(DB.DataTable.Rows[0]["Phones_Supplied"]);
                clssupplier.Contact_Number = Convert.ToString(DB.DataTable.Rows[0]["Contact_Number"]);
                msupplierList.Add(clssupplier);
                index++;
            }
        }
        private List<clssupplier> msupplierList = new List<clssupplier>();
        public List<clssupplier> supplierList 
        {
            get 
            {
                return msupplierList;
            }
            set 
            {
                msupplierList = value;
            }
        }
        public int Count 
        { 
            get 
            {
                return msupplierList.Count;
            } 
            set 
            { 
                //
            } 
        }
        public clssupplier ThisSupplier { get; set; }
    }
}