using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.tring
{
    class Program
    {
        static void Main()
        {
            string variable = "The \"use\" of quotations causes difficulties.";
            string secondOne = "The \u0022use\u0022 of quotations causes difficulties.";
            string thirdOne = @"The ""use"" of quotations causes difficulties.";
            
    Console.WriteLine("{0},\n {1},\n {2}", variable, secondOne, thirdOne);
        }
    }
}
