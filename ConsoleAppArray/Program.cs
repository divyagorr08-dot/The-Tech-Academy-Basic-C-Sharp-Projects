using System;
using System.Collections.Generic;

namespace ConsoleAppArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] colorArray = {"Red", "Green", "Blue", "Yellow", "Purple", "Orange", "Pink", "Brown", "Black", "White" };
            Console.WriteLine("Select a number between 0 and 9");
            int stringSelect = Convert.ToInt32(Console.ReadLine());
            bool validString = false;

            while(!validString)
            {
                try
                {
                    Console.WriteLine("Your favorite color is: " + colorArray[stringSelect]);
                    validString = true;

                }
                catch
                {
                    Console.WriteLine("Sorry, that number selection is invalid. Please select a number between 0 and 9.");
                    stringSelect = Convert.ToInt32(Console.ReadLine());
                }
            }
            List<string> occupationList = new List<string>()
            {
                "Data Analyst",
                "Software Engineer",
                "Project Manager",
                "Graphic Designer",
                "Marketing Specialist"

            };
            Console.WriteLine("Select a number between 0 and 9:");
            int listSelect = Convert.ToInt32(Console.ReadLine());
            bool validList = false;

            while (!validList)
            {
                try
                {
                    Console.WriteLine("Your new occupation is: " + occupationList[listSelect]);
                    validList = true;

                }
                catch
                {
                    Console.WriteLine("Sorry, that number selection is invalid. Please select a number between 0 and 9.");
                    listSelect = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
    }
}
