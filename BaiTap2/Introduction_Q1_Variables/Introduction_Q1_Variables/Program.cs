// To test out your code , comment the other parts and uncomment the part you want to test.
//To comment a part, select the part and press Ctrl + K + C
//To uncomment a part, select the part and press Ctrl + K + U
//Press Ctrl + F5 to run the code.



//---------------------------------------------------------------------
// Part 1: Create variables of different types, assign values to them, and print them to the console
// Hint: Use the Console.WriteLine() method to print the string to the console.
// Create variables of different types and assign values to them using a consistent naming convention.
// Use the following variable types: int, double, string, bool, char, byte, long, decimal, float.

// int variable
// Create an integer variable named 'enemy_health' and assign it the value 100.
// This variable type is used to store whole numbers.

// double variable
// Create a double variable named 'game_currency' and assign it the value 2500.50.
// This variable type is used to store decimal numbers.

// string variable
// Create a string variable named 'player_name' and assign it the value "John Doe".
// This variable type is used to store text.

// bool variable
// Create a boolean variable named 'isalive' and assign it the value true.
// This variable type is used to store true or false values.

// char variable
// Create a character variable named 'patrol_state' and assign it the value 'S' for "Standby".
// This variable type is used to store single characters.

// Byte variable
// Create a byte variable named 'player_age' and assign it the value 25.
// This variable type is used to store whole numbers from 0 to 255.

// Long variable
// Create a long variable named 'score' and assign it the value 1000000000.
// This variable type is used to store whole numbers.

// Decimal variable
// Create a decimal variable named 'price' and assign it the value 100.50.
// This variable type is used to store decimal numbers.

// Null variable
// Create a variable named 'null_variable' and assign it the value null.
// This variable type is used to store no value.

// Float variable
// Create a float variable named 'speed' and assign it the value 100.50.
// This variable type is used to store decimal numbers.

using System;
using System.Text;

class Program
{
    static void Main()
    {

        Console.OutputEncoding = Encoding.UTF8;
        int enemy_health = 100;
        double game_currency = 2500.50;
        string player_name = "John Doe";
        bool isalive = true;
        char patrol_state = 'S';
        byte player_age = 25;
        long score = 1000000000;
        decimal price = 100.50m;
        string null_variable = null;
        float speed = 100.50f;

        Console.WriteLine("Enemy Health: " + enemy_health);
        Console.WriteLine("Game Currency: " + game_currency);
        Console.WriteLine("Player Name: " + player_name);
        Console.WriteLine("Is Alive: " + isalive);
        Console.WriteLine("Patrol State: " + patrol_state);
        Console.WriteLine("Player Age: " + player_age);
        Console.WriteLine("Score: " + score);
        Console.WriteLine("Price: " + price);
        Console.WriteLine("Null Variable: " + null_variable);
        Console.WriteLine("Speed: " + speed);

        //---------------------------------------------------------------------

        // Part 17: Declaration of Constants
        // Write a C# program to declare a constant integer variable representing the value of Pi.
        // Hint: Use the const keyword to declare the constant.
        // Test data: const double Pi = 3.14159

        const double Pi = 3.14159;
        Console.WriteLine("Giá trị của Pi là: " + Pi);

        // Part 18: Declaration of Constants
        // Write a C# program to declare a constant string variable representing the name of a company.
        // Hint: Use the const keyword to declare the constant.
        // Test data: const string CompanyName = "ABC Corporation";

        const string CompanyName = "ABC Corporation";
        Console.WriteLine("Tên công ty là: " + CompanyName);


        // Part 19: Declaration of Constants
        // Write a C# program to declare a constant integer variable representing the maximum number of retries for a network request.
        // Hint: Use the const keyword to declare the constant.
        // Test data: const int MaxRetries = 3;

        const int MaxRetries = 3;
        Console.WriteLine("Số lần thử tối đa cho một yêu cầu mạng là: " + MaxRetries);

        // Part 20: Declaration of Constants
        // Write a C# program to declare a constant double variable representing the acceleration due to gravity.
        // Hint: Use the const keyword to declare the constant.
        // Test data: const double Gravity = 9.8;

        const double Gravity = 9.8;
        Console.WriteLine("Gia tốc do trọng lực là: " + Gravity);

        // Part 21: Declaration of Constants
        // Write a C# program to declare a constant integer variable representing the number of months in a year.
        // Hint: Use the const keyword to declare the constant.
        // Test data: const int MonthsInYear = 12;

        const int MonthsInYear = 12;
        Console.WriteLine("Số tháng trong một năm là: " + MonthsInYear);
    }
}

