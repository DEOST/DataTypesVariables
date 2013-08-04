/*Write a program that safely compares floating-point numbers 
 with precision of 0.000001. Examples:(5.3 ; 6.01)  false; 
 (5.00000001 ; 5.00000003)  true*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.FloatingPointPrecision
{
    class FloatingPrecision
    {
        static void Main()
        {
            Console.WriteLine("Write first number: ");
            float firstNum = float.Parse(Console.ReadLine());
            Console.WriteLine("Write second number: ");
            float secondNum = float.Parse(Console.ReadLine());
            bool result = (firstNum == secondNum);
            Console.WriteLine(result);
        }
    }
}
