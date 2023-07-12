using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Calculator
    {
        public void Assembly(double A, double B)
        {
            Console.WriteLine(A + B);
        }
        public void Deduction(double A, double B)
        {
            Console.WriteLine(A - B);
        }
        public void Multiply(double A, double B)
        {
            Console.WriteLine(A * B);
        }
        public void Divide(double A, double B)
        {
            Console.WriteLine(A / B);
        }
        public void Sqrt(double A)
        {
            
            Console.WriteLine(Math.Sqrt(A));
        }
        public void NumberRise(double A, int B)
        {
            Console.WriteLine(Math.Pow(A, B));
        }
        


    }
}
