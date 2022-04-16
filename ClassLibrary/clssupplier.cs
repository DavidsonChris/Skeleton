using System;
using System.Globalization;

namespace ClassLibrary
{
    public class clssupplier
    {
        private int msupplier_id;
        private string msup_Name;
        private DateTime mDateAdded;
        private DateTime mSup_Start_Date;
        private int mavailable;
        private string mphones;
        private string mcontact;
        public bool Active { get; set; }
        public int supplier_id { get { return msupplier_id; } set { msupplier_id = value; } }
        public DateTime DateAdded { get { return mDateAdded; } set { mDateAdded = value; } }
        public string sup_Name { get {return msup_Name; } set { msup_Name = value;}}
        public DateTime Sup_Start_Date { get { return mSup_Start_Date; } set { mSup_Start_Date = value; } }
        public int available { get { return mavailable; } set { mavailable = value; } }
        public string phones { get { return mphones; } set { mphones = value; } }
        public string contact { get { return mcontact; } set { mcontact = value; } }

        public bool find(int Supplier_id)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@supplier_id", Supplier_id);
            DB.Execute("sproc_tblsupplier_filterByID");
            if (DB.Count == 1) {
                msupplier_id = Convert.ToInt32(DB.DataTable.Rows[0]["Supplier_Id"]);
                msup_Name = Convert.ToString(DB.DataTable.Rows[0]["supplier_Name"]);
                mSup_Start_Date = Convert.ToDateTime(DB.DataTable.Rows[0]["Supplier_Start_Date"]);
                mavailable = Convert.ToByte(DB.DataTable.Rows[0]["Availibilty"]);
                mphones = Convert.ToString(DB.DataTable.Rows[0]["Phones_Supplied"]);
                mcontact = Convert.ToString(DB.DataTable.Rows[0]["Contact_Number"]);

                return true;
            }
            else
            {
                return false;
            }
        
        }   
    }
}