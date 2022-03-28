using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace Testing1
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void InstanceOK()
        {
            // Create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //test to see that it exists
            Assert.IsNotNull(AnStaff);
        }
        [TestMethod]
        public void AvailabilityPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnStaff.Availability = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.Availability, TestData);
        }
        [TestMethod]
        public void Staff_DOBPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnStaff.Staff_DOB = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.Staff_DOB, TestData);
        }
        [TestMethod]
        public void Staff_idPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnStaff.Staff_id = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.Staff_id, TestData);
        }
        [TestMethod]
        public void Staff_fullnamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "21b";
            //assign the data to the property
            AnStaff.Staff_fullname = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.Staff_fullname, TestData);
        }
        [TestMethod]
        public void Staff_departmentPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "21b";
            //assign the data to the property
            AnStaff.Staff_department = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.Staff_department, TestData);
        }
        [TestMethod]
        public void Email_AddressPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "21b";
            //assign the data to the property
            AnStaff.Email_Address = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.Email_Address, TestData);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 Staff_id = 1;
            //invoke the method
            Found = AnStaff.Find(Staff_id);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestStaff_idFound()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Staff_id = 1;
            //invoke the method
            Found = AnStaff.Find(Staff_id);
            //check the address no
            if (AnStaff.Staff_id != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSatff_fullnameFound()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Staff_id = 1;
            //invoke the method
            Found = AnStaff.Find(Staff_id);
            //check the property
            if (AnStaff.Staff_fullname != "Ben John")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaff_departmentFound()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Staff_id = 1;
            //invoke the method
            Found = AnStaff.Find(Staff_id);
            //check the property
            if (AnStaff.Staff_department != "Marketing")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestEmail_addressFound()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Staff_id = 1;
            //invoke the method
            Found = AnStaff.Find(Staff_id);
            //check the property
            if (AnStaff.Email_Address != "bjon@gmail.com")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaff_DOBFound()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Staff_id = 1;
            //invoke the method
            Found = AnStaff.Find(Staff_id);
            //check the property
            if (AnStaff.Staff_DOB != Convert.ToDateTime("25/10/2000"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAvailabilityFound()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Staff_id = 1;
            //invoke the method
            Found = AnStaff.Find(Staff_id);
            //check the property
            if (AnStaff.Availability != Convert.ToBoolean("True"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
    }
}

  
