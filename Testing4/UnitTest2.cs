using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing4
{
    [TestClass]
    public class testSupplierCollection
    {
        [TestMethod]
        public void instanceOk()
        {
            clsSupplierCollection AllSupplier = new clsSupplierCollection();
            Assert.IsNotNull(AllSupplier);

        }
        [TestMethod]
        public void SupplierListOk()
        {
            clsSupplierCollection clsSupplierCollection = new clsSupplierCollection();
            List<clssupplier> listsup = new List<clssupplier>();
            clssupplier clssupplier = new clssupplier();
            clssupplier.Active = true;
            clssupplier.supplier_id = 1;
            clssupplier.Supplier_Name = "qwe";
            clssupplier.DateAdded = DateTime.Now.Date;
            clssupplier.available = 1;
            clssupplier.Phones_Supplied = "sadf";
            clssupplier.Contact_Number = "0121";
            listsup.Add(clssupplier);
            clsSupplierCollection.supplierList = listsup;
            Assert.AreEqual(clsSupplierCollection.supplierList, listsup);
        }
        
        [TestMethod]
        public void ThisSupplierProppertyOk()
        {
            clsSupplierCollection clsSupplierCollection = new clsSupplierCollection();
            clssupplier clssupplier = new clssupplier();
            clssupplier.Active = true;
            clssupplier.supplier_id = 1;
            clssupplier.Supplier_Name = "qwe";
            clssupplier.DateAdded = DateTime.Now.Date;
            clssupplier.available = 1;
            clssupplier.Phones_Supplied = "sadf";
            clssupplier.Contact_Number = "0121";
            clsSupplierCollection.ThisSupplier = clssupplier;
            Assert.AreEqual(clssupplier, clsSupplierCollection.ThisSupplier);
        }
        [TestMethod]
        public void ListAndCountOk()
        {
            clsSupplierCollection clsSupplierCollection = new clsSupplierCollection();
            List<clssupplier> listsup = new List<clssupplier>();
            clssupplier clssupplier = new clssupplier();
            clssupplier.Active = true;
            clssupplier.supplier_id = 1;
            clssupplier.Supplier_Name = "qwe";
            clssupplier.DateAdded = DateTime.Now.Date;
            clssupplier.available = 1;
            clssupplier.Phones_Supplied = "sadf";
            clssupplier.Contact_Number = "0121";
            listsup.Add(clssupplier);
            clsSupplierCollection.supplierList = listsup;
            Assert.AreEqual(clsSupplierCollection.Count, listsup.Count);
        }
        [TestMethod]
        public void AddMethodOkay()
        {
            clsSupplierCollection clsSupplierCollection = new clsSupplierCollection();
            clssupplier clssupplier = new clssupplier();
            Int32 primaryKey = 0;
            clssupplier.Active = true;
            clssupplier.supplier_id = 1;
            clssupplier.Supplier_Name = "qwe";
            clssupplier.DateAdded = DateTime.Now.Date;
            clssupplier.available = 1;
            clssupplier.Phones_Supplied = "sadf";
            clssupplier.Contact_Number = "0121";
            clsSupplierCollection.ThisSupplier = clssupplier;
            primaryKey = clsSupplierCollection.Add();
            clssupplier.supplier_id = primaryKey;
            clsSupplierCollection.ThisSupplier.find(primaryKey);
            Assert.AreEqual(clsSupplierCollection.ThisSupplier, clssupplier);

        }
        [TestMethod]
        public void UpdateMethodOk()
        {
            clsSupplierCollection clsSupplierCollection = new clsSupplierCollection();
            clssupplier clssupplier = new clssupplier();
            Int32 primarykey = 0;
            clssupplier.supplier_id = 1;
            clssupplier.Supplier_Name = "qwe";
            clssupplier.DateAdded = DateTime.Now.Date;
            clssupplier.available = 1;
            clssupplier.Phones_Supplied = "sadf";
            clssupplier.Contact_Number = "0121";
            clsSupplierCollection.ThisSupplier = clssupplier;
            primarykey = clsSupplierCollection.Add();
            clssupplier.supplier_id = primarykey;
            clssupplier.Supplier_Name = "qwe";
            clssupplier.DateAdded = DateTime.Now.Date;
            clssupplier.available = 1;
            clssupplier.Phones_Supplied = "sadf";
            clssupplier.Contact_Number = "0121";
            clsSupplierCollection.ThisSupplier = clssupplier;
            clsSupplierCollection.update();
            clsSupplierCollection.ThisSupplier.find(primarykey);
            Assert.AreEqual(clsSupplierCollection.ThisSupplier, clssupplier);
        }
        [TestMethod]
        public void DeleteMethodOk()
        {
            clsSupplierCollection clsSupplierCollection = new clsSupplierCollection();
            clssupplier clssupplier = new clssupplier();
            Int32 primarykey = 0;
            clssupplier.supplier_id = 1;
            clssupplier.Supplier_Name = "qwe";
            clssupplier.DateAdded = DateTime.Now.Date;
            clssupplier.available = 1;
            clssupplier.Phones_Supplied = "sadf";
            clssupplier.Contact_Number = "0121";
            clsSupplierCollection.ThisSupplier = clssupplier;
            primarykey = clsSupplierCollection.Add();
            clssupplier.supplier_id = primarykey;
            clsSupplierCollection.ThisSupplier.find(primarykey);
            clsSupplierCollection.Delete();
            Boolean found = clsSupplierCollection.ThisSupplier.find(primarykey);
            Assert.IsFalse(found);
        }
        [TestMethod]
        public void reportByPhonesOK()
        {
            clsSupplierCollection clsSupplierCollection = new clsSupplierCollection();
            clsSupplierCollection collectionfiltered = new clsSupplierCollection();
            collectionfiltered.ReportByPhones("xxx");
            Assert.AreEqual(clsSupplierCollection.Count, collectionfiltered.Count);
        }
        [TestMethod]
        public void ReportBypostCodeTestDataFound()
        {
            clsSupplierCollection clsSupplierCollection = new clsSupplierCollection(); 
            Boolean OK = true;
            clsSupplierCollection.ReportByPhones("a52");
            Console.WriteLine(clsSupplierCollection.Count);
            if (clsSupplierCollection.Count == 2)
            {
                if (clsSupplierCollection.supplierList[0].supplier_id != 68)
                {
                    
                    OK = false;
                }
                if (clsSupplierCollection.supplierList[1].supplier_id != 72)
                {
                
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

    }
}
