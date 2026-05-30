using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethodAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the MathOperation class
            MathOperation mathOp = new MathOperation();

            // Call the method by passing two integers normally
            mathOp.DoMath(10, 25);

            // Call the method again, this time specifying parameters by name
            mathOp.DoMath(firstNumber: 7, secondNumber: 99);

            // Pause the console so the user can read the output
            Console.WriteLine("Press Enter to exit...");
            Console.ReadLine();
        }
    }
}
