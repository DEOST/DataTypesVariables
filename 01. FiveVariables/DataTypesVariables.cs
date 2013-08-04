/*Declare five variables choosing for each of them the most appropriate of 
the types byte, sbyte, short, ushort, int, uint, long, ulong to represent 
the following values: 52130, -115, 4825932, 97, -10000.*/

using System;

class FiveVariables
    {
        static void Main()
        {
            ushort firstNum = 52130;
            sbyte secondNum = -115;
            int thirdNum = 4825932;
            byte forthNum = 97;
            short fifthNum = -1000;
            Console.WriteLine("{0}, {1}, {2}, {3}, {4}", firstNum, secondNum, thirdNum, forthNum, fifthNum);
        }
    }

