using System;

namespace VoidMethodAssignment
{
    public class MathOperation
    {
        // This method takes two integers.
        // It performs a math operation on the first integer,
        // and displays the second integer to the screen.
        public void DoMath(int firstNumber, int secondNumber)
        {
            // Perform a simple math operation on the first number
            int result = firstNumber * 5;

            // Display the result of the math operation
            // Console.WriteLine("The result of the math operation on the first number is: " + result);

            // Display the second number as required
            Console.WriteLine("The second number you passed in is: " + secondNumber);
        }
    }
}
