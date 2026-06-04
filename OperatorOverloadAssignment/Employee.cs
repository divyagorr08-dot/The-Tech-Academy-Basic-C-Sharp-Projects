using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloadAssignment
{
    public class Employee
    {
        // Property for the employee's unique Id
        public int Id { get; set; }

        // Property for the employee's first name
        public string FirstName { get; set; }

        // Property for the employee's last name
        public string LastName { get; set; }

        // Overload the == operator to compare two Employee objects by Id
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            // Handle null cases to avoid exceptions
            if (ReferenceEquals(emp1, null) && ReferenceEquals(emp2, null))
                return true;

            if (ReferenceEquals(emp1, null) || ReferenceEquals(emp2, null))
                return false;

            // Compare Id values
            return emp1.Id == emp2.Id;
        }

        // Overload the != operator (must be paired with ==)
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            return !(emp1 == emp2);
        }

        
    }
}
