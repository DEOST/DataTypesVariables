/*A marketing firm wants to keep record of its employees. 
 Each record would have the following characteristics – 
 first name, family name, age, gender (m or f), ID number, 
 unique employee number (27560000 to 27569999). 
 Declare the variables needed to keep the information for a single 
 employee using appropriate data types and descriptive names.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.FirmRecords
{
    class FirmRecords
    {
        static void Main()
        {
            Console.WriteLine("Type your First Name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Type your Family Name: ");
            string familyName = Console.ReadLine();
            Console.WriteLine("Type your age: ");
            byte age = byte.Parse(Console.ReadLine());
            Console.WriteLine("Type your gender (m/f): ");
            string maleFemale = Console.ReadLine();
            Console.WriteLine("Type your ID number: ");
            int idNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Type your employee number (27560000 to 27569999): ");
            Console.WriteLine("Type your employee number (27560000 to 27569999): ");
            int employeeNumber = int.Parse(Console.ReadLine());
            if ((employeeNumber < 27560000) || (employeeNumber > 27569999))
            {
                while ((employeeNumber < 27560000) || (employeeNumber > 27569999))
                {
                    Console.WriteLine("Type correct number (27560000 to 27569999): ");
                    employeeNumber = int.Parse(Console.ReadLine());
                }
            }
            else
            {
            }
            Console.WriteLine("{0} {1}, \n age - {2}, gender: {3} \n ID: {4}, \n employee number: {5}", 
                firstName, familyName, age, maleFemale, idNumber, employeeNumber); 
        }
    }
}