using System;
using System.Collections.Generic;
using System.Text;

namespace CS___Class_and_Methods_2___Step_164
{
    class MathOp
    {
        public static int MathMethod(int num1)
        {
            int num1Result = num1 + 10;
            return num1Result;
        }
       
        public static decimal MathMethod(int num1, decimal num2)
        {
            decimal num2Result = num2 * 10;
            return num2Result;
        }

        public static string MathMethod(int num1, decimal num2, string num3)
        {
            int num4 = Convert.ToInt32(num3);
            int num3Result = num4 - 10;
            return num3Result;
        }
    }
}





