using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsSupplierCollection
    {
        private List<clssupplier> msupplierList = new List<clssupplier>();
        private clssupplier mThisSupplier = new clssupplier();

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
        public clssupplier ThisSupplier
        {
            get
            {
                return mThisSupplier;
            }
            set
            {
                mThisSupplier = value;
            }
        }
        
        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@supplier_Name",mThisSupplier.Supplier_Name);
            DB.AddParameter("@Supplier_Start_Date",mThisSupplier.DateAdded);
            DB.AddParameter("@Availibilty",mThisSupplier.available);
            DB.AddParameter("@Phones_Supplied",mThisSupplier.Phones_Supplied);
            DB.AddParameter("@Contact_Number",mThisSupplier.Contact_Number);
            return DB.Execute("sproc_tblSupplier_Insert");
        }
        public clsSupplierCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("selectAll");
            populatedArray(DB);
           
        }

        public void update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Supplier_Id", mThisSupplier.supplier_id);
            DB.AddParameter("@supplier_Name", mThisSupplier.Supplier_Name);
            DB.AddParameter("@Supplier_Start_Date", mThisSupplier.DateAdded);
            DB.AddParameter("@Availibilty", mThisSupplier.available);
            DB.AddParameter("@Phones_Supplied", mThisSupplier.Phones_Supplied);
            DB.AddParameter("@Contact_Number", mThisSupplier.Contact_Number);
            DB.Execute("sproc_tblSupplier_Update");
        }

        public void Delete()
        {
            clsDataConnection dataConnection = new clsDataConnection();
            dataConnection.AddParameter("@Supplier_Id", mThisSupplier.supplier_id);
            dataConnection.Execute("sprco_tblSupplier_Delete");
        }
        public void ReportByPhones(string Phones_Supplied)
        {
            clsDataConnection clsDataConnection = new clsDataConnection();
            clsDataConnection.AddParameter("@Phones_Supplied", Phones_Supplied);
            clsDataConnection.Execute("sproc_tblSuppliers_FilterByPhones");
            populatedArray(clsDataConnection);
        }

        void populatedArray(clsDataConnection DB)
        {
            Int32 index = 0;
            Int32 REcordCount;

            REcordCount = DB.Count;
            msupplierList = new List<clssupplier>();
            while (index < REcordCount)
            {
                clssupplier clssupplier = new clssupplier();
                clssupplier.supplier_id = Convert.ToInt32(DB.DataTable.Rows[index]["Supplier_Id"]);
                clssupplier.Supplier_Name = Convert.ToString(DB.DataTable.Rows[index]["supplier_Name"]);
                clssupplier.Sup_Start_Date = Convert.ToDateTime(DB.DataTable.Rows[index]["Supplier_Start_Date"]);
                clssupplier.available = Convert.ToByte(DB.DataTable.Rows[index]["Availibilty"]);
                clssupplier.Phones_Supplied = Convert.ToString(DB.DataTable.Rows[index]["Phones_Supplied"]);
                clssupplier.Contact_Number = Convert.ToString(DB.DataTable.Rows[index]["Contact_Number"]);
                msupplierList.Add(clssupplier);
                index++;

            }
        }
    }
}