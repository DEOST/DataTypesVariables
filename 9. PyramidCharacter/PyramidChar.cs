/*Write a program that prints an isosceles triangle of 9 copyright 
 symbols ©. Use Windows Character Map to find the Unicode code of 
 the © symbol. Note: the © symbol may be displayed incorrectly.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.PyramidCharacter
{
    class PyramidChar
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("write number of rows");
            int n = int.Parse(Console.ReadLine());
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < 2 * n - 1; col++)
                {
                    if ((row + col < n - 1) || (col >= n + row))
                    {
                        Console.Write("-");
                    }
                    else
                    {
                        Console.Write("\u00A9");
                    }
                }
                    Console.WriteLine();
            }
        }
    }
}
