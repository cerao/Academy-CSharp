using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    public static class Calculator
    {
        public static int Add(int OneNumber, int TwoNumber)
        {

            return OneNumber + TwoNumber;
        }

        public static int Subtract(int OneNumber, int TwoNumber)
        {
            if(OneNumber > TwoNumber)
                return OneNumber - TwoNumber;
            else return TwoNumber - OneNumber;
        }

        public static int Multiply(int OneNumber, int TwoNumber)
        {

            return OneNumber * TwoNumber;
        }
        public static int Divide(int OneNumber, int TwoNumber)
        {
            return (OneNumber / TwoNumber);
        }
        public static int Pow(int OneNumber, int Quality)
        {
            var Result = 1;
            
            for (int i = 1; i <= OneNumber; i++)
            {
                Result *=OneNumber;
            }

            return Result;
        }
        public static int Sqrt(int OneNumber)
        {
            var Result = 0;
            int Count = 1;
            while (true)
            {
                Result = Count * Count;

                if(Result == OneNumber)
                {
                    break;
                }else if(Result > OneNumber)
                {
                    Result = 0;
                    break;
                }
                Count++;

            }
            return Count;
        }
    }
}
