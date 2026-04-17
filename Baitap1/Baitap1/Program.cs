//Part 1 Print a string to the console
//hint: Console.WriteLine("Hello World!");

//Part 2 Get user input and print it to the console
//hint: Console.ReadLine();

//Part 3 Get two inputs from the user and print them on separate lines
//hint: use \n to create a new line

using System;

class Program
{
    static void Main(string[] args)
    {
        // Part 1: Print a string to the console
        Console.WriteLine("Hello World!");

        // Part 2: Get user input and print it
        Console.Write("Enter something: ");
        string input = Console.ReadLine();
        Console.WriteLine("You entered: " + input);

        // Part 3: Get two inputs and print on separate lines
        Console.Write("Enter first value: ");
        string first = Console.ReadLine();

        Console.Write("Enter second value: ");
        string second = Console.ReadLine();

        Console.WriteLine("Your inputs:\n" + first + "\n" + second);
    }
}