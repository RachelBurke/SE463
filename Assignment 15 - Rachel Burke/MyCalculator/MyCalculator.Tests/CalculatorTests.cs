using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyCalculator.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        //Ran unit tests through ReSharpner and the AddSimple test was found to be ignored
        // When ignore commented out all tests run great

        [TestMethod]
        [TestCategory("Add")]
        //[Ignore] - Removed from previous version to ensure test ran
        public void AddSimple()
        {
            Calculator calculator = new Calculator(); //Arrange
            int sum = calculator.Add(1, 2);          //Act
            Assert.AreEqual(3, sum);                 //Assert
        }
        [TestMethod]
        [TestCategory("Divide")]
        public void DivideSimple()
        {
            Calculator calculator = new Calculator();
            int quotient = calculator.Divide(10, 5);
            Assert.AreEqual(2, quotient);
        }
        [TestMethod]
        [TestCategory("Divide")]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DivideByZero()
        {
            Calculator calculator = new Calculator();
            calculator.Divide(10, 0);
        }
    }
}
