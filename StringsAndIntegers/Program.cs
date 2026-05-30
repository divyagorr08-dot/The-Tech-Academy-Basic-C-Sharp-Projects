using System;
using System.Collections.Generic;


namespace StringsAndIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> intList = new List<int>() { 5, 99, 23, 10, 185, 22, 12, 2994, 101, 77000 };
            bool numValid = false;
            while (!numValid)
            {
                try
                {
                    Console.WriteLine("\nEnter a number to divide each number in the list by:");
                    float numDivide = float.Parse(Console.ReadLine());
                    if ((numDivide == 0))
                    {
                        Console.WriteLine("Please enter a number other than 0.");

                    }
                    else
                    {
                        foreach(int num in intList)
                        {
                            float Divide = num / numDivide;
                            Console.WriteLine(num + "/" +numDivide + "=" + Divide);
                        }
                        numValid = true;
                    }
                }
                catch(FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
            }
            Console.WriteLine("The program has exited the try/catch block");

        }
    }
}
