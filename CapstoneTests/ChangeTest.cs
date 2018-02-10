using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Capstone.Classes;

namespace CapstoneTests
{
    [TestClass]
    public class ChangeTest
    {
        [TestMethod]
        public void DoesItReturnProperChangeString()
        {
            //Arrange
            Change test = new Change(1.15M);
            //Act
            string result = test.GiveChange();
            //Assert
            Assert.AreEqual("Your change is: 4 quarters, 1 dimes, and 1 nickels.", result);
        }
    }
}
