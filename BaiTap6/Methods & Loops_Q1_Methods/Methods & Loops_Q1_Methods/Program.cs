//---------------------------------------------------------------------
// Part 1: Displaying a Welcome Message
// Create a user-defined function to display a welcome message.
// Hint: Define a function named DisplayWelcomeMessage() that prints the welcome message to the console.

/*using System;

class Program
{
    static void Main()
    {
        // Gọi hàm
        DisplayWelcomeMessage();
    }

    // Định nghĩa hàm
    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the application!");
    }
}*/

//---------------------------------------------------------------------
// Part 2: Personalized Welcome Message
// Create a user-defined function with parameters to personalize a welcome message.
// Hint: Define a function named PersonalizedWelcomeMessage() that takes a name as a parameter and prints a personalized welcome message to the console.

/*using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        // Gọi hàm và truyền tham số
        PersonalizedWelcomeMessage(name);
    }

    // Hàm có tham số
    static void PersonalizedWelcomeMessage(string name)
    {
        Console.WriteLine($"Hello, {name}! Welcome to the application 🎉");
    }
}*/

//---------------------------------------------------------------------
// Part 3: Calculating the Sum of Two Numbers
// Create a user-defined function to calculate the sum of two numbers.
// Hint: Define a function named CalculateSum() that takes two parameters, adds them, and returns the result.

/*using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        // Gọi hàm và nhận kết quả
        int result = CalculateSum(num1, num2);

        Console.WriteLine("Sum: " + result);
    }

    // Hàm trả về giá trị
    static int CalculateSum(int a, int b)
    {
        return a + b;
    }
}*/

//---------------------------------------------------------------------
// Part 4: Counting Spaces in a String
// Create a user-defined function to count the number of spaces in a string.
// Hint: Define a function named CountSpaces() that takes a string as a parameter, counts the number of spaces, and returns the count.

/*using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a sentence: ");
        string input = Console.ReadLine();

        int spaceCount = CountSpaces(input);

        Console.WriteLine("Number of spaces: " + spaceCount);
    }

    // Hàm đếm khoảng trắng
    static int CountSpaces(string text)
    {
        int count = 0;

        foreach (char c in text)
        {
            if (c == ' ')
            {
                count++;
            }
        }

        return count;
    }
}*/

//---------------------------------------------------------------------
// Part 5: Calculating the Sum of Elements in an Array
// Create a user-defined function to calculate the sum of elements in an array.
// Hint: Define a function named CalculateArraySum() that takes an array as a parameter, calculates the sum of its elements, and returns the sum.

/*using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 10, 20, 30, 40, 50 };

        int sum = CalculateArraySum(numbers);

        Console.WriteLine("Array Sum: " + sum);
    }

    // Hàm tính tổng mảng
    static int CalculateArraySum(int[] arr)
    {
        int total = 0;

        foreach (int num in arr)
        {
            total += num;
        }

        return total;
    }
}*/

//---------------------------------------------------------------------
// Part 6: Swapping Two Integer Numbers
// Create a user-defined function to swap two integer numbers.
// Hint: Define a function named SwapNumbers() that takes two integer parameters, swaps their values, and prints the updated values to the console.

/*using System;

class Program
{
    static void Main()
    {
        int a = 5;
        int b = 10;

        Console.WriteLine($"Before swap: a = {a}, b = {b}");

        SwapNumbers(ref a, ref b);

        Console.WriteLine($"After swap: a = {a}, b = {b}");
    }

    // Hàm swap dùng ref
    static void SwapNumbers(ref int x, ref int y)
    {
        int temp = x;
        x = y;
        y = temp;

        Console.WriteLine($"Inside function: x = {x}, y = {y}");
    }
}*/

//---------------------------------------------------------------------
// Part 7: Calculating Exponentiation
// Create a user-defined function to calculate the result of raising an integer number to another.
// Hint: Define a function named CalculateExponent() that takes two integer parameters (base and exponent), calculates the result, and prints it to the console.

/*using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter base: ");
        int baseNum = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter exponent: ");
        int exponent = Convert.ToInt32(Console.ReadLine());

        CalculateExponent(baseNum, exponent);
    }

    // Hàm tính lũy thừa
    static void CalculateExponent(int baseNum, int exponent)
    {
        int result = 1;

        for (int i = 0; i < exponent; i++)
        {
            result *= baseNum;
        }

        Console.WriteLine($"{baseNum}^{exponent} = {result}");
    }
}*/

