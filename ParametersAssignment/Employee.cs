using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersAssignment
{
    public class Employee<T>
    {
        // Property for the employee's ID (not generic)
        public int Id { get; set; }

        // Property for the employee's first name
        public string FirstName { get; set; }

        // Property for the employee's last name
        public string LastName { get; set; }

        // Create a property called "Things" that is a generic list
        // The type of the list matches the generic type parameter T
        public List<T> Things { get; set; }
    }
}
