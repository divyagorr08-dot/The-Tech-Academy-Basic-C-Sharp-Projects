using System;


namespace OperatorOverloadAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the first Employee object and assign values
            Employee emp1 = new Employee()
            {
                Id = 101,
                FirstName = "John",
                LastName = "Doe"
            };

            // Instantiate the second Employee object and assign values
            Employee emp2 = new Employee()
            {
                Id = 101,   // Same Id as emp1 to test equality
                FirstName = "Jane",
                LastName = "Smith"
            };

            // Compare the two Employee objects using the overloaded == operator
            bool areEqual = emp1 == emp2;

            // Display the comparison result
            Console.WriteLine("Are the two employees equal? " + areEqual);

            // Compare using the overloaded != operator
            bool areNotEqual = emp1 != emp2;

            // Display the comparison result
            Console.WriteLine("Are the two employees NOT equal? " + areNotEqual);

            Console.ReadLine();
        }
    }
}
