// To test out your code , comment the other parts and uncomment the part you want to test.
//To comment a part, select the part and press Ctrl + K + C
//To uncomment a part, select the part and press Ctrl + K + U
//Press Ctrl + F5 to run the code.
/*using System;
using System.Text;

class Program
{
    static void Main()
    {

        Console.OutputEncoding = Encoding.UTF8;

        int num1 = 10;
        int num2 = 5;
        //---------------------------------------------------------------------
        // Part 1: Mathematical Operators
        // Write a C# program to print the sum of two numbers.
        // Hint: You can use the + operator to add two numbers.
        // Test data: int num1 = 10, int num2 = 5



        int sum = num1 + num2;

        Console.WriteLine("Tổng của hai số là: " + sum);


        //---------------------------------------------------------------------
        // Part 2: Mathematical Operators
        // Write a C# program to print the difference between two numbers.
        // Hint: You can use the - operator to subtract two numbers.
        // Test data: int num1 = 10, int num2 = 5

        int difference = num1 - num2;
        Console.WriteLine("Hiệu của hai số là: " + difference);


        //---------------------------------------------------------------------
        // Part 3: Mathematical Operators
        // Write a C# program to print the product of two numbers.
        // Hint: You can use the * operator to multiply two numbers.
        // Test data: int num1 = 10, int num2 = 5

        int product = num1 * num2;
        Console.WriteLine("Tích của hai số là: " + product);

        //---------------------------------------------------------------------
        // Part 4: Mathematical Operators
        // Write a C# program to print the division of two numbers.
        // Hint: You can use the / operator to divide two numbers.
        // Test data: int num1 = 10, int num2 = 5

        int division = num1 / num2;
        Console.WriteLine("Thương của hai số là: " + division);

        //---------------------------------------------------------------------
        // Part 5: Mathematical Operators
        // Write a C# program to print the remainder of two numbers.
        // Hint: You can use the % operator to find the remainder of two numbers.
        // Test data: int num1 = 10, int num2 = 5
        int remainder = num1 % num2;
        Console.WriteLine("Số dư của hai số là: " + remainder);

        //---------------------------------------------------------------------
        // Part 6: Mathematical Operators
        // Write a C# program to calculate the square of a number.
        // Hint: You can use the * operator to multiply a number by itself.
        // Test data: int num = 5
        int num = 5;
        int square = num * num;
        Console.WriteLine("Bình phương của số là: " + square);


        //---------------------------------------------------------------------
        // Part 7: Mathematical Operators
        // Write a C# program to calculate the average of two numbers.
        // Hint: You can add the two numbers together and then divide the sum by 2 to find the average.
        // Test data: int num1 = 10, int num2 = 20
        num1 = 10;
        num2 = 20;
        double average = (num1 + num2) / 2.0;
        Console.WriteLine("Trung bình của hai số là: " + average);


        //---------------------------------------------------------------------
        // Part 8: Mathematical Operators
        // Write a C# program to calculate the average of three numbers.
        // Hint: You can add the three numbers together and then divide the sum by 3 to find the average.
        // Test data: int num1 = 10, int num2 = 20, int num3 = 30
        num1 = 10;
        num2 = 20;
        int num3 = 30;
        average = (num1 + num2 + num3) / 3.0;
        Console.WriteLine("Trung bình của ba số là: " + average);


        //---------------------------------------------------------------------
        // Part 9: Mathematical Operators
        // Write a C# program to convert temperature from Celsius to Fahrenheit.
        // Hint: Use the formula (Celsius * 9/5) + 32.
        // Test data: double celsius = 20

        double celsius = 20;
        double fahrenheit = (celsius * 9 / 5) + 32;

        Console.WriteLine("Nhiệt độ (F): " + fahrenheit);

        //---------------------------------------------------------------------
        // Part 10: Mathematical Operators
        // Write a C# program to calculate the area of a rectangle given its length and width.
        // Hint: Use the formula area = length * width.
        // Test data: double length = 10, double width = 5

        double length = 10;
        double width = 5;
        double area = length * width;
        Console.WriteLine("Diện tích của hình chữ nhật là: " + area);


        //---------------------------------------------------------------------
        // Part 11: Mathematical Operators
        // Write a C# program to calculate the volume of a sphere given its radius.
        // Hint: Use the formula volume = (4/3) * Pi * radius^3.
        // Test data: double radius = 5

        double radius = 5;
        double volume = (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);
        Console.WriteLine("Thể tích của hình cầu là: " + volume);


        //---------------------------------------------------------------------
        // Part 12: Mathematical Operators
        // Write a C# program to calculate the factorial of a given integer.
        // Hint: Use a loop to multiply the numbers from 1 to the given integer.
        // Test data: int num = 5

        num = 5;
        long factorial = 1;
        for (int i = 1; i <= num; i++)
        {
            factorial *= i;
        }
        Console.WriteLine("Giai thừa của " + num + " là: " + factorial);


        //---------------------------------------------------------------------
        // Part 13: Mathematical Operators
        // Write a C# program to calculate the compound interest given the principal amount, interest rate, and time period.
        // Hint: Use the formula A = P * (1 + r/n)^(nt).
        // Test data: double principal = 1000, double rate = 0.05, int time = 5

        double principal = 1000;
        double rate = 0.05;
        int time = 5;
        int n = 1; // Compounded annually
        double amount = principal * Math.Pow(1 + rate / n, n * time);
        Console.WriteLine("Số tiền sau " + time + " năm là: " + amount);


        //---------------------------------------------------------------------
        // Part 14: Mathematical Operators
        // Write a C# program to solve a quadratic equation of the form ax^2 + bx + c = 0.
        // Hint: Use the quadratic formula.
        // Test data: double a = 1, double b = 5, double c = 6

        double a = 1;
        double b = 5;
        double c = 6;

        double delta = b * b - 4 * a * c;

        if (delta > 0)
        {
            double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

            Console.WriteLine("Phương trình có 2 nghiệm:");
            Console.WriteLine("x1 = " + x1);
            Console.WriteLine("x2 = " + x2);
        }
        else if (delta == 0)
        {
            double x = -b / (2 * a);
            Console.WriteLine("Phương trình có nghiệm kép: x = " + x);
        }
        else
        {
            Console.WriteLine("Phương trình vô nghiệm (trong tập số thực)");
        }
    }
}*/

