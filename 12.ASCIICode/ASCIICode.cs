
/*Find online more information about ASCII 
 (American Standard Code for Information Interchange) 
 and write a program that prints the entire ASCII table of 
 characters on the console.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.ASCIICode
{
    class ASCIICode
    {
        static void Main()
        {
            for (int code = 0; (code <= 400); code++)
            {
                Console.WriteLine("for {0} => {1} ASCII code", code, (char)code);
            }
        }
    }
}
