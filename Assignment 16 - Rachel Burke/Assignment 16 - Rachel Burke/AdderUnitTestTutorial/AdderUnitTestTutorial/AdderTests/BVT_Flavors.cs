using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdderUnitTestTutorial;

//to run these test cases need to go to Build > Build Solution

namespace AdderTests
{
    [TestClass]
    public class BVT_Flavors
    {
        Adder objAdder;

        [TestMethod]
        public void BVT_Normal()
        {
            //Testing Technique Name: BVA Normal (Assumptions: Single Fault, Valid numeric input)					
            //Boundaries: min, min+, nom, max-,max					
            //Boundary Values: 0, 1, 49, 98,99					
            //Number of test cases: 4n+1 = 9  ( n = 2 number of variables, 4 boundaries)	
            //Case# N1 N2
            //1	    49	0
            //2	    49	1
            //3	    49	49
            //4	    49	98
            //5	    49	99
            //6	    0	49
            //7	    1	49
            //8*	49	49 (redundant--can be ommitted)
            //9	    98	49
            //10	99	49

            objAdder = new Adder(49,0);
            Assert.AreEqual(49, objAdder.add(), "Test Case Failed");

            objAdder = new Adder(49, 1);
            Assert.AreEqual(50, objAdder.add(), "Test Case Failed");

            objAdder = new Adder(49, 49);
            Assert.AreEqual(98, objAdder.add(), "Test Case Failed");

            objAdder = new Adder(49, 98);
            Assert.AreEqual(147, objAdder.add(), "Test Case Failed");

            objAdder = new Adder(49, 99);
            Assert.AreEqual(148, objAdder.add(), "Test Case Failed");

            objAdder = new Adder(0, 49);
            Assert.AreEqual(49, objAdder.add(), "Test Case Failed");

            objAdder = new Adder(1, 49);
            Assert.AreEqual(50, objAdder.add(), "Test Case Failed");

            objAdder = new Adder(98, 49);
            Assert.AreEqual(147, objAdder.add(), "Test Case Failed");

            objAdder = new Adder(99, 49);
            Assert.AreEqual(148, objAdder.add(), "Test Case Failed");
        }

        [TestMethod]
        public void BVT_Robust()
        {
            //BVA Robust (Single Fault)					
            //Number of test cases = 6n+1 = 13  (n is the number of variables)					
            //min-, min, min+, nom, max-,max, max+					
            // -1, 0, 1, 49, 98, 99, 100	
            //Case #    N1	N2
            //  1	     49	-1
            //  2	     49  0
            //  3	     49	 1
            //  4	     49	49
            //  5	    49	98
            //  6	    49	99
            //  7	    49	100
            //  8	    -1	49
            //  9	    0	49
            //  10	    1	49
            //  11*	    49	49 (redundant--can be ommitted)
            //  12	    98	49
            //  13	    99	49
            //  14	    100	49

            objAdder = new Adder(49, -1);
            Assert.AreEqual(48, objAdder.add(), "Test Case Failed");

            objAdder = new Adder(49, 0);
            Assert.AreEqual(49, objAdder.add(), "Test Case Failed");

            objAdder = new Adder(49, 1);
            Assert.AreEqual(50, objAdder.add(), "Test Case Failed");

            objAdder = new Adder(49, 49);
            Assert.AreEqual(98, objAdder.add(), "Test Case Failed");

            objAdder = new Adder(49, 98);
            Assert.AreEqual(147, objAdder.add(), "Test Case Failed");

            objAdder = new Adder(49, 99);
            Assert.AreEqual(148, objAdder.add(), "Test Case Failed");

            objAdder = new Adder(49, 100);
            Assert.AreEqual(149, objAdder.add(), "Test Case Failed");

            objAdder = new Adder(-1, 49);
            Assert.AreEqual(48, objAdder.add(), "Test Case Failed");

            objAdder = new Adder(0, 49);
            Assert.AreEqual(49, objAdder.add(), "Test Case Failed");

            objAdder = new Adder(1, 49);
            Assert.AreEqual(50, objAdder.add(), "Test Case Failed");

            objAdder = new Adder(98, 49);
            Assert.AreEqual(147, objAdder.add(), "Test Case Failed");

            objAdder = new Adder(99, 49);
            Assert.AreEqual(148, objAdder.add(), "Test Case Failed");

            objAdder = new Adder(100, 49);
            Assert.AreEqual(149, objAdder.add(), "Test Case Failed");

        }

