using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

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
    }
}
