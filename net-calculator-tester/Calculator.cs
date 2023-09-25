using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_calculator_tester
{
    public static class Calculator
    {
        public static float Add(float a, float b) {  return a + b; }

        public static float Subtract(float a, float b) { return a - b; }

        
        public static double Divide(double a, double b)
        {
            if (b == 0)
            {
                throw new System.ArgumentException("Impossibile dividere per zero");
            }
            return a / b;
        }

        public static float Multiply(float a, float b) { return a*b; }

    }
}