        [TestMethod]
        public void BVT_WorstCase()
        {
            //BVA Worst Case (Multi Fault)										
            //Number of test cases = 5^n = 25  (cartesian product of all 5 boundary values below)(n is the number of variables)										
            //min, min+, nom, max-,max										
            // 0, 1, 49, 98, 99		
            //Case #	N1	N2
            //1     	0	1
            //2	        0	0
            //3     	0	49
            //4     	0	98
            //5	        0	99
            //6	        1	1
            //7	        1	0
            //8	        1	49
            //9	        1	98
            //10	    1	99
            //11	    49	1
            //12	    49	0
            //13	    49	49
            //14	    49	98
            //15	    49	99
            //16	    98	1
            //17	    98	0
            //18	    98	49
            //19	    98	98
            //20	    98	99
            //21	    99	1
            //22	    99	0
            //23	    99	49
            //24	    99	98
            //25	    99	99

            objAdder = new Adder(0,1);
            Assert.AreEqual(1, objAdder.add(), "Test Case Failed");

            objAdder = new Adder(0, 0);
            Assert.AreEqual(0, objAdder.add(), "Test Case Failed");

            objAdder = new Adder(0, 49);
            Assert.AreEqual(49, objAdder.add(), "Test Case Failed");

            objAdder = new Adder(0, 98);
            Assert.AreEqual(98, objAdder.add(), "Test Case Failed");

            objAdder = new Adder(0, 99);
            Assert.AreEqual(99, objAdder.add(), "Test Case Failed");

            objAdder = new Adder(1, 1);
            Assert.AreEqual(2, objAdder.add(), "Test Case Failed");

            objAdder = new Adder(1, 0);
            Assert.AreEqual(1, objAdder.add(), "Test Case Failed");

            objAdder = new Adder(1, 49);
            Assert.AreEqual(50, objAdder.add(), "Test Case Failed");

            objAdder = new Adder(1, 98);
            Assert.AreEqual(99, objAdder.add(), "Test Case Failed");

            objAdder = new Adder(1, 99);
            Assert.AreEqual(100, objAdder.add(), "Test Case Failed");

            objAdder = new Adder(49, 1);
            Assert.AreEqual(50, objAdder.add(), "Test Case Failed");

            objAdder = new Adder(49, 0);
            Assert.AreEqual(49, objAdder.add(), "Test Case Failed");

            objAdder = new Adder(49, 49);
            Assert.AreEqual(98, objAdder.add(), "Test Case Failed");

            objAdder = new Adder(49, 98);
            Assert.AreEqual(147, objAdder.add(), "Test Case Failed");

            objAdder = new Adder(49, 99);
            Assert.AreEqual(148, objAdder.add(), "Test Case Failed");

            objAdder = new Adder(98, 1);
            Assert.AreEqual(99, objAdder.add(), "Test Case Failed");

            objAdder = new Adder(98, 0);
            Assert.AreEqual(98, objAdder.add(), "Test Case Failed");

            objAdder = new Adder(98, 49);
            Assert.AreEqual(147, objAdder.add(), "Test Case Failed");

            objAdder = new Adder(98, 98);
            Assert.AreEqual(196, objAdder.add(), "Test Case Failed");

            objAdder = new Adder(98, 99);
            Assert.AreEqual(197, objAdder.add(), "Test Case Failed");

            objAdder = new Adder(99, 1);
            Assert.AreEqual(100, objAdder.add(), "Test Case Failed");

            objAdder = new Adder(99, 0);
            Assert.AreEqual(99, objAdder.add(), "Test Case Failed");

            objAdder = new Adder(99, 49);
            Assert.AreEqual(148, objAdder.add(), "Test Case Failed");

            objAdder = new Adder(99, 98);
            Assert.AreEqual(197, objAdder.add(), "Test Case Failed");

            objAdder = new Adder(99, 99);
            Assert.AreEqual(198, objAdder.add(), "Test Case Failed");

        }

