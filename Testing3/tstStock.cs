using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstStock
    {
        string phoneName = "Samsung Galaxy S22 Ultra";
        string phoneColour = "Burgundy";
        string releaseDate = DateTime.Now.Date.ToString();
    
        [TestMethod]
        public void InstanceOK()
        {
            clsStock AnStock = new clsStock();
            Assert.IsNotNull(AnStock);
        }

        [TestMethod]
        public void phoneIDOK()

        {
            clsStock AnStock = new clsStock();

            Int32 TestData = 1;

            AnStock.phoneID = TestData;

            Assert.AreEqual(AnStock.phoneID, TestData);
        }

        [TestMethod]
        public void phoneNameOK()

        {
            clsStock AnStock = new clsStock();

            string TestData = "iPhone 13 Pro";

            AnStock.phoneName = TestData;

            Assert.AreEqual(AnStock.phoneName, TestData);
        }

        [TestMethod]
        public void PriceOk()
        {
            clsStock AnStock = new clsStock();

            Int32 TestData = 949;

            AnStock.Price = TestData;

            Assert.AreEqual(AnStock.Price, TestData);
        }

        [TestMethod]
        public void releaseDateOK()
        {
            clsStock AnStock = new clsStock();

            DateTime TestData = DateTime.Now.Date;

            AnStock.releaseDate = TestData;

            Assert.AreEqual(AnStock.releaseDate, TestData);
        }

        [TestMethod]
        public void AvailabilityOK()
        {
            clsStock AnStock = new clsStock();

            Boolean TestData = true;

            AnStock.Availability = TestData;

            Assert.AreEqual(AnStock.Availability, TestData);
        }

        [TestMethod]
        public void phoneColourOK()
        {
            clsStock AnStock = new clsStock();

            string TestData = "Black";

            AnStock.phoneColour = TestData;

            Assert.AreEqual(AnStock.phoneColour, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsStock AnStock = new clsStock();
            Boolean Found = false;
            Int32 phoneID = 1;
            Found = AnStock.Find(phoneID);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestphoneIDFound()
        {
            clsStock AnStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 phoneID = 7;
            Found = AnStock.Find(phoneID);
            if (AnStock.phoneID != 7)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestreleaseDateFound()
        {
            clsStock AnStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 phoneID = 7;
            Found = AnStock.Find(phoneID);
            if (AnStock.releaseDate != Convert.ToDateTime("24/09/2021"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestphoneNameFound()
        {
            clsStock AnStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 phoneID = 7;
            Found = AnStock.Find(phoneID);
            if (AnStock.phoneName != "iPhone 13 Pro")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPrice()
        {
            clsStock AnStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 phoneID = 7;
            Found = AnStock.Find(phoneID);
            if (AnStock.Price != 949)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAvailability()
        {
            clsStock AnStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 phoneID = 7;
            Found = AnStock.Find(phoneID);
            if (AnStock.Availability != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestphoneColour()
        {
            clsStock AnStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 phoneID = 7;
            Found = AnStock.Find(phoneID);
            if (AnStock.phoneColour != "Graphite")
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void ValidMethodOK()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            Error = AnStock.Valid(phoneName,phoneColour,releaseDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void phoneNameMinLessOne()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            string phoneName = "";
            Error = AnStock.Valid(phoneName, phoneColour, releaseDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void phoneNameMin()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            string phoneName = "a"; 
            Error = AnStock.Valid(phoneName, phoneColour, releaseDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void phoneNameMinPlusOne()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            string phoneName = "aa"; 
            Error = AnStock.Valid(phoneName, phoneColour, releaseDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void phoneNameMaxLessOne()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            string phoneName = "";
            phoneName = phoneName.PadRight(49, 'a');
            Error = AnStock.Valid(phoneName, phoneColour, releaseDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void phoneNameMax()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            string phoneName = "";
            phoneName = phoneName.PadRight(50, 'a');
            Error = AnStock.Valid(phoneName,phoneColour,releaseDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void phoneNameMaxPlusOne()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            string phoneName = "";
            Error = AnStock.Valid(phoneName,phoneColour,releaseDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void phoneNameMid()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            string phoneName = "";
            phoneName = phoneName.PadRight(25, 'a');
            Error = AnStock.Valid(phoneName,phoneColour,releaseDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void releaseDateExtremeMin()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string releaseDate = TestDate.ToString();
            Error = AnStock.Valid(phoneName, phoneColour, releaseDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void releaseDateMinLessOne()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            string releaseDate = TestDate.ToString();
            Error = AnStock.Valid(phoneName, phoneColour, releaseDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void releaseDateMinPlusOne()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            string releaseDate = TestDate.ToString();
            Error = AnStock.Valid(phoneName, phoneColour, releaseDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void releaseDateExtremeMax()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string releaseDate = TestDate.ToString();
            Error = AnStock.Valid(phoneName, phoneColour, releaseDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void releaseDateInvalidData()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            string releaseDate = "This is not a date!";
            Error = AnStock.Valid(phoneName, phoneColour, releaseDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void phoneColourLessOne()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            string phoneColour = "";
            Error = AnStock.Valid(phoneName,phoneColour,releaseDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void phoneColourMin()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            string phoneColour = "a";
            Error = AnStock.Valid(phoneName,phoneColour,releaseDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void phoneColourMinPlusOne()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            string phoneColour = "aa";
            Error = AnStock.Valid(phoneName,phoneColour,releaseDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void phoneColourMaxLessOne()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            string phoneColour = "";
            phoneColour = phoneColour.PadRight(19, 'a');
            Error = AnStock.Valid(phoneName,phoneColour,releaseDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void phoneColourMax()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            string phoneColour = "";
            phoneColour = phoneColour.PadRight(20, 'a');
            Error = AnStock.Valid(phoneName,phoneColour,releaseDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void phoneColourMaxPlusOne()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            string phoneColour = "";
            Error = AnStock.Valid(phoneName,phoneColour,releaseDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void phoneColourMid()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            string phoneColour = "aaaaaaaaaa";
            Error = AnStock.Valid(phoneName,phoneColour,releaseDate);
            Assert.AreEqual(Error, "");
        }

    }
}
