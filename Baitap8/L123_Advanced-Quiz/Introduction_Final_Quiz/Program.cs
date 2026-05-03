// To test out your code , comment the other parts and uncomment the part you want to test.
//To comment a part, select the part and press Ctrl + K + C
//To uncomment a part, select the part and press Ctrl + K + U
//Press Ctrl + F5 to run the code.

//////////////5 Syntax Example Questions://///////////



//Part 1

//Declare an integer variable named "num" and assign it the value 10. Print the value of "num" to the console.
//Hint: Use the Console.WriteLine() method to print the value of "num".
//Test Data:
//Expected Output:
//The value of num is: 10

/*using System;

class Program
{
    static void Main()
    {
        int num = 10; // Khai báo và gán giá trị

        Console.WriteLine("The value of num is: " + num);
    }
}*/

//Part 2

//Concatenate two strings, "firstName" and "lastName", and print the result.
//Hint: Use the + operator to concatenate strings and the Console.WriteLine() method to print the result.
//Test Data:
//firstName = "John"
//lastName = "Doe"
//Expected Output:
//The full name is: John Doe

/*using System;

class Program
{
    static void Main()
    {
        string firstName = "John";
        string lastName = "Doe";

        string fullName = firstName + " " + lastName; // nối chuỗi

        Console.WriteLine("The full name is: " + fullName);
    }
}*/


//Part 3

//Get the user's age as input and print it to the console.
//Hint: Use the Console.ReadLine() method to get the user's input and the Console.WriteLine() method to print the result.
//Test Data:
//Enter your age: 25
//Expected Output:
//Your age is: 25

/*using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        Console.Write("Enter your age: ");
        string age = Console.ReadLine(); // Nhập dữ liệu

        Console.WriteLine("Your age is: " + age);
    }
}*/


//Part 4

//Calculate the sum of two integers, 5 and 7, and print the result.
//Hint: Use the + operator to add integers and the Console.WriteLine() method to print the result.
//Test Data:
//Expected Output:
//The sum of 5 and 7 is: 12

/*using System;

class Program
{
    static void Main()
    {
        int a = 5;
        int b = 7;

        int sum = a + b; // Tính tổng

        Console.WriteLine("The sum of 5 and 7 is: " + sum);
    }
}*/


//Part 5

//Convert the temperature from Celsius to Fahrenheit. Given Celsius value = 25, print the Fahrenheit equivalent.
//Hint: Use the formula (Celsius * 9/5) + 32 to convert Celsius to Fahrenheit and the Console.WriteLine() method to print the result.
//Test Data:
//Celsius temperature: 25
//Expected Output:
//The Fahrenheit equivalent is: 77

/*using System;

class Program
{
    static void Main()
    {
        double celsius = 25;

        double fahrenheit = (celsius * 9 / 5) + 32; // Công thức đổi

        Console.WriteLine("The Fahrenheit equivalent is: " + fahrenheit);
    }
}*/



//////////////5 Questions with Game Context://////////////////





//Part 6

//In a game, declare an integer variable named "playerHealth" and set it to 100. Print the player's health.
//Hint: Use the Console.WriteLine() method to print the value of "playerHealth".
//Test Data:
//Expected Output:
//Player's health: 100

/*using System;

class Program
{
    static void Main()
    {
        int playerHealth = 100; // Khai báo và gán giá trị

        Console.WriteLine("Player's health: " + playerHealth);
    }
}*/


//Part 7

//Get the player's name as input and concatenate it with the game's title. Print the result.
//Hint: Use the Console.ReadLine() method to get the player's name, concatenate it with the game's title using the + operator, and print the result using the Console.WriteLine() method.
//Test Data:
//Enter your name: Alice
//Expected Output:
//Welcome to the game, Alice!

/*using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        Console.Write("Enter your name: ");
        string playerName = Console.ReadLine(); // Nhập tên

        string message = "Welcome to the game, " + playerName + "!";

        Console.WriteLine(message);
    }
}*/

//Part 8

//Calculate the area of a rectangular movement space in a game. Given length = 10 and width = 5, print the area.
//Hint: Use the formula area = length * width and the Console.WriteLine() method to print the result.
//Test Data:
//Length: 10
//Width: 5
//Expected Output:
//The area of the rectangular movement space is: 50