        [TestMethod]
        public void BVT_WorstCaseRobust()
        {
            //BVA Robust Worst Case (Multi Fault)					
            //Number of test cases = 7^n = 49  (cartesian product of all 7 boundary values below)(n is the number of variables)					
            //min-, min, min+, nom, max-, max, max+					
            //  -1, 0, 1, 49, 98, 99, 100					
            //Case #	N1	N2
            //1	        -1	-1
            //2	        -1	0
            //3	        -1	1
            //4	        -1	49
            //5	        -1	98
            //6	        -1	99
            //7	        -1	100
            //8	        0	-1
            //9	        0	0
            //10	    0	1
            //11	    0	49
            //12    	0	98
            //13    	0	99
            //14    	0	100
            //15    	1	-1
            //16    	1	0
            //17	    1	1
            //18    	1	49
            //19    	1	98
            //20    	1	99
            //21    	1	100
            //22    	49	-1
            //23    	49	0
            //24    	49	1
            //25    	49	49
            //26    	49	98
            //27    	49	99
            //28    	49	100
            //29    	98	-1
            //30    	98	0
            //31    	98	1
            //32    	98	49
            //33    	98	98
            //34    	98	99
            //35    	98	100
            //36    	99	-1
            //37    	99	0
            //38    	99	1
            //39    	99	49
            //40    	99	98
            //41    	99	99
            //42    	99	100
            //43    	100	-1
            //44    	100	0
            //45    	100	1
            //46    	100	49
            //47    	100	98
            //48    	100	99
            //49    	100	100

            objAdder = new Adder(-1, -1);
            Assert.AreEqual(-2, objAdder.add(), "Test Case Failed");
            objAdder = new Adder(-1, 0);
            Assert.AreEqual(-1, objAdder.add(), "Test Case Failed");
            objAdder = new Adder(-1, 1);
            Assert.AreEqual(0, objAdder.add(), "Test Case Failed");
            objAdder = new Adder(-1, 49);
            Assert.AreEqual(48, objAdder.add(), "Test Case Failed");
            objAdder = new Adder(-1, 98);
            Assert.AreEqual(97, objAdder.add(), "Test Case Failed");
            objAdder = new Adder(-1, 99);
            Assert.AreEqual(98, objAdder.add(), "Test Case Failed");
            objAdder = new Adder(-1, 100);
            Assert.AreEqual(99, objAdder.add(), "Test Case Failed");

            objAdder = new Adder(0, -1);
            Assert.AreEqual(-1, objAdder.add(), "Test Case Failed");
            objAdder = new Adder(0, 0);
            Assert.AreEqual(0, objAdder.add(), "Test Case Failed");
            objAdder = new Adder(0, 1);
            Assert.AreEqual(1, objAdder.add(), "Test Case Failed");
            objAdder = new Adder(0, 49);
            Assert.AreEqual(49, objAdder.add(), "Test Case Failed");
            objAdder = new Adder(0, 98);
            Assert.AreEqual(98, objAdder.add(), "Test Case Failed");
            objAdder = new Adder(0, 99);
            Assert.AreEqual(99, objAdder.add(), "Test Case Failed");
            objAdder = new Adder(0, 100);
            Assert.AreEqual(100, objAdder.add(), "Test Case Failed");

            objAdder = new Adder(1, -1);
            Assert.AreEqual(0, objAdder.add(), "Test Case Failed");
            objAdder = new Adder(1, 0);
            Assert.AreEqual(1, objAdder.add(), "Test Case Failed");
            objAdder = new Adder(1, 1);
            Assert.AreEqual(2, objAdder.add(), "Test Case Failed");
            objAdder = new Adder(1, 49);
            Assert.AreEqual(50, objAdder.add(), "Test Case Failed");
            objAdder = new Adder(1, 98);
            Assert.AreEqual(99, objAdder.add(), "Test Case Failed");
            objAdder = new Adder(1, 99);
            Assert.AreEqual(100, objAdder.add(), "Test Case Failed");
            objAdder = new Adder(1, 100);
            Assert.AreEqual(101, objAdder.add(), "Test Case Failed");

            objAdder = new Adder(49, -1);
            Assert.AreEqual(48, objAdder.add(), "Test Case Failed");
            objAdder = new Adder(49, 0);
            Assert.AreEqual(49, objAdder.add(), "Test Case Failed");
            objAdder = new Adder(49, 1);
            Assert.AreEqual(50, objAdder.add(), "Test Case Failed");
            objAdder = new Adder(49, 49);
            Assert.AreEqual(98, objAdder.add(), "Test Case Failed");
            objAdder = new Adder(49, 98);
            Assert.AreEqual(147, objAdder.add(), "Test Case Failed");
            objAdder = new Adder(49, 99);
            Assert.AreEqual(148, objAdder.add(), "Test Case Failed");
            objAdder = new Adder(49, 100);
            Assert.AreEqual(149, objAdder.add(), "Test Case Failed");

            objAdder = new Adder(98, -1);
            Assert.AreEqual(97, objAdder.add(), "Test Case Failed");
            objAdder = new Adder(98, 0);
            Assert.AreEqual(98, objAdder.add(), "Test Case Failed");
            objAdder = new Adder(98, 1);
            Assert.AreEqual(99, objAdder.add(), "Test Case Failed");
            objAdder = new Adder(98, 49);
            Assert.AreEqual(147, objAdder.add(), "Test Case Failed");
            objAdder = new Adder(98, 98);
            Assert.AreEqual(196, objAdder.add(), "Test Case Failed");
            objAdder = new Adder(98, 99);
            Assert.AreEqual(197, objAdder.add(), "Test Case Failed");
            objAdder = new Adder(98, 100);
            Assert.AreEqual(198, objAdder.add(), "Test Case Failed");

            objAdder = new Adder(99, -1);
            Assert.AreEqual(98, objAdder.add(), "Test Case Failed");
            objAdder = new Adder(99, 0);
            Assert.AreEqual(99, objAdder.add(), "Test Case Failed");
            objAdder = new Adder(99, 1);
            Assert.AreEqual(100, objAdder.add(), "Test Case Failed");
            objAdder = new Adder(99, 49);
            Assert.AreEqual(148, objAdder.add(), "Test Case Failed");
            objAdder = new Adder(99, 98);
            Assert.AreEqual(197, objAdder.add(), "Test Case Failed");
            objAdder = new Adder(99, 99);
            Assert.AreEqual(198, objAdder.add(), "Test Case Failed");
            objAdder = new Adder(99, 100);
            Assert.AreEqual(199, objAdder.add(), "Test Case Failed");

            objAdder = new Adder(100, -1);
            Assert.AreEqual(99, objAdder.add(), "Test Case Failed");
            objAdder = new Adder(100, 0);
            Assert.AreEqual(100, objAdder.add(), "Test Case Failed");
            objAdder = new Adder(100, 1);
            Assert.AreEqual(101, objAdder.add(), "Test Case Failed");
            objAdder = new Adder(100, 49);
            Assert.AreEqual(149, objAdder.add(), "Test Case Failed");
            objAdder = new Adder(100, 98);
            Assert.AreEqual(198, objAdder.add(), "Test Case Failed");
            objAdder = new Adder(100, 99);
            Assert.AreEqual(199, objAdder.add(), "Test Case Failed");
            objAdder = new Adder(100, 100);
            Assert.AreEqual(200, objAdder.add(), "Test Case Failed");

        }

