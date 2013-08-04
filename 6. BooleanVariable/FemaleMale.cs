using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.BooleanVariable
{
    class FemaleMale
    {
        static void Main(string[] args)
        {
            bool femaleMale;
            Console.WriteLine("What is your gender?");
            string gender = Console.ReadLine();
            if (gender == "female")
            {
                femaleMale = true;
            }
            else
            {
                femaleMale = false;
            }
            Console.WriteLine("You are female " + femaleMale);
        }
    }
}
