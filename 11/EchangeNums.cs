/*Declare  two integer variables and assign them with 5 and 10 and after that exchange their values.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeNums
{
    class ExchangeNums
    {
        static void Main()
        {
            int first = 5;
            int second = 10;
            first = first + second;
            second = first - second;
            first = first - second;
            Console.WriteLine("first {0}, second {1}", first,second);

        }
    }
}