        [TestMethod]
        public void ECT_WeakNormal()
        {
            //Testing Technique Name: ECT Weak Normal (Assumptions: Single Fault, Valid numeric input)					
            //Equivalence Classes (Valid Input Values)					
            //R1 = {0 <= num1 <= 99}, R2 = {0 <= num2 <= 99}		
            //Number of test cases: 1 (equal to the largest subset of partitions)	
            //Case# N1 N2
            //1	    49 51

            objAdder = new Adder(49, 51);
            Assert.AreEqual(100, objAdder.add(), "Test Case Failed");
        }

        [TestMethod]
        public void ECT_StrongNormal()
        {
            //Testing Technique Name: ECT Strong Normal (Assumptions: Multi Fault, Valid numeric input)					
            //Equivalence Classes (Valid Input Values)					
            //R1 = {0 <= num1 <= 99}, R2 = {0 <= num2 <= 99}		
            //Number of test cases: 4 (Cartesian Product of all interval values)	
            //Case# N1 N2
            //1	    0  99
            //2     99 0

            objAdder = new Adder(0, 99);
            Assert.AreEqual(99, objAdder.add(), "Test Case Failed");

            objAdder = new Adder(99, 0);
            Assert.AreEqual(99, objAdder.add(), "Test Case Failed");

        }