/*using System;

class Program
{
    static void Main()
    {
        int length = 10;
        int width = 5;

        int area = length * width; // Tính diện tích

        Console.WriteLine("The area of the rectangular movement space is: " + area);
    }
}*/


//Part 9


//In a game, the player's level is stored as a string (e.g., "Level 5"), but you need to extract the numeric part to perform calculations. Convert the player's level from a string to an integer and print the result.

//Test Data
//Player's Level: Level 10
//Player's Level as an integer: 10

/*using System;

class Program
{
    static void Main()
    {
        string level = "Level 10";

        // Tách phần số
        string numberPart = level.Replace("Level ", "");

        // Chuyển sang số nguyên
        int levelNumber = int.Parse(numberPart);

        Console.WriteLine("Player's Level as an integer: " + levelNumber);
    }
}*/


//Part 10

//In a game, calculate the total score. Given points for killing an enemy = 100 and points for collecting a bonus = 50, print the total score.
//Hint: Add the points together and use the Console.WriteLine() method to print the total score.
//Test Data:
//Expected Output:
//The total score is: 150


/*using System;

class Program
{
    static void Main()
    {
        int enemyPoints = 100;
        int bonusPoints = 50;

        int totalScore = enemyPoints + bonusPoints; // Tính tổng điểm

        Console.WriteLine("The total score is: " + totalScore);
    }
}*/


//////////////////5 Harder Questions://///////////////





//Part 11

//In this C# program, we will take the input string from the user and change it to 1)Upper Case 2)Lower Case 3)Title Case.

//Test Data:
//Enter the string: welcome to the world of C#
//Expected Output:
//The string in upper case: WELCOME TO THE WORLD OF C#
//The string in lower case: welcome to the world of c#
//The string in title case: Welcome To The World Of C#

/*using System;
using System.Globalization;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        Console.Write("Enter the string: ");
        string input = Console.ReadLine();

        // Upper case
        string upper = input.ToUpper();

        // Lower case
        string lower = input.ToLower();

        // Title case
        TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
        string title = textInfo.ToTitleCase(input.ToLower());

        Console.WriteLine("The string in upper case: " + upper);
        Console.WriteLine("The string in lower case: " + lower);
        Console.WriteLine("The string in title case: " + title);
    }
}*/



//Part 12

//Calculate the compound interest for a game currency. Given principal amount = 1000, interest rate = 5%, and time period = 3 years, print the compound interest.
//Hint: Use the formula compoundInterest = principalAmount * (1 + interestRate/100)^timePeriod - principalAmount and the Console.WriteLine() method to print the result.
//Test Data:
//Enter the principal amount: 1000
//Enter the interest rate: 5
//Enter the time period: 3
//Expected Output:
//The compound interest is: 157.63

/*using System;

class Program
{
    static void Main()
    {
        double principal = 1000;
        double rate = 5;
        double time = 3;

        double compoundInterest = principal * Math.Pow((1 + rate / 100), time) - principal;

        Console.WriteLine("The compound interest is: " + compoundInterest.ToString("F2"));
    }
}*/


//Part 13

// Write a  program to swap two numbers.
//Given numbers = 5 and 10, swap them and print the result.
//Hint: Use a temporary variable to swap the numbers and the Console.WriteLine() method to print the result.
//Test Data:
//Enter the first number: 5
//Enter the second number: 10
//Expected Output:
//After swapping:
//First number: 10
//Second number: 5

/*using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        Console.Write("Enter the first number: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int b = int.Parse(Console.ReadLine());

        // Hoán đổi
        int temp = a;
        a = b;
        b = temp;

        Console.WriteLine("After swapping:");
        Console.WriteLine("First number: " + a);
        Console.WriteLine("Second number: " + b);
    }
}*/


//Part 14
//Write a C# program to find the largest of three numbers.
//Test Data:
//Enter the first number: 25
//Enter the second number: 78
//Enter the third number: 87
//Expected Output:
//The 3 numbers are: 25 78 87
//The greatest number is: 87

/*using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        Console.Write("Enter the first number: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("Enter the third number: ");
        int c = int.Parse(Console.ReadLine());

        int max = a;

        if (b > max)
            max = b;

        if (c > max)
            max = c;

        Console.WriteLine($"The 3 numbers are: {a} {b} {c}");
        Console.WriteLine($"The greatest number is: {max}");
    }
}*/



//Part 15

