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
            clssupplier.sup_Name = "qwe";
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
            clssupplier.sup_Name = "qwe";
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
            clssupplier.sup_Name = "qwe";
            clssupplier.DateAdded = DateTime.Now.Date;
            clssupplier.available = 1;
            clssupplier.Phones_Supplied = "sadf";
            clssupplier.Contact_Number = "0121";
            listsup.Add(clssupplier);
            clsSupplierCollection.supplierList = listsup;
            Assert.AreEqual(clsSupplierCollection.Count, listsup.Count);
        }
        


    }
}
