using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class supplier
    {
        string sup_Name = "asd";
        string Sup_Start_Date = DateTime.Now.Date.ToString();
        string available = "1";
        string phones = "asf";
        string contact = "@gmail";

        [TestMethod]
        public void TestMethod1()
        {
            //create a new class 
            clssupplier ASupplier = new clssupplier { };
            //test to see if it is a supplier 
            Assert.IsNotNull(ASupplier);
        }
        [TestMethod]
        public void TestMethod2()
        {
            clssupplier ASupplier = new clssupplier { };
            Boolean testData = true;
            ASupplier.Active = testData;
            Assert.AreEqual(ASupplier.Active, testData);
        }
        [TestMethod]
        public void testdate()
        {
            clssupplier ASupplier = new clssupplier { };
            DateTime TestData = DateTime.Now.Date;
            ASupplier.DateAdded = TestData;
            Assert.AreEqual(ASupplier.DateAdded, TestData);
        }
        [TestMethod]
        public void testSup_Name()
        {
            clssupplier ASupplier = new clssupplier { };
            string testData = "company";
            ASupplier.sup_Name = "company";
            Assert.AreEqual(ASupplier.sup_Name, testData);
        }
        [TestMethod]
        public void test_Sup_Start_Date()
        {
            clssupplier Asupplier = new clssupplier { };
            DateTime testData = DateTime.Now.Date;
            Asupplier.Sup_Start_Date = testData;
            Assert.AreEqual(Asupplier.Sup_Start_Date, testData);

        }
        [TestMethod]
        public void test_available()
        {
            clssupplier Asupplier = new clssupplier { };
            int testData = 0;
            Asupplier.available = testData;
            Assert.AreEqual(Asupplier.available, testData);
        }
        [TestMethod]
        public void test_phones_sup()
        {
            clssupplier Asup = new clssupplier { };
            string testdata = "a52";
            Asup.Phones_Supplied = testdata;
            Assert.AreEqual(Asup.Phones_Supplied, testdata);
        }
        [TestMethod]
        public void test_contact()
        {
            clssupplier asup = new clssupplier { };
            string testdata = "012";
            asup.Contact_Number = testdata;
            Assert.AreEqual(asup.Contact_Number, testdata);
        }
        [TestMethod]
        public void findMethodOK()
        {
            clssupplier asup = new clssupplier();
            Boolean Found = false;
            int supplier_id = 1;
            Found = asup.find(supplier_id);
            Assert.IsTrue(Found);

        }
        [TestMethod]
        public void TestSup_Name_find()
        {
            clssupplier asup = new clssupplier();
            Boolean Found = false;
            Boolean OK = true;
            int supplier_id = 1;
            Found = asup.find(supplier_id);
            if (asup.sup_Name != "connor")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestSup_Start_Date_find()
        {
            clssupplier asup = new clssupplier();
            Boolean Found = false;
            Boolean OK = true;
            int supplier_id = 1;
            Found = asup.find(supplier_id);
            Console.WriteLine(Convert.ToDateTime("15/10/2022"));
            Console.WriteLine(asup.Sup_Start_Date);
            if (asup.Sup_Start_Date != Convert.ToDateTime("15/10/2022"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestAvailabilty_find()
        {
            clssupplier asup = new clssupplier();
            Boolean Found = false;
            Boolean OK = true;
            int supplier_id = 1;
            Found = asup.find(supplier_id);
            if (asup.available != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void Testphones_find()
        {
            clssupplier asup = new clssupplier();
            Boolean Found = false;
            Boolean OK = true;
            int supplier_id = 1;
            Found = asup.find(supplier_id);
            if (asup.Phones_Supplied != "asd")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void Testcontact_find()
        {
            clssupplier asup = new clssupplier();
            Boolean Found = false;
            Boolean OK = true;
            int supplier_id = 1;
            Found = asup.find(supplier_id);
            if (asup.Contact_Number != "123")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ValidMethodOK()
        {
            clssupplier clssupplier = new clssupplier();
            string error = "";
            error = clssupplier.valid(sup_Name, Sup_Start_Date, available, phones, contact);
            Assert.AreEqual(error, "");
        }
        [TestMethod]
        public void supNameMinLessOne()
        {
            clssupplier clssupplier = new clssupplier();
            string error = "";
            string sup_Name = "";
            error = clssupplier.valid(sup_Name, Sup_Start_Date, available, phones, contact);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void supNameMin()
        {
            clssupplier clssupplier = new clssupplier();
            string error = "";
            string sup_Name = "a";
            error = clssupplier.valid(sup_Name, Sup_Start_Date, available, phones, contact);
            Assert.AreEqual(error, "");
        }
        [TestMethod]
        public void supNameMaxPlusOne()
        {
            clssupplier clssupplier = new clssupplier();
            string error = "";
            string sup_Name = "123456789012345678901";
            error = clssupplier.valid(sup_Name, Sup_Start_Date, available, phones, contact);
            Assert.AreNotEqual(error, "");
        }
        [TestMethod]
        public void supNameExtream()
        {
            clssupplier clssupplier = new clssupplier();
            string error = "";
            string sup_Name = "";
            sup_Name = sup_Name.PadRight(500, 'a');
            error = clssupplier.valid(sup_Name, Sup_Start_Date, available, phones, contact);
            Assert.AreNotEqual(error, "");
        }
        [TestMethod]
        public void supDateExtreamMin()
        {
            clssupplier clssupplier = new clssupplier();
            string error = "";
            DateTime testDate;
            testDate = DateTime.Now.Date;
            testDate = testDate.AddYears(-100);
            string Sup_Start_Date = testDate.ToString();
            error = clssupplier.valid(sup_Name, Sup_Start_Date, available, phones, contact);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void supDateMinusOne()
        {
            clssupplier clssupplier = new clssupplier();
            string error = "";
            DateTime testDate;
            testDate = DateTime.Now.Date;
            testDate = testDate.AddDays(-1);
            string Sup_Start_Date = testDate.ToString();
            error = clssupplier.valid(sup_Name, Sup_Start_Date, available, phones, contact);
            Assert.AreNotEqual(error, "");
        }
        [TestMethod]
        public void supDateExtreamMax()
        {
            clssupplier clssupplier = new clssupplier();
            string error = "";
            DateTime testDate;
            testDate = DateTime.Now.Date;
            testDate = testDate.AddYears(100);
            string Sup_Start_Date = testDate.ToString();
            error = clssupplier.valid(sup_Name, Sup_Start_Date, available, phones, contact);
            Assert.AreNotEqual(error, "");
        }
        [TestMethod]
        public void supDateAddOne()
        {
            clssupplier clssupplier = new clssupplier();
            string error = "";
            DateTime testDate;
            testDate = DateTime.Now.Date;
            testDate = testDate.AddDays(1);
            string Sup_Start_Date = testDate.ToString();
            error = clssupplier.valid(sup_Name, Sup_Start_Date, available, phones, contact);
            Assert.AreNotEqual(error, "");
        }
        [TestMethod]
        public void supDateNotValid()
        {
            clssupplier clssupplier = new clssupplier();
            string error = "";
            Sup_Start_Date = "asudig asd";
            error = clssupplier.valid(sup_Name, Sup_Start_Date, available, phones, contact);
            Assert.AreNotEqual(error, "");
        }
        [TestMethod]
        public void supAvailibiltyMax()
        {
            clssupplier clssupplier = new clssupplier();
            string error = "";
            string available = "1";
            error = clssupplier.valid(sup_Name, Sup_Start_Date, available, phones, contact);
            Assert.AreEqual(error, "");
        }
        [TestMethod]
        public void supAvailibiltyMin()
        {
            clssupplier clssupplier = new clssupplier();
            string error = "";
            string available = "0";
            error = clssupplier.valid(sup_Name, Sup_Start_Date, available, phones, contact);
            Assert.AreEqual(error, "");
        }
        [TestMethod]
        public void supAvailibiltyMaxPlusOne()
        {
            clssupplier clssupplier = new clssupplier();
            string error = "";
            string available = "2";
            error = clssupplier.valid(sup_Name, Sup_Start_Date, available, phones, contact);
            Assert.AreNotEqual(error, "");
        }
        [TestMethod]
        public void supAvailibiltyMinMinusOne()
        {
            clssupplier clssupplier = new clssupplier();
            string error = "";
            string available = "-1";
            error = clssupplier.valid(sup_Name, Sup_Start_Date, available, phones, contact);
            Assert.AreNotEqual(error, "");
        }
        [TestMethod]
        public void supPhonesMax()
        {
            clssupplier clssupplier = new clssupplier();
            string error = "";
            string phones = "";
            phones = phones.PadRight(201, 'a');
            error = clssupplier.valid(sup_Name, Sup_Start_Date, available, phones, contact);
            Assert.AreNotEqual(error, "");
        }
        [TestMethod]
        public void supContactNumMax()
        {
            clssupplier clssupplier = new clssupplier();
            string error = "";
            string contact = "";
            contact = contact.PadRight(25, 'a');
            error = clssupplier.valid(sup_Name, Sup_Start_Date, available, phones, contact);
            Assert.AreEqual(error, "");
        }
    }
}
