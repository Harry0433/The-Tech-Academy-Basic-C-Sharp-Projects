using System;

class Program
{
    static void Main()
    {
        // Display welcome message to the user
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

        // Prompt user for package weight
        Console.WriteLine("Please enter the package weight:");
        int weight = Convert.ToInt32(Console.ReadLine());

        // Check if weight exceeds limit
        if (weight > 50)
        {
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            return; // Ends the program
        }

        // Prompt user for package width
        Console.WriteLine("Please enter the package width:");
        int width = Convert.ToInt32(Console.ReadLine());

        // Prompt user for package height
        Console.WriteLine("Please enter the package height:");
        int height = Convert.ToInt32(Console.ReadLine());

        // Prompt user for package length
        Console.WriteLine("Please enter the package length:");
        int length = Convert.ToInt32(Console.ReadLine());

        // Check if total dimensions exceed limit
        if (width + height + length > 50)
        {
            Console.WriteLine("Package too big to be shipped via Package Express.");
            return; // Ends the program
        }

        // Calculate shipping quote: (height * width * length * weight) / 100
        int volume = width * height * length; // Calculate volume of the package
        int quote = (volume * weight) / 100; // Apply formula to get shipping cost

        // Display quote to the user formatted as currency
        Console.WriteLine("Your estimated total for shipping this package is: $" + quote + ".00");
        Console.WriteLine("Thank you!");
    }
}
