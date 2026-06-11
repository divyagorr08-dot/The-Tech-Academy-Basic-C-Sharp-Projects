using System;
using System.IO;

namespace NumberLogger
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user for a number
            Console.WriteLine("Please enter a number:");

            // Read the user's input from the console
            string userInput = Console.ReadLine();

            // Define the file path where the number will be stored
            // This creates or overwrites a file named "log.txt" in the program folder
            string filePath = "log.txt";

            // Write the user's number to the text file
            // File.WriteAllText creates the file if it doesn't exist
            File.WriteAllText(filePath, userInput);

            // Read the contents of the text file back into the program
            string fileContents = File.ReadAllText(filePath);

            // Display the contents of the file to the user
            Console.WriteLine("The number you entered (read from the file) is:");
            Console.WriteLine(fileContents);

            // Pause the console so the user can see the output
            Console.WriteLine("Press Enter to exit...");
            Console.ReadLine();
        }
    }
}
