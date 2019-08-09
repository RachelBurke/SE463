using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateArea
{
    public class AreaCalculatorClass
    {
        public object AreaCalculator(string shape, int[] parameters)
        {
            switch (shape)
            {
                case "circle":
                    if (parameters.Length != 1)
                    {
                        throw new ArgumentException("Invalid Parameters for circle. Expected 1 value");
                    }
                    return Math.Round(Math.PI * Math.Pow(parameters[0], 2), 2);
                case "rectangle":
                    if (parameters.Length != 2)
                    {
                        throw new ArgumentException("Invalid Parameters for rectangle. Expected 2 values");
                    }
                    return parameters[0] * parameters[1];
                case "triangle":
                    if(parameters.Length != 2)
                    {
                        throw new ArgumentException("Invalid Parameters for rectangle. Expected 2 values");
                    }
                    return 0.5 * parameters[0] * parameters[1];
                default:
                    throw new NotImplementedException();
            }

        }
    }
}
