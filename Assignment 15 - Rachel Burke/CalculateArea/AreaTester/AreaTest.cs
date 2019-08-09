using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculateArea;

namespace AreaTest
{
    [TestClass]
    public class AreaTester
    {
        private AreaCalculatorClass _target;

        [TestInitialize]
        public void Initialize()
        {
            _target = new AreaCalculatorClass();
        }

        [ExpectedException(typeof(ArgumentException))]
        [TestMethod]
        public void WhenCircleShouldOnlyHaveOneParameter()
        {
            string shape = "circle";
            int[] parameters = new int[0];
            var result = _target.AreaCalculator(shape, parameters);

        }
        [TestMethod]
        public void GivenCircleAndParameterLengthIsOneShouldPass()
        {
            string shape = "circle";
            int[] parameters = new int[1] { 1 };
            var result = _target.AreaCalculator(shape, parameters);
        }
        [ExpectedException(typeof(ArgumentException))]
        [TestMethod]
        public void GivenRectangleAndParameterLengthNotTwoThrowException()
        {
            string shape = "rectangle";
            int[] parameters = new int[0];
            var result = _target.AreaCalculator(shape, parameters);
        }

        [TestMethod]
        public void GivenRectangleAndParameterLengthIsTwoShouldPass()
        {
            string shape = "rectangle";
            int[] parameters = new int[2] { 1, 2 };
            var result = _target.AreaCalculator(shape, parameters);
        }

        [ExpectedException(typeof(ArgumentException))]
        [TestMethod]
        public void GivenTriangleAndParameterLengthNotTwoThrowException()
        {
            string shape = "triangle";
            int[] parameters = new int[0];
            var result = _target.AreaCalculator(shape, parameters);
        }

        [TestMethod]
        public void GivenTriangleAndParameterLengthIsTwoShouldPass()
        {
            string shape = "triangle";
            int[] parameters = new int[2] { 1, 2 };
            var result = _target.AreaCalculator(shape, parameters);
        }

        [TestMethod]
        public void GivenCircleAndParameterOfTwoAreaShouldEqual12_57()
        {
            string shape = "circle";
            int[] parameters = new int[1] { 2 };
            var result = _target.AreaCalculator(shape, parameters);
            Assert.AreEqual(12.57, result, "Test failed: improper calculation.");
        }

        [TestMethod]
        public void GivenRectangleAndParameterOf2x4AreaShouldEqual8()
        {
            string shape = "rectangle";
            int[] parameters = new int[2] { 2, 4 };
            var result = _target.AreaCalculator(shape, parameters);
            Assert.AreEqual(8, result, "Test failed: improper calculation.");
        }

        [TestMethod]
        public void GivenTriangleAndParameterOf2x4AreaShouldEqual4()
        {
            string shape = "triangle";
            int[] parameters = new int[2] { 2, 4 };
            var result = _target.AreaCalculator(shape, parameters);
            Assert.AreEqual(4.0, result, "Test failed: improper calculation.");
        }
    }
}