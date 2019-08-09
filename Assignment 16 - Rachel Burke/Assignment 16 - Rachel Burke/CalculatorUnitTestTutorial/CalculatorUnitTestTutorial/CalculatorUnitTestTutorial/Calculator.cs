using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorUnitTestTutorial
{
    public class Calculator
    {
        public double num1 { get; set; }
        public double num2 { get; set; }
        public double num3 { get; set; }

        public Calculator(double n1, double n2, double n3)
        {
            num1 = n1;
            num2 = n2;
            num3 = n3;
        }
        public double adder ()
        {
           //return num1 - num2 + num3; //run with injected defect
           return num1 + num2 + num3; //try it with this correct line
        }

        public double multiplier()
        {
            //return num1 * num2 - num3; //run with injected defect
            return num1 * num2 * num3; //try it with this correct line
        }

        public double Divider(double divident, double divisor)
        {
            //return divisor / divident; //run with injected defect
            return divident / divisor; //try it with this correct line
        }

        public double ToThePower(double Base, double Exponent)
        {
            /*
            double times = Exponent; //run with injected defect
            double result = Base;
            while (times != 0)
            {
                result *= Base;
                times--;
            }

            return result;
            */

            double times = Exponent; //try it with these correct lines
            double result = Base;
            times--;
            while (times != 0)
            {
                result *= Base;
                times--;
            }

            return result;
        }
    }
    
}