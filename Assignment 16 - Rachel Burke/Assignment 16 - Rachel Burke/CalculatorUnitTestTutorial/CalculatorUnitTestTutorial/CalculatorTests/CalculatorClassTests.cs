using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorUnitTestTutorial;


//To run this project go to the Build menu and select Build Solution

namespace CalculatorTests
{
    [TestClass]
    public class CalculatorClassTests
    {
        Calculator objCalculator;

        [TestMethod]
        public void AdderTest()
        {
            objCalculator = new Calculator(5, 2, 3);

            Assert.AreEqual(objCalculator.adder(), 10);

        }

        [TestMethod]
        public void MultiplierTest()
        {
            objCalculator = new Calculator(5, 2, 3);

            Assert.AreEqual(objCalculator.multiplier(), 30);
        }

        [TestMethod]
        public void DividerTestPass()
        {
            objCalculator = new Calculator(16, 4, 4);

            double divident = 16;
            double divisor = 4;
            double quotient = objCalculator.Divider(divident, divisor);

            Assert.AreEqual(quotient, 4);
        }

        [TestMethod]
        //[ExpectedException(typeof(DivideByZeroException))]
        public void DividerTestZero()
        {
            objCalculator = new Calculator(4, 0, 0);

            double divident = 4;
            double divisor = 0;
            double quotient = objCalculator.Divider(divident, divisor);

        }

        [TestMethod]
        public void PowerTestPass()
        {
            objCalculator = new Calculator(2, 3, 8);
            double Base = 2;
            double Exponent = 3;
            double result = objCalculator.ToThePower(Base, Exponent);

            Assert.AreEqual(result, 8);
        }
    }
}
