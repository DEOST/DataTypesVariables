//Create a program that assigns null values to an integer and to double variables. Try to print them on the console, try to add some values or the null literal to them and see the result.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.NullValues
{
    class Program
    {
        static void Main()
        {
            int? first = null;
            double? second = null;
            Console.WriteLine(first + "-" + second + "-");
            first = 3;
            second = 3.67;
            Console.WriteLine(first + "-" + second + "-");
        }
    }
}