//---------------------------------------------------------------------
// Part 8: Displaying the Fibonacci Sequence
// Create a user-defined function to display the Fibonacci sequence up to a specified number of terms.
// Hint: Define a function named DisplayFibonacciSequence() that takes an integer parameter (number of terms), calculates and prints the Fibonacci sequence to the console.

/*using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter number of terms: ");
        int n = Convert.ToInt32(Console.ReadLine());

        DisplayFibonacciSequence(n);
    }

    // Hàm hiển thị Fibonacci
    static void DisplayFibonacciSequence(int n)
    {
        int a = 0, b = 1;

        Console.Write("Fibonacci: ");

        for (int i = 0; i < n; i++)
        {
            Console.Write(a + " ");

            int next = a + b;
            a = b;
            b = next;
        }
    }
}*/

//---------------------------------------------------------------------
// Part 9: Checking Prime Numbers
// Create a user-defined function to check whether a number is prime or not.
// Hint: Define a function named CheckPrimeNumber() that takes an integer parameter, checks if it's prime, and prints the result to the console.

/*using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        CheckPrimeNumber(number);
    }

    // Hàm kiểm tra số nguyên tố
    static void CheckPrimeNumber(int n)
    {
        if (n <= 1)
        {
            Console.WriteLine($"{n} is NOT a prime number.");
            return;
        }

        bool isPrime = true;

        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
            {
                isPrime = false;
                break;
            }
        }

        if (isPrime)
            Console.WriteLine($"{n} is a prime number");
        else
            Console.WriteLine($"{n} is NOT a prime number");
    }
}*/

//---------------------------------------------------------------------
// Part 10: Calculating the Sum of Individual Digits
// Create a user-defined function to calculate the sum of individual digits of a given number.
// Hint: Define a function named CalculateDigitSum() that takes an integer parameter, calculates the sum of its digits, and prints the result to the console.

/*using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        CalculateDigitSum(number);
    }

    // Hàm tính tổng chữ số
    static void CalculateDigitSum(int n)
    {
        int sum = 0;

        n = Math.Abs(n); // xử lý số âm

        while (n > 0)
        {
            int digit = n % 10; // lấy chữ số cuối
            sum += digit;
            n /= 10; // bỏ chữ số cuối
        }

        Console.WriteLine("Sum of digits: " + sum);
    }
}*/

//---------------------------------------------------------------------
// Part 11: Testing Named Parameters in C#
// Write a C# program that defines a method called "DisplayInfo" that takes two parameters: "name" and "age".
// Use named parameters to call the "DisplayInfo" method with the parameter values "name"="John" and "age"=30.
// Hint: Define the method "DisplayInfo" with parameters "name" and "age", then call it using named parameters.

/*using System;

class Program
{
    static void Main()
    {
        // Gọi hàm bằng named parameters
        DisplayInfo(name: "John", age: 30);
    }

    // Định nghĩa hàm
    static void DisplayInfo(string name, int age)
    {
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Age: {age}");
    }
}*/

//---------------------------------------------------------------------
// Part 12: Testing Out Parameters in C#
// Write a C# program that defines a method called "GetSquareRoot" that calculates the square root of a number.
// Use an out parameter to return the square root of a given number.
// Hint: Define the method "GetSquareRoot" with an out parameter to store the result.

/*using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        double number = Convert.ToDouble(Console.ReadLine());

        // Khai báo biến nhận kết quả
        double result;

        // Gọi hàm với out
        GetSquareRoot(number, out result);

        Console.WriteLine("Square root: " + result);
    }

    // Hàm dùng out parameter
    static void GetSquareRoot(double num, out double sqrt)
    {
        sqrt = Math.Sqrt(num);
    }
}*/

//---------------------------------------------------------------------
// Part 13: Testing Default or Optional Parameters in C#
// Write a C# program that defines a method called "GreetUser" with two parameters: "name" and "greetingMessage".
// Set the default value of "greetingMessage" to "Hello".
// Call the "GreetUser" method with only the "name" parameter provided.
// Hint: Define the method "GreetUser" with a default value for one of its parameters.

using System;

class Program
{
    static void Main()
    {
        // Chỉ truyền name
        GreetUser("John");
    }

    // Hàm có optional parameter
    static void GreetUser(string name, string greetingMessage = "Hello")
    {
        Console.WriteLine($"{greetingMessage}, {name}!");
    }
}