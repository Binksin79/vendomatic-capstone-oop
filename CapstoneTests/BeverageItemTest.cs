using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Capstone.Classes;

namespace CapstoneTests
{
    [TestClass]
    public class BeverageItemTest
    {
        [TestMethod]
        public void DoesItGlugGlugYum()
        {
            // Arrange
            BeverageItem tester = new BeverageItem("test", 1);
            // Act
            string result = tester.Consume();
            // Assert
            Assert.AreEqual("Glug Glug, Yum!", result);
        }
    }
}
