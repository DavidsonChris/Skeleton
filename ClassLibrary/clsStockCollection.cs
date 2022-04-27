using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStockCollection
    {
        List<clsStock> mStockList = new List<clsStock>();

        public List<clsStock> StockList
        {
            get
            {
                return mStockList;
            }
            set
            {
                mStockList = value;
            }
        }

        public int Count
        {
            get
            {
                return mStockList.Count;
            }
            set
            {

            }
        }
        public clsStock ThisStock { get; set; }

        public clsStockCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblStock_SelectAll");
            RecordCount = DB.Count;
            while (Index < RecordCount)
            {
                clsStock AnStock = new clsStock();
                AnStock.Availability = Convert.ToBoolean(DB.DataTable.Rows[Index]["Availability"]);
                AnStock.phoneID = Convert.ToInt32(DB.DataTable.Rows[Index]["phoneID"]);
                AnStock.phoneName = Convert.ToString(DB.DataTable.Rows[Index]["phoneName"]);
                AnStock.Price = Convert.ToInt32(DB.DataTable.Rows[Index]["Price"]);
                AnStock.releaseDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["releaseDate"]);
                AnStock.phoneColour = Convert.ToString(DB.DataTable.Rows[Index]["phoneColour"]);
                mStockList.Add(AnStock);
                Index++;
            }

        }
    }
}