        [TestMethod]
        public void ECT_WeakRobust()
        {
            //Testing Technique Name: ECT Weak Robust (Assumptions: Single Fault, Valid and Invalid numeric input)					
            //Equivalence Classes (Valid Input Values)					
            //R1 = {0 <= num1 <= 99}, R2 = {0 <= num2 <= 99}	
            //Equivalence Classes (Invalid Input Values)
            //R3 = {num1 < 0}, R4 = {num1 > 99}, R5 = {num2 < 0}, R6 = {num2 > 99}
            //Number of test cases: 6 (2 valid + 4 invalid)	
            //Case# N1  N2
            //1	    -1  50
            //2     100 50
            //3     50  -1
            //4     50  100
            //5     49  51
            //6     51  49

            objAdder = new Adder(-1, 50);
            Assert.AreEqual(49, objAdder.add(), "Test Case Failed");

            objAdder = new Adder(100, 50);
            Assert.AreEqual(150, objAdder.add(), "Test Case Failed");

            objAdder = new Adder(50, -1);
            Assert.AreEqual(49, objAdder.add(), "Test Case Failed");

            objAdder = new Adder(50, 100);
            Assert.AreEqual(150, objAdder.add(), "Test Case Failed");

            objAdder = new Adder(49, 51);
            Assert.AreEqual(100, objAdder.add(), "Test Case Failed");

            objAdder = new Adder(51, 49);
            Assert.AreEqual(100, objAdder.add(), "Test Case Failed");

        }

        [TestMethod]
        public void ECT_StrongRobust()
        {
            //Testing Technique Name: ECT Strong Robust (Assumptions: Multi Fault, Valid and Invalid numeric input)					
            //Equivalence Classes (Valid Input Values)					
            //R1 = {0 <= num1 <= 99}, R2 = {0 <= num2 <= 99}	
            //Equivalence Classes (Invalid Input Values)
            //R3 = {num1 < 0}, R4 = {num1 > 99}, R5 = {num2 < 0}, R6 = {num2 > 99}
            //Number of test cases: 9 (3 num1 * 3 num2)	
            //Case# N1   N2
            //1	    -1   -1
            //2     -1   50
            //3     -1  100
            //4     50   -1
            //5     50   50
            //6     50  100
            //7    100   -1
            //8    100   50
            //9    100  100

            objAdder = new Adder(-1, -1);
            Assert.AreEqual(-2, objAdder.add(), "Test Case Failed");

            objAdder = new Adder(-1, 50);
            Assert.AreEqual(49, objAdder.add(), "Test Case Failed");

            objAdder = new Adder(-1, 100);
            Assert.AreEqual(99, objAdder.add(), "Test Case Failed");

            objAdder = new Adder(50, -1);
            Assert.AreEqual(49, objAdder.add(), "Test Case Failed");

            objAdder = new Adder(50, 50);
            Assert.AreEqual(100, objAdder.add(), "Test Case Failed");

            objAdder = new Adder(50, 100);
            Assert.AreEqual(150, objAdder.add(), "Test Case Failed");

            objAdder = new Adder(100, -1);
            Assert.AreEqual(99, objAdder.add(), "Test Case Failed");

            objAdder = new Adder(100, 50);
            Assert.AreEqual(150, objAdder.add(), "Test Case Failed");

            objAdder = new Adder(100, 100);
            Assert.AreEqual(200, objAdder.add(), "Test Case Failed");

        }

        [TestMethod]
        public void SpecialValue()
        {
            //Special Value Testing
            //Testing some boundary values along with decimal cases

            objAdder = new Adder(-1, -1);
            Assert.AreEqual(-2, objAdder.add(), "Test Case Failed");

            objAdder = new Adder(-1, 50);
            Assert.AreEqual(49, objAdder.add(), "Test Case Failed");

            objAdder = new Adder(-1, 100);
            Assert.AreEqual(99, objAdder.add(), "Test Case Failed");

            objAdder = new Adder(50, -1);
            Assert.AreEqual(49, objAdder.add(), "Test Case Failed");

            objAdder = new Adder(50, 100);
            Assert.AreEqual(150, objAdder.add(), "Test Case Failed");

            objAdder = new Adder(100, 100);
            Assert.AreEqual(200, objAdder.add(), "Test Case Failed");

            objAdder = new Adder(50.33, 100.33);
            Assert.AreEqual(150.66, objAdder.add(), "Test Case Failed");

            objAdder = new Adder(0.33, 100);
            Assert.AreEqual(100.33, objAdder.add(), "Test Case Failed");

            objAdder = new Adder(-0.33, 50);
            Assert.AreEqual(49.67, objAdder.add(), "Test Case Failed");
        }
    }
}
