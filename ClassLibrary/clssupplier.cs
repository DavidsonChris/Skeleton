using System;
using System.Globalization;

namespace ClassLibrary
{
    public class clssupplier
    {
        private int msupplier_id;
        private string mSupplier_Name;
        private DateTime mDateAdded;
        private DateTime mSup_Start_Date;
        private int mavailable;
        private string mphones;
        private string mcontact;
        public bool Active { get; set; }
        public int supplier_id { get { return msupplier_id; } set { msupplier_id = value; } }
        public DateTime DateAdded { get { return mDateAdded; } set { mDateAdded = value; } }
        public string Supplier_Name { get { return mSupplier_Name; } set { mSupplier_Name = value; } }
        public DateTime Sup_Start_Date { get { return mSup_Start_Date; } set { mSup_Start_Date = value; } }
        public int available { get { return mavailable; } set { mavailable = value; } }
        public string Phones_Supplied { get { return mphones; } set { mphones = value; } }
        public string Contact_Number { get { return mcontact; } set { mcontact = value; } }

        public bool find(int Supplier_id)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@supplier_id", Supplier_id);
            DB.Execute("sproc_tblsupplier_filterByID");
            if (DB.Count == 1) {
                msupplier_id = Convert.ToInt32(DB.DataTable.Rows[0]["Supplier_Id"]);
                mSupplier_Name = Convert.ToString(DB.DataTable.Rows[0]["supplier_Name"]);
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

        public string valid(string Supplier_Name, string sup_Start_Date, string available, string phones, string contact)
        {
            string error = "";
            DateTime DateTemp;
            Int64 tempAvailable;
            if (Supplier_Name.Length == 0)
            {
                error = error + "Supplier Name may not be blank : ";
            }
            if (Supplier_Name.Length > 20)
            {
                error = error + "Supplier Name may not be more then 20 characters : ";
            }
            try
            {
                DateTemp = Convert.ToDateTime(sup_Start_Date);
                if (DateTemp < DateTime.Now.Date)
                {
                    error = error + "date cannot be in past : ";
                }
                if (DateTemp > DateTime.Now.Date)
                {
                    error = error + "date cannot be in future : ";
                }
            }
            catch
            {
                error = error + "not a valid date : ";
            }
            try
            {
                tempAvailable = Convert.ToInt64(available);
                if (tempAvailable > 1)
                {
                    error = error + "availibilty cannot be more the 1 : ";
                }
                if (tempAvailable < 0)
                {
                    error = error + "availibilty cannot be less than 0 : ";
                }
            }
            catch
            {
                error = error + "available not valid bit : ";
            }
            if (phones.Length > 200)
            {
                error = error + "phones supplied may not be more then 200 characters : ";
            }
            if (contact.Length > 25)
            {
                error = error + "contact info is more then 25 characters";
            }

            return error;
        }
        
    }
}