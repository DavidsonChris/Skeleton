using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstStock
    {
        string PhoneName = "Samsung Galaxy S22 Ultra";
        string PhoneColour = "Burgundy";
        string ReleaseDate = DateTime.Now.Date.ToString();
    
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
            Error = AnStock.Valid(PhoneName,PhoneColour,ReleaseDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNameMinLessOne()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            string PhoneName = "";
            Error = AnStock.Valid(PhoneName, PhoneColour, ReleaseDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNameMin()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            string PhoneName = "a"; 
            Error = AnStock.Valid(PhoneName, PhoneColour, ReleaseDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNameMinPlusOne()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            string PhoneName = "aa"; 
            Error = AnStock.Valid(PhoneName, PhoneColour, ReleaseDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNameMaxLessOne()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            string PhoneName = "";
            PhoneName = PhoneName.PadRight(49, 'a');
            Error = AnStock.Valid(PhoneName, PhoneColour, ReleaseDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNameMax()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            string PhoneName = "";
            PhoneName = PhoneName.PadRight(50, 'a');
            Error = AnStock.Valid(PhoneName,PhoneColour,ReleaseDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNameMaxPlusOne()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            string PhoneName = "";
            Error = AnStock.Valid(PhoneName,PhoneColour,ReleaseDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNameMid()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            string PhoneName = "";
            PhoneName = PhoneName.PadRight(25, 'a');
            Error = AnStock.Valid(PhoneName,PhoneColour,ReleaseDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ReleaseDateExtremeMin()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string ReleaseDate = TestDate.ToString();
            Error = AnStock.Valid(PhoneName, PhoneColour, ReleaseDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ReleaseDateMinLessOne()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            string ReleaseDate = TestDate.ToString();
            Error = AnStock.Valid(PhoneName, PhoneColour, ReleaseDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ReleaseDateMinPlusOne()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            string ReleaseDate = TestDate.ToString();
            Error = AnStock.Valid(PhoneName, PhoneColour, ReleaseDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ReleaseDateExtremeMax()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string ReleaseDate = TestDate.ToString();
            Error = AnStock.Valid(PhoneName, PhoneColour, ReleaseDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ReleaseDateInvalidData()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            string ReleaseDate = "This is not a date!";
            Error = AnStock.Valid(PhoneName, PhoneColour, ReleaseDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneColourLessOne()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            string PhoneColour = "";
            Error = AnStock.Valid(PhoneName,PhoneColour,ReleaseDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneColourMin()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            string PhoneColour = "a";
            Error = AnStock.Valid(PhoneName,PhoneColour,ReleaseDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneColourMinPlusOne()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            string PhoneColour = "aa";
            Error = AnStock.Valid(PhoneName,PhoneColour,ReleaseDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneColourMaxLessOne()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            string PhoneColour = "";
            PhoneColour = PhoneColour.PadRight(19, 'a');
            Error = AnStock.Valid(PhoneName,PhoneColour,ReleaseDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneColourMax()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            string PhoneColour = "";
            PhoneColour = PhoneColour.PadRight(20, 'a');
            Error = AnStock.Valid(PhoneName,PhoneColour,ReleaseDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneColourMaxPlusOne()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            string PhoneColour = "";
            Error = AnStock.Valid(PhoneName,PhoneColour,ReleaseDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneColourMid()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            string PhoneColour = "aaaaaaaaaa";
            Error = AnStock.Valid(PhoneName,PhoneColour,ReleaseDate);
            Assert.AreEqual(Error, "");
        }

    }
}
