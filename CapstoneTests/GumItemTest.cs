using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Capstone.Classes;

namespace CapstoneTests
{
    [TestClass]
    public class GumItemTest
    {
        [TestMethod]
        public void DoesItChewChewYum()
        {
            // Arrange
            GumItem tester = new GumItem("test", 1);
            // Act
            string result = tester.Consume();
            // Assert
            Assert.AreEqual("Chew Chew, Yum!", result);
        }
    }
}
