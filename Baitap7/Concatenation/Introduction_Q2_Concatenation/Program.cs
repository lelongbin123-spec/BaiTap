// To test out your code , comment the other parts and uncomment the part you want to test.
//To comment a part, select the part and press Ctrl + K + C
//To uncomment a part, select the part and press Ctrl + K + U
//Press Ctrl + F5 to run the code.





//Part 1
//Write a C# program that concatenates two strings (player's first and last name) and then outputs the result.
//Hint: You can assign a string to a variable using the = operator.
//Hint: You can use the + operator to concatenate two strings.
//Hint: You can use the Console.WriteLine() method to output the result.

/*using System;

class Program
{
    static void Main()
    {
        string firstName = "John";
        string lastName = "Doe";

        string fullName = firstName + " " + lastName;

        Console.WriteLine("Player Name: " + fullName);
    }
}*/


//Part 2
//Modify the program so that it gets the two strings from the user(for username).
//Hint: You can use the Console.ReadLine() method to get a string from the user.
//Hint: You can use the Console.WriteLine() method to prompt the user for input.
//Hint: You can use the Console.WriteLine() method to output the result.


/*using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter first name: ");
        string firstName = Console.ReadLine();

        Console.Write("Enter last name: ");
        string lastName = Console.ReadLine();

        string fullName = firstName + " " + lastName;

        Console.WriteLine("Username: " + fullName);
    }
}*/


//Part 3
//Modify the program so that it concatenates three strings instead of two (clan name).
//Hint: You can use the + operator to concatenate three strings.
//Hint: You can use the Console.WriteLine() method to output the result.

/*using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter first name: ");
        string firstName = Console.ReadLine();

        Console.Write("Enter last name: ");
        string lastName = Console.ReadLine();

        Console.Write("Enter clan name: ");
        string clanName = Console.ReadLine();

        // Nối 3 chuỗi
        string fullName = firstName + " " + lastName + " [" + clanName + "]";

        Console.WriteLine("Username: " + fullName);
    }
}*/

//Part 4
//Modify the program to concatenate a string and an integer(incase,player name had numebrs).
//Hint: You can use the + operator to concatenate a string and an integer.
//Hint: You can use the Console.ReadLine() method to get an integer from the user.
//Hint: You can use the int.Parse() method to convert a string to an integer.
//Hint: You can use the Console.WriteLine() method to output the result.

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter player name: ");
        string name = Console.ReadLine();

        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        // Nối string + int
        string username = name + number;

        Console.WriteLine("Username: " + username);
    }
}





