using System;


namespace IfelseChallenges
{
   class Program
    {
        static void Main(string[] args)
        {
            if (true)
            {
                Console.WriteLine("Hello");
            }
            if(1==1)
            {
                Console.WriteLine("1 equals 1");
            }
            else
            {
                Console.WriteLine("1 does not equal 1");
            }
            string name = "Bett";
            if (name == "Alice")
            {
                Console.WriteLine("Hello Alice");
            }
            else if (name== "Bob")
            {
                Console.WriteLine("Hello Bob");
            }
            else
            {
                Console.WriteLine("You are not Alice. You are not Bob");
            }
            string color = "blue";
            if (color != "red")
            {
                Console.WriteLine("The color is not red");
            }
            else
            {
                Console.WriteLine("The color is red");
            }
            int age = 34;
            if(age>35) 
            {
                Console.WriteLine("You are over 35 years old");
            }
            else if (age >= 35) { 
                Console.WriteLine("You are 35 years old");
            }
            else if (age < 35) { 
                Console.WriteLine("You are under 35 years old");
            }
            else if (age < 20) { 
                Console.WriteLine("You are under 20 years old");
            }
            else
            {
                Console.WriteLine("You are 35 years old or younger");
            }


        }
    }
}
