using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        private int mStaff_id;
        private string mStaff_fullname;
        private string mStaff_department;
        private string mEmail_address;
        private DateTime mStaff_DOB;
        private bool mAvailability;

        public bool Availability
        {
            get
            {
                //this line of code sends data out of the property
                return mAvailability;
            }
            set
            {
                //this line of code allows data into the property
                mAvailability = value;
            }
        }
        public DateTime Staff_DOB
        {
            get
            {
                //this line of code sends data out of the property
                return mStaff_DOB;
            }
            set
            {
                //this line of code allows data into the property
                mStaff_DOB = value;
            }
        }

        //staff_id private member variable 
        //Staff_id public property
        public int Staff_id
        {
            get
            {
                //this line of code sends data out of the property
                return mStaff_id;
            }
            set
            {
                //this line of code allows data into the property
                mStaff_id = value;
            }
        }
        public string Staff_fullname
        {
            get
            {
                //this line of code sends data out of the property
                return mStaff_fullname;
            }
            set
            {
                //this line of code allows data into the property
                mStaff_fullname = value;
            }
        }

        public string Staff_department
        {
            get
            {
                //this line of code sends data out of the property
                return mStaff_department;
            }
            set
            {
                //this line of code allows data into the property
                mStaff_department = value;
            }
        }
        public string Email_Address
        {
            get
            {
                //this line of code sends data out of the property
                return mEmail_address;
            }
            set
            {
                //this line of code allows data into the property
                mEmail_address = value;
            }
        }

        public bool Find(int Staff_id)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the staff id to search for
            DB.AddParameter("@Staff_id", Staff_id);
            //execute the store procedure
            DB.Execute("sproc_tblStaff_FilterByStaff_id");
            // if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {

                //copy the data from the database to the private data members
                mStaff_id = Convert.ToInt32(DB.DataTable.Rows[0]["Staff_id"]);
                mStaff_fullname = Convert.ToString(DB.DataTable.Rows[0]["Staff_fullname"]);
                mStaff_department = Convert.ToString(DB.DataTable.Rows[0]["Staff_department"]);
                mEmail_address = Convert.ToString(DB.DataTable.Rows[0]["Email_address"]);
                mStaff_DOB = Convert.ToDateTime(DB.DataTable.Rows[0]["Staff_DOB"]);
                mAvailability = Convert.ToBoolean(DB.DataTable.Rows[0]["Availability"]);
                //return that everything work OK
                return true;
            }
            else
            {
                //return false indicating a problem
                return false;

            }
        }
    }
    }