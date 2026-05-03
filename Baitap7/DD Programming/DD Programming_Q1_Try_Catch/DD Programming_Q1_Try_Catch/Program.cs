//Example of Try-Catch Block:

//try
//{
//    // Code that might throw an exception
//}
//catch (ExceptionType1 ex)
//{
//    // Code to handle ExceptionType1
//}
//catch (ExceptionType2 ex)
//{
//    // Code to handle ExceptionType2
//}
//finally
//{
//    // Code that always runs, regardless of exceptions
//}




// Question 1
// Write a C# program that attempts to divide two numbers and prints any exceptions that may occur.
// Hint: Use a try block to perform the division and a catch block to print any exceptions.
// Test Data: Dividing 10 by 0

/*using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        try
        {
            int a = 10;
            int b = 0;

            int result = a / b; // Thực hiện phép chia
            Console.WriteLine("Kết quả: " + result);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Exception xảy ra: " + ex.Message);
        }
    }
}*/

// Question 2
// Create a program that converts a string to an integer and prints any exceptions that may occur.
// Hint: Use a try block to convert the string to an integer and a catch block to print any exceptions.
// Test Data: Converting 'abc' to an integer

/*using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        try
        {
            string input = "abc"; // Test Data
            int number = int.Parse(input); // Chuyển sang số nguyên

            Console.WriteLine("Kết quả: " + number);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Lỗi xảy ra: " + ex.Message);
        }
    }
}*/

// Question 3
// Write a C# program that opens a file and prints any exceptions that may occur.
// Hint: Use a try block to open the file and a catch block to print any exceptions.
// Test Data: Opening a non-existent file

/*using System;
using System.IO;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        try
        {
            string path = "filekhongtontai.txt"; // Test Data
            StreamReader sr = new StreamReader(path); // Mở file

            string content = sr.ReadToEnd();
            Console.WriteLine(content);

            sr.Close();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Lỗi xảy ra: " + ex.Message);
        }
    }
}*/

// Question 4
// Create a program that reads input from the user and prints any exceptions that may occur.
// Hint: Use a try block to read input from the user and a catch block to print any exceptions.
// Test Data: Reading input from the user

/*using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        try
        {
            Console.Write("Nhập một số: ");
            string input = Console.ReadLine(); // Đọc dữ liệu từ người dùng

            int number = int.Parse(input); // Chuyển sang số nguyên
            Console.WriteLine("Bạn đã nhập: " + number);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Lỗi xảy ra: " + ex.Message);
        }
    }
}*/

// Question 5
// Write a C# program that performs a calculation and prints any exceptions that may occur.
// Hint: Use a try block to perform the calculation and a catch block to print any exceptions.
// Test Data: Performing a calculation with invalid operands

using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        try
        {
            // Test Data: toán hạng không hợp lệ
            string a = "10";
            string b = "abc";

            int num1 = int.Parse(a);
            int num2 = int.Parse(b); // sẽ gây lỗi

            int result = num1 + num2; // phép tính
            Console.WriteLine("Kết quả: " + result);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Lỗi xảy ra: " + ex.Message);
        }
    }
}