using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using StringsUnitTestTutorial;

//to run these tests you need to Build > Build Solution

namespace StringTesting
{
    
    [TestClass]
    public class SpecialValueTests
    {
        strManipulator objManipulator;

        [TestMethod]
        public void TestStringSearch()
        {
            objManipulator = new strManipulator("aaabaaabaaa");

            Assert.IsTrue(objManipulator.search("a"), "this message is displayed when the assert fails");
            Assert.IsTrue(objManipulator.search("b"), "b is not found in the string");
            Assert.IsTrue(objManipulator.search("aa"), "aa is not found in the string");
            Assert.IsTrue(objManipulator.search("aba"), "aba is not found in the string");
            Assert.IsTrue(objManipulator.search("aaa"), "aaa is not found in the string");
            Assert.IsTrue(objManipulator.search(""), "empty string is not found");

            Assert.IsFalse(objManipulator.search("bbb"), "bbb is part of the string");
            Assert.IsFalse(objManipulator.search("xy"), "xy is part of the string");
            Assert.IsFalse(objManipulator.search(" "), "white space is part of the string");
            Assert.IsFalse(objManipulator.search("bb"), "bb is part of the string");
        }
        [TestMethod]
        public void TestStringStripper()
        {
            objManipulator = new strManipulator("aaabaaabaaa");

            Assert.AreEqual(objManipulator.stripper("a", ""), "bb");
            Assert.AreEqual(objManipulator.stripper("a", "x"), "xxxbxxxbxxx");
            Assert.AreEqual(objManipulator.stripper("b", "W"), "aaaWaaaWaaa");
            Assert.AreEqual(objManipulator.stripper("aaabaaabaaa", ""), "");

            Assert.AreNotEqual(objManipulator.stripper("b", ""), "aaaaaaaa");
            Assert.AreNotEqual(objManipulator.stripper("a", "x"), "aaaWaaaWaaa");

        }
        [TestMethod]
        public void TestStringWrapper()
        {
            objManipulator = new strManipulator("aaabaaabaaa");

            Assert.AreEqual(objManipulator.wrapper("XXX", "YYY"), "XXXaaabaaabaaaYYY");
            Assert.AreNotEqual(objManipulator.wrapper("XXX", "YYY"), "XaaabaaabaaaYYY");

            StringAssert.StartsWith(objManipulator.wrapper("AAA", "WWW"), "AAA");
            StringAssert.EndsWith(objManipulator.wrapper("XXX", "YYY"), "YYY");
            StringAssert.Contains(objManipulator.wrapper("XXX", "YYY"), "XaaabaaabaaaY");


        }
        [TestMethod]
        public void TestStringCapializer()
        {
            objManipulator = new strManipulator("aaabaaabaaa");

            Assert.AreEqual(objManipulator.capitalizer("a"), "A");
            Assert.AreEqual(objManipulator.capitalizer("b"), "B");
            Assert.AreEqual(objManipulator.capitalizer("aa"), "AA");
            Assert.AreEqual(objManipulator.capitalizer("aba"), "ABA");
            Assert.AreEqual(objManipulator.capitalizer("aaa"), "AAA");
            Assert.AreEqual(objManipulator.capitalizer(""), "");
            Assert.AreEqual(objManipulator.capitalizer("aAa"), "AAA");
            Assert.AreEqual(objManipulator.capitalizer("aaa bbb"), "AAA BBB");
            Assert.AreEqual(objManipulator.capitalizer("aaabaaa"), "AAABAAA");

        }
    }
}
