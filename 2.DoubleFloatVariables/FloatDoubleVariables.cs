/*Which of the following values can be assigned to a variable of 
  type float and which to a variable of type double: 
 34.567839023, 12.345, 8923.1234857, 3456.091?*/


using System;

namespace _2.DoubleFloatVariables
{
    class FloatDoubleVariables
    {
        static void Main()
        {
            double firstNum = 34.567839023;
            float secondNum = 12.345f;
            double thirdNum = 8923.1234857;
            float forthNum = 3456.091f;
            Console.WriteLine("{0}, {1}, {2}, {3}", firstNum, secondNum, thirdNum, forthNum);
        }
    }
}