//---------------------------------------------------------------------
// Part 15: Mathematical Operators
// Write a C# program to calculate the nth Fibonacci number using recursion.
// Hint: Use a recursive function to calculate Fibonacci numbers.
// Test data: int n = 8

/*using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        int n = 8;
        int result = Fibonacci(n);

        Console.WriteLine($"Số Fibonacci thứ {n} là: {result}");
    }

    static int Fibonacci(int n)
    {
        if (n == 0) return 0;
        if (n == 1) return 1;

        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
}*/

//---------------------------------------------------------------------
// Part 16: Mathematical Operators
// Write a C# program to calculate the nth term of the arithmetic sequence given the first term, common difference, and term number.
// Hint: Use the formula nth term = first term + (n - 1) * common difference.
// Test data: int firstTerm = 3, int commonDifference = 2, int termNumber = 5

/*using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        int firstTerm = 3;
        int commonDifference = 2;
        int termNumber = 5;

        int nthTerm = firstTerm + (termNumber - 1) * commonDifference;

        Console.WriteLine("Số hạng thứ " + termNumber + " là: " + nthTerm);

        //---------------------------------------------------------------------
        // Part 17: Relational Operators
        // Write a C# program to check if a given number is greater than another number.
        // Hint: Use the > operator to check if the first number is greater than the second number.
        // Test data: int num1 = 10, int num2 = 5
        int num1 = 10;
        int num2 = 5;
        if (num1 > num2)
        {
            Console.WriteLine(num1 + " lớn hơn " + num2);
        }
        else
        {
            Console.WriteLine(num1 + " không lớn hơn " + num2);
        }


        //---------------------------------------------------------------------
        // Part 18: Relational Operators
        // Write a C# program to check if a given number is less than or equal to 100.
        // Prompt the user to enter a number and check if it is less than or equal to 100.
        // Hint: Use the <= operator to check if the number is less than or equal to 100.
        // Test data: Enter a number: 88
        Console.OutputEncoding = Encoding.UTF8;

        Console.Write("Nhập một số: ");
        int number = int.Parse(Console.ReadLine());

        if (number <= 100)
        {
            Console.WriteLine("Số nhỏ hơn hoặc bằng 100");
        }
        else
        {
            Console.WriteLine("Số lớn hơn 100");
        }

        //---------------------------------------------------------------------
        // Part 19: Logical Operators
        // Write a C# program to check if a given number is even AND greater than 10.
        // Prompt the user to enter a number and check if it satisfies both conditions.
        // Hint: Use the % operator to check if the number is even, and the && operator to check both conditions.
        // Test data: Enter a number: 16

        Console.Write("Nhập một số: ");
        number = int.Parse(Console.ReadLine());
        if (number % 2 == 0 && number > 10)
        {
            Console.WriteLine("Số là chẵn và lớn hơn 10");
        }
        else
        {
            Console.WriteLine("Số không phải là chẵn hoặc không lớn hơn 10");
        }
    }
}*/
//---------------------------------------------------------------------
// Part 20: Logical Operators
// Write a C# program to check if a given number is divisible by 3 OR 5.
// Prompt the user to enter a number and check if it is divisible by either 3 or 5.
// Hint: Use the % operator to check for divisibility, and the || operator to check either condition.
// Test data: Enter a number: 9

/*using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;

        Console.Write("Nhập một số: ");
        int number = int.Parse(Console.ReadLine());

        if (number % 3 == 0 || number % 5 == 0)
        {
            Console.WriteLine("Số chia hết cho 3 hoặc 5");
        }
        else
        {
            Console.WriteLine("Số không chia hết cho 3 hoặc 5");
        }

        //---------------------------------------------------------------------
        // Part 21: Initialization and Assignment Operators
        // Write a C# program to increment a variable by 5 using the shorthand assignment operator.
        // Prompt the user to enter a number and increment it by 5 using the shorthand assignment operator.
        // Hint: Use the += operator to increment the variable by 5.
        // Test data: Enter a number: 7
        Console.Write("Nhập một số: ");
        number = int.Parse(Console.ReadLine());
        number += 5;
        Console.WriteLine("Số sau khi tăng thêm 5 là: " + number);

    }

}*/
        //---------------------------------------------------------------------
        // Part 22: Initialization and Assignment Operators
        // Write a C# program to calculate the remainder when dividing a number by 7 and update the number using the %= operator.
        // Initialize a variable 'number' with a value of 27, then calculate the remainder when dividing 'number' by 7 and update 'number' with the result.
        // Hint: Use the %= operator to update the value of 'number' with the remainder of 'number' divided by 7.
        // Test data: int number = 27

using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        int number = 27;

        number %= 7;

        Console.WriteLine("Giá trị sau khi lấy dư cho 7 là: " + number);
    }
}


