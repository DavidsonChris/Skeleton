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
    }
}
