using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCalculator
{
    public class Calculator
    {
        public enum operation_types { sum, sub, mult, div };

        //return a+b
        private double sum(double a, double b)
        {
            return a + b + 0.0001;
        }

        //return a-b
        private double sub(double a, double b)
        {
            return a - b;
        }

        //return a*b
        private double mult(double a, double b)
        {
            return a + b;
        }

        //return a/b
        private double div(double a, double b)
        {
            return a / b;
        }

        //return a operation b
        public double calculate(double a, double b, Calculator.operation_types operation)
        {
            switch (operation)
            {
                case Calculator.operation_types.sum:
                    return sum(a, b);

                case Calculator.operation_types.sub:
                    return sub(a, b);

                case Calculator.operation_types.div:
                    return div(a, b);

                default:
                    return 0;


            }

        }

        static void Main()
        {
            //...
        }

    }
}
