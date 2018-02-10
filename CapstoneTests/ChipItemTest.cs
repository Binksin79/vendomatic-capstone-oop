using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Capstone.Classes;

namespace CapstoneTests
{
    [TestClass]
    public class ChipItemTest
    {
        [TestMethod]
        public void DoesItCrunchCrunchYum()
        {
            // Arrange
            ChipItem tester = new ChipItem("test", 1);
            // Act
            string result = tester.Consume();
            // Assert
            Assert.AreEqual("Crunch Crunch, Yum!", result);
        }
    }
}
