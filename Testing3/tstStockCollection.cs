using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing3
{
    [TestClass]
    public class tstStockCollection
    {
      
        [TestMethod]
        public void InstanceOK()
        {
            clsStockCollection AllStocks = new clsStockCollection();
            Assert.IsNotNull(AllStocks);
        }

        [TestMethod]
        public void StockListOK()
        {
            clsStockCollection AllStocks = new clsStockCollection();
            List<clsStock> TestList = new List<clsStock>();
            clsStock TestItem = new clsStock();
            TestItem.phoneID = 1;
            TestItem.phoneName = "iPhone 13 mini";
            TestItem.Price = 679;
            TestItem.Availability = true;
            TestItem.phoneColour = "Green";
            TestItem.releaseDate = DateTime.Now.Date;
            TestList.Add(TestItem);
            AllStocks.StockList = TestList;
            Assert.AreEqual(AllStocks.StockList, TestList);
        }
   
        [TestMethod]
        public void ThisStockOK()
        {
            clsStockCollection AllStocks = new clsStockCollection();
            clsStock TestStock = new clsStock();
            TestStock.Availability = true;
            TestStock.phoneID = 1;
            TestStock.phoneName = "iPhone 13 mini";
            TestStock.Price = 679;
            TestStock.releaseDate = DateTime.Now.Date;
            TestStock.phoneColour = "Green";
            AllStocks.ThisStock = TestStock;
            Assert.AreEqual(AllStocks.ThisStock, TestStock);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsStockCollection AllStocks = new clsStockCollection();
            List<clsStock> TestList = new List<clsStock>();
            clsStock TestItem = new clsStock();
            TestItem.Availability = true;
            TestItem.phoneID = 1;
            TestItem.phoneName = "iPhone 13 mini";
            TestItem.Price = 679;
            TestItem.releaseDate = DateTime.Now.Date;
            TestItem.phoneColour = "Green";
            TestList.Add(TestItem);
            AllStocks.StockList = TestList;
            Assert.AreEqual(AllStocks.Count, TestList.Count);
        }


      
    }
        
}
