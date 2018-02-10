using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Capstone.Classes;

namespace CapstoneTests
{
    [TestClass]
    public class VendingMachineTest
    {
        VendingMachine testVM;

        [TestInitialize]
        public void Inintialize()
        {
            testVM = new VendingMachine();
        }

        [TestMethod]
        public void FeedMoney()
        {
            testVM.FeedMoney(5);
            decimal a = testVM.Balance;
            Assert.AreEqual(5, (a));
        }
        
        [TestMethod]
        public void DoesItReturnCorrectItem()
        {
            Assert.AreEqual("Cola", testVM.GetItemAtSlot("C1").ItemName);
        }
        
        [TestMethod]
        public void IsTheQuantTheSame()
        {
            Assert.AreEqual(5, testVM.GetQuantityRemaining("C1"));
        }


    }
}
