using System;

namespace ClassLibrary
{
    public class clssupplier
    {
        private string msup_Name;
        private DateTime mDateAdded;
        private DateTime mSup_Start_Date;
        private int mavailable;
        private string mphones;
        private string mcontact;
        public bool Active { get; set; }
        public DateTime DateAdded { get { return mDateAdded; } set { mDateAdded = value; } }
        public string sup_Name
        {
            get
            { return msup_Name;}
            set 
            { msup_Name = value;}
        }
        public DateTime Sup_Start_Date { get { return mSup_Start_Date; } set { mSup_Start_Date = value; } }
        public int available { get { return mavailable; } set { mavailable = value; } }
        public string phones { get { return mphones; } set { mphones = value; } }
        public string contact { get { return mcontact; } set { mcontact = value; } }

        public bool find(string supplier_Name)
        {
            msup_Name = "asdf";
            mSup_Start_Date = Convert.ToDateTime("01/01/2018");
            mavailable = 1;
            mphones = "a52";
            mcontact = "example@gmail.com";
            return true;
        }
    }
}