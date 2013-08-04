using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.HelloWorld
{
    class ObjectString
    {
        static void Main()
        {
            string first = "Hello";
            string second = "World!";
            object concate = first + " " + second;
            string result = concate.ToString();
            Console.WriteLine(result);
        }
    }
}