//Determine the greatest common divisor (GCD) of two numbers. Given numbers = 12 and 18, print their GCD.
//Hint: Use the Euclidean algorithm to find the GCD and the Console.WriteLine() method to print the result.
//Test Data:
//Enter the first number: 12
//Enter the second number: 18
//Expected Output:
//The GCD of 12 and 18 is: 6

/*using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        Console.Write("Enter the first number: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int b = int.Parse(Console.ReadLine());

        int gcd = FindGCD(a, b);

        Console.WriteLine($"The GCD of {a} and {b} is: {gcd}");
    }

    static int FindGCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b; // lấy phần dư
            a = temp;
        }
        return a;
    }
}*/





////////////5 Even Harder Questions://///////////////




//Part 16

//Write a program to calculate the volume of a sphere. Given radius = 3, print the volume.
//Hint: Use the formula volume = (4/3) * π * radius^3 and the Console.WriteLine() method to print the result.
//Test Data:
//Enter the radius of the sphere: 3
//Expected Output:
//The volume of the sphere is: 113.09733552923255

/*using System;

class Program
{
    static void Main()
    {
        double radius = 3;

        double volume = (4.0 / 3) * Math.PI * Math.Pow(radius, 3);

        Console.WriteLine("The volume of the sphere is: " + volume);
    }
}*/


//Part 17

//Find the index of a character in a string starting from a specified position. Given string = "hello world", character = 'o', starting position = 5, print the index.
//Hint: Use the IndexOf() method with the starting position parameter and the Console.WriteLine() method to print the index.
//Test Data:
//Enter the string: hello world
//Enter the character to find: o
//Enter the starting position: 5
//Expected Output:
//The index of 'o' starting from position 5 is: 7

/*using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        Console.Write("Enter the string: ");
        string text = Console.ReadLine();

        Console.Write("Enter the character to find: ");
        char ch = char.Parse(Console.ReadLine());

        Console.Write("Enter the starting position: ");
        int start = int.Parse(Console.ReadLine());

        int index = text.IndexOf(ch, start);

        Console.WriteLine($"The index of '{ch}' starting from position {start} is: {index}");
    }
}*/


//Part 18

//Remove a specific character from a string. Given string = "apple", remove the character 'p' and print the result.
//Hint: Use the Remove() method to remove the character and the Console.WriteLine() method to print the result.
//Test Data:
//Enter the string: apple
//Enter the character to remove: p
//Expected Output:
//The string after removing 'p' is: ale

/*using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        Console.Write("Enter the string: ");
        string text = Console.ReadLine();

        Console.Write("Enter the character to remove: ");
        char ch = char.Parse(Console.ReadLine());

        string result = text.Replace(ch.ToString(), ""); // Xóa tất cả ký tự

        Console.WriteLine($"The string after removing '{ch}' is: {result}");
    }
}*/


//Part 19

//Replace all occurrences of a character in a string with another character. Given string = "banana", replace 'a' with 'o' and print the result.
//Hint: Use the Replace() method to replace the character and the Console.WriteLine() method to print the result.
//Test Data:
//Enter the string: banana
//Enter the character to replace: a
//Enter the character to replace with: o
//Expected Output:
//The string after replacing 'a' with 'o' is: bonono

/*using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        Console.Write("Enter the string: ");
        string text = Console.ReadLine();

        Console.Write("Enter the character to replace: ");
        char oldChar = char.Parse(Console.ReadLine());

        Console.Write("Enter the character to replace with: ");
        char newChar = char.Parse(Console.ReadLine());

        string result = text.Replace(oldChar, newChar);

        Console.WriteLine($"The string after replacing '{oldChar}' with '{newChar}' is: {result}");
    }
}*/


//Part 20

//Extract a substring from a string. Given string = "hello world", extract the substring from index 3 to 7 and print the result
//Hint: Use the Substring() method with the start index and length parameters and the Console.WriteLine() method to print the result.
//Test Data:
//Enter the string: hello world
//Enter the start index: 3
//Enter the end index: 7
//Expected Output:
//The substring from index 3 to 7 is: lo w

using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        Console.Write("Enter the string: ");
        string text = Console.ReadLine();

        Console.Write("Enter the start index: ");
        int start = int.Parse(Console.ReadLine());

        Console.Write("Enter the end index: ");
        int end = int.Parse(Console.ReadLine());

        int length = end - start;

        string result = text.Substring(start, length);

        Console.WriteLine($"The substring from index {start} to {end} is: {result}");
    }
}

