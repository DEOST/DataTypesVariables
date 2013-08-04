/*Declare a character variable and assign it with the symbol that has Unicode code 72. Hint: first use the Windows Calculator to find the hexadecimal representation of 72*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.DeclareChar
{
    class DeclareChar
    {
        static void Main()
        {
            char symbolVar = '\u0048';
            Console.WriteLine("72 unicode corespond to {0}", symbolVar);
        }
    }
}
