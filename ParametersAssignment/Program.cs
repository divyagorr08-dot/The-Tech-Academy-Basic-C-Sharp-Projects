using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate an Employee object using "string" as the generic type
            Employee<string> stringEmployee = new Employee<string>()
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe",
                // Assign a list of strings to the Things property
                Things = new List<string>() { "Laptop", "Notebook", "Pen" }
            };

            // Instantiate an Employee object using "int" as the generic type
            Employee<int> intEmployee = new Employee<int>()
            {
                Id = 2,
                FirstName = "Sarah",
                LastName = "Connor",
                // Assign a list of integers to the Things property
                Things = new List<int>() { 10, 20, 30, 40 }
            };

            // Loop through the stringEmployee Things list and print each item
            Console.WriteLine("String Employee Things:");
            foreach (string item in stringEmployee.Things)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(); // Blank line for readability

            // Loop through the intEmployee Things list and print each item
            Console.WriteLine("Int Employee Things:");
            foreach (int number in intEmployee.Things)
            {
                Console.WriteLine(number);
            }

            // Keep console window open
            Console.ReadLine();
        }
    }
}
