using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdderUnitTestTutorial
{
    public class Adder
    {
        public double num1 { get; set; }
        public double num2 { get; set; }

        public Adder(double n1, double n2)
        {
            num1 = n1;
            num2 = n2;
        }

        public double add()
        {
            return num1 + num2;
            //return num1 - num2; //injected error
            //return num1 * num2; //injected error
            //return num1 / num2; //injected error
            //return num1 % num2; //injected error
        }
    }
}
