using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class supplier
    {
        [TestMethod]
        public void TestMethod1()
        {
            //create a new class 
            clssupplier ASupplier = new clssupplier { };
            //test to see if it is a supplier 
            Assert.IsNotNull(ASupplier);
        }
        [TestMethod]
        public void TestMethod2 ()
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
            Asup.phones = testdata;
            Assert.AreEqual(Asup.phones, testdata);
        }
        [TestMethod] 
        public void test_contact ()
        {
            clssupplier asup = new clssupplier { };
            string testdata = "012";
            asup.contact = testdata;
            Assert.AreEqual(asup.contact, testdata);
        }
        [TestMethod]
        public void findMethodOK()
        {
            clssupplier asup = new clssupplier();
            Boolean Found = false;
            string supplier_Name = "asdf";
            Found = asup.find(supplier_Name);
            Assert.IsTrue(Found);

        }
        [TestMethod]
        public void TestSup_Name()
        {
            clssupplier asup = new clssupplier();
            Boolean Found =false;
            Boolean OK = true;
            string supplier_Name = "asdf";
            Found = asup.find(supplier_Name);
            if (asup.sup_Name != "asdf")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestSup_Start_Date()
        {
            clssupplier asup = new clssupplier();
            Boolean Found = false;
            Boolean OK = true;
            string supplier_Name = "asdf";
            Found = asup.find(supplier_Name);
            if (asup.Sup_Start_Date != Convert.ToDateTime("01/01/2018"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestAvailabilty()
        {
            clssupplier asup = new clssupplier();
            Boolean Found = false;
            Boolean OK = true;
            string supplier_Name = "asdf";
            Found = asup.find(supplier_Name);
            if (asup.available != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void Testphones()
        {
            clssupplier asup = new clssupplier();
            Boolean Found = false;
            Boolean OK = true;
            string supplier_Name = "asdf";
            Found = asup.find(supplier_Name);
            if (asup.phones != "a52")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void Testcontact()
        {
            clssupplier asup = new clssupplier();
            Boolean Found = false;
            Boolean OK = true;
            string supplier_Name = "asdf";
            Found = asup.find(supplier_Name);
            if (asup.contact != "example@gmail.com")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

    }
}
