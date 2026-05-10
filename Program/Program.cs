using System;

class Program
{
    static void Main()
    {
        // Display the required welcome message
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

        // Prompt the user for the package weight
        Console.WriteLine("Please enter the package weight:");
        float weight = float.Parse(Console.ReadLine());   // Convert input to a number

        // Check if the package is too heavy
        if (weight > 50)
        {
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            return;   // End the program immediately
        }

        // Prompt for package width
        Console.WriteLine("Please enter the package width:");
        float width = float.Parse(Console.ReadLine());

        // Prompt for package height
        Console.WriteLine("Please enter the package height:");
        float height = float.Parse(Console.ReadLine());

        // Prompt for package length
        Console.WriteLine("Please enter the package length:");
        float length = float.Parse(Console.ReadLine());

        // Check if the total dimensions exceed the limit
        if (width + height + length > 50)
        {
            Console.WriteLine("Package too big to be shipped via Package Express.");
            return;   // End the program immediately
        }

        // Calculate the shipping quote:
        // Multiply width × height × length × weight, then divide by 100
        float quote = (width * height * length * weight) / 100;

        // Display the final quote formatted as currency
        Console.WriteLine("Your estimated total for shipping this package is: $" + quote.ToString("0.00"));
        Console.WriteLine("Thank you!");
        Console.ReadLine();   // Wait for user input before closing the program
    }
}

