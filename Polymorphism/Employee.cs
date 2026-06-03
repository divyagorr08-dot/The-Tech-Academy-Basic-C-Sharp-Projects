using System;


namespace Polymorphism
{
    public class Employee : IQuittable
    {
        // Properties to identify the employee.
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // This method is required by the IQuittable interface.
        // It defines what happens when an employee "quits".
        public void Quit()
        {
            Console.WriteLine($"{FirstName} {LastName} has quit the company.");
        }
    }
}
