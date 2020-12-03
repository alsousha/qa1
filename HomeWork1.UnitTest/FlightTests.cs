using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace HomeWork1.UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CanBeCancelledBy_CustomerVIP_ReturnsTrue()
        {
           //A
            Flight flightForTest = new Flight();
            Customer customerForTest = new Customer { isVIP = true };

            //A
            bool result = flightForTest.CanBeCancelledBy(customerForTest);
           // bool result = flightForTest.CanBeCancelledBy(flightForTest.OrderBy);
            

            //A
            Assert.IsTrue(result);

        }
    }
}
