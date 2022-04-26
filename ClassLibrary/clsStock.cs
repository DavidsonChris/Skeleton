using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;



namespace ClassLibrary
{

    public class clsStock
    {
        private Int32 mphoneID;
        public int phoneID
        {
            get
            {
                return mphoneID;
            }
            set
            {
                mphoneID = value;
            }
        }

        private string mphoneName;
        public string phoneName
        {
            get
            {
                return mphoneName;
            }

            set
            {
                mphoneName = value;
            }

        }

        private int mPrice;
        public int Price
        {
            get
            {
                return mPrice;
            }

            set
            {
                mPrice = value;
            }
        }

        private DateTime mreleaseDate;
        public DateTime releaseDate
        {
            get
            {
                return mreleaseDate;
            }
            set
            {
                mreleaseDate = value;
            }
        }

        private Boolean mAvailability;
        public bool Availability
        {
            get
            {
                return mAvailability;
            }

            set
            {
                mAvailability = value;
            }

        }

        private string mphoneColour;
        public string phoneColour
        {
            get
            {
                return mphoneColour;
            }

            set
            {
                mphoneColour = value;
            }

        }

        public bool Find(int phoneID)
        {

            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@phoneID", phoneID);
            DB.Execute("sproc_tblStock_FilterByphoneID");
            if (DB.Count == 1)
            {
                mphoneID = Convert.ToInt32(DB.DataTable.Rows[0]["phoneID"]);
                mreleaseDate = Convert.ToDateTime(DB.DataTable.Rows[0]["releaseDate"]);
                mphoneName = Convert.ToString(DB.DataTable.Rows[0]["phoneName"]);
                mPrice = Convert.ToInt32(DB.DataTable.Rows[0]["Price"]);
                mAvailability = Convert.ToBoolean(DB.DataTable.Rows[0]["Availability"]);
                mphoneColour = Convert.ToString(DB.DataTable.Rows[0]["phoneColour"]);
                return true;
            }
            else
            {
                return false;
            }

        }

        public string Valid(string PhoneName, string PhoneColour, string ReleaseDate)
        {
            string Error = "";
            DateTime DateTemp;

            if (PhoneName.Length == 0)
            {
                Error = Error + "The phone name must not be blank : ";
            }

            if (PhoneName.Length > 50)
            {
                Error = Error + "The phone name must be less than 50 characters : ";
            }
            try
            {

                DateTemp = Convert.ToDateTime(ReleaseDate);
                if (DateTemp < DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the past : ";
                }
                if (DateTemp > DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the future : ";
                }
            }

            catch
            {
                Error = Error + "The date was not valid date : ";
            }

            if (PhoneColour.Length == 0)
            {
                Error = Error + "The phone colour must not be blank :";
            }

            if (PhoneColour.Length > 20)
            {
                Error = Error + "The phone colour must be less than 20 characters :";

            }

            return Error;

        }
    }
}



