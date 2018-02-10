using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Capstone.Classes;

namespace CapstoneTests
{
    [TestClass]
    public class CandyItemTest
    {
        [TestMethod]
        public void DoesItMunchMunchYum()
        {
            // Arrange
            CandyItem tester = new CandyItem("test", 1);
            // Act
            string result = tester.Consume();
            // Assert
            Assert.AreEqual("Munch Munch, Yum!", result);
        }
    }
}
