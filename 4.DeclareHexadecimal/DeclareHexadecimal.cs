/*Declare an integer variable and assign it with the value 254 in hexadecimal format. Use Windows Calculator to find its hexadecimal representation.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.DeclareHexadecimal
{
    class DeclareHexadecimal
    {
        static void Main(string[] args)
        {
            int num = 0xFE;
            Console.WriteLine(num);
            int numTwo = 254;
            Console.WriteLine("{0:X}", numTwo);

        }
    }
}
