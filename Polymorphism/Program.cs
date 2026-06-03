using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an Employee object and set its properties.
            Employee employee = new Employee()
            {
                FirstName = "John",
                LastName = "Doe"
            };

            // POLYMORPHISM:
            // Create an object of type IQuittable and assign the Employee object to it.
            // This works because Employee implements the IQuittable interface.
            IQuittable quittableEmployee = employee;

            // Call the Quit() method using the interface type.
            // This demonstrates polymorphism in action.
            quittableEmployee.Quit();

            // Pause the console so the user can see the output.
            Console.ReadLine();
        }
    }
}
