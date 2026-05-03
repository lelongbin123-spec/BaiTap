
//Part 1
// Use the Math class to calculate the minimum of two numbers.
// Hint: Use the Min method of the Math class.
// Test Data:
// Enter the first number: 5
// Enter the second number: 10
// Expected Output:
// The minimum of 5 and 10 is 5

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

        int min = Math.Min(a, b); // Tìm số nhỏ hơn

        Console.WriteLine($"The minimum of {a} and {b} is {min}");
    }
}*/


//Part 2
// Use the Math class to calculate the maximum of two numbers.
// Hint: Use the Max method of the Math class.
// Test Data:
// Enter the first number: 15
// Enter the second number: 8
// Expected Output:
// The maximum of 15 and 8 is 15

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

        int max = Math.Max(a, b); // Tìm số lớn hơn

        Console.WriteLine($"The maximum of {a} and {b} is {max}");
    }
}*/


//Part 3
// Use the Math class to calculate the square root of a number.
// Hint: Use the Sqrt method of the Math class.
// Test Data:
// Enter a number: 144
// Expected Output:
// The square root of 144 is 12

/*using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        Console.Write("Enter a number: ");
        double number = double.Parse(Console.ReadLine());

        double result = Math.Sqrt(number); // Tính căn bậc 2

        Console.WriteLine($"The square root of {number} is {result}");
    }
}*/


//Part 4
// Use the Math class to calculate the absolute value of a number.
// Hint: Use the Abs method of the Math class.
// Test Data:
// Enter a number: -5
// Expected Output:
// The absolute value of -5 is 5

/*using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int result = Math.Abs(number); // Giá trị tuyệt đối

        Console.WriteLine($"The absolute value of {number} is {result}");
    }
}*/

//Part 5
// Use the Math class to calculate the power of a number.
// Hint: Use the Pow method of the Math class.
// Test Data:
// Enter the base number: 2
// Enter the exponent: 5
// Expected Output:
// 2 raised to the power of 5 is 32

/*using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        Console.Write("Enter the base number: ");
        double baseNum = double.Parse(Console.ReadLine());

        Console.Write("Enter the exponent: ");
        double exponent = double.Parse(Console.ReadLine());

        double result = Math.Pow(baseNum, exponent); // Tính lũy thừa

        Console.WriteLine($"{baseNum} raised to the power of {exponent} is {result}");
    }
}*/

//Part 6
// Use the Math class to round a number to the nearest integer.
// Hint: Use the Round method of the Math class.
// Test Data:
// Enter a number: 4.6
// Expected Output:
// 4.6 rounded to the nearest integer is 5

/*using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        Console.Write("Enter a number: ");
        double number = double.Parse(Console.ReadLine());

        double result = Math.Round(number); // Làm tròn

        Console.WriteLine($"{number} rounded to the nearest integer is {result}");
    }
}*/

//Part 7
// Use the Math class to find the smallest integer greater than or equal to a number.
// Hint: Use the Ceiling method of the Math class.
// Test Data:
// Enter a number: 3.14
// Expected Output:
// The smallest integer greater than or equal to 3.14 is 4

/*using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        Console.Write("Enter a number: ");
        double number = double.Parse(Console.ReadLine());

        double result = Math.Ceiling(number); // Làm tròn lên

        Console.WriteLine($"The smallest integer greater than or equal to {number} is {result}");
    }
}*/

//Part 8
// Use the Math class to find the largest integer less than or equal to a number.
// Hint: Use the Floor method of the Math class.
// Test Data:
// Enter a number: 3.14
// Expected Output:
// The largest integer less than or equal to 3.14 is 3

/*using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        Console.Write("Enter a number: ");
        double number = double.Parse(Console.ReadLine());

        double result = Math.Floor(number); // Làm tròn xuống

        Console.WriteLine($"The largest integer less than or equal to {number} is {result}");
    }
}*/

//Part 9
// Use the Math class to calculate e raised to the power of a number.
// Hint: Use the Exp method of the Math class.
// Test Data:
// Enter a number: 2
// Expected Output:
// e raised to the power of 2 is 7.38905609893065

/*using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        Console.Write("Enter a number: ");
        double number = double.Parse(Console.ReadLine());

        double result = Math.Exp(number); // Tính e^x

        Console.WriteLine($"e raised to the power of {number} is {result}");
    }
}*/


//Part 10
// Use the Math class to calculate the natural logarithm of a number.
// Hint: Use the Log method of the Math class.
// Test Data:
// Enter a number: 100
// Expected Output:
// The natural logarithm of 100 is 4.60517018598809

/*using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        Console.Write("Enter a number: ");
        double number = double.Parse(Console.ReadLine());

        double result = Math.Log(number); // Tính ln(x)

        Console.WriteLine($"The natural logarithm of {number} is {result}");
    }
}*/

//Part 11
// Generate a random number between 1 and 100 using the Math class.
// Hint: Use the Random method of the Math class.
// Expected Output:
// A random number between 1 and 100 is 56

using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        Random rand = new Random(); // Tạo đối tượng Random

        int number = rand.Next(1, 101); // 1 đến 100

        Console.WriteLine($"A random number between 1 and 100 is {number}");
    }
}