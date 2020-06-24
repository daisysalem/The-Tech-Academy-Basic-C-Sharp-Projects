using System;
using System.Collections.Generic;
using System.Text;

namespace CS___Class_and_Methods_3___Step_165
{
    public class MathOps
    {
        public int MathMethod(int num1, string ans)
        {
            int result = 0;
            if (ans == "")
            {
                result = num1 + 10;

            }
            else
            {
                int num2 = Convert.ToInt32(ans);
                result = num1 + num2 + 10;
            }
            return result;

        }
        
    }
}
