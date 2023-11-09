
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the value of n: ");

        // Read input from the console and parse it to an integer
        if (int.TryParse(Console.ReadLine(), out int n))
        {
            // Print the square
            PrintSquare(n);
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
    }

    static void PrintSquare(int n)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine(); // Move to the next line for the next row
        }
    }
}
