using System;


namespace MathOperationsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to multiply by 50:");
            string input1 = Console.ReadLine();

            long number1 = Convert.ToInt64(input1);

            long result1 = number1 * 50;

            Console.WriteLine("Result of multiplying by 50: " + result1);
            Console.WriteLine(); 



            Console.WriteLine("Enter a number to add 25 to:");
            string input2 = Console.ReadLine();

            int number2 = Convert.ToInt32(input2);

           
            int result2 = number2 + 25;

            System.Console.WriteLine("Result after adding 25: " + result2);
            Console.WriteLine();


            

            Console.WriteLine("Enter a number to divide by 12.5:");
            string input3 = Console.ReadLine();

            double number3 = Convert.ToDouble(input3);

            
            double result3 = number3 / 12.5;

          
            Console.WriteLine("Result of division: " + result3);
            Console.WriteLine();



            Console.WriteLine("Enter a number to check if it's greater than 50:");
            string input4 = Console.ReadLine();

            int number4 = Convert.ToInt32(input4);

            bool isGreater = number4 > 50;

            Console.WriteLine("Is the number greater than 50? " + isGreater);
            Console.WriteLine();


       

            Console.WriteLine("Enter a number to divide by 7:");
            string input5 = Console.ReadLine();

            int number5 = Convert.ToInt32(input5);

         
            int remainder = number5 % 7;

            Console.WriteLine("Remainder when divided by 7: " + remainder);
            Console.WriteLine();


            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
