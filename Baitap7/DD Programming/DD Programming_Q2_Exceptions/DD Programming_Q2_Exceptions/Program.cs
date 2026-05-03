
// Guide to Exceptions in C#:

// System.ArgumentNullException:
// - Thrown when a null argument is passed to a method that does not accept null arguments.

// System.FormatException:
// - Thrown when a method is called with an invalid format for its input arguments.

// System.IndexOutOfRangeException:
// - Thrown when an attempt is made to access an element of an array or collection with an index outside the bounds.

// System.InvalidCastException:
// - Thrown when an invalid type conversion is attempted.

// System.IO.IOException:
// - Thrown when an I/O error occurs, such as when reading from or writing to a file.

// System.DivideByZeroException:
// - Thrown when attempting to divide an integer or decimal number by zero.

// System.NullReferenceException:
// - Thrown when attempting to access a member of a null object reference.

// System.OverflowException:
// - Thrown when an arithmetic operation results in an overflow.

// System.NotImplementedException:
// - Thrown when a method or feature is not yet implemented.

// System.OutOfMemoryException:
// - Thrown when attempting to allocate memory fails due to insufficient available memory.

// System.StackOverflowException:
// - Thrown when the execution stack overflows, typically due to excessive recursion.

// System.TimeoutException:
// - Thrown when an operation times out before completing.

// System.ArgumentException:
// - Thrown when one or more arguments provided to a method are invalid or out of range.

// System.ArithmeticException:
// - Thrown for errors in arithmetic operations.

// System.Security.SecurityException:
// - Thrown when a security violation occurs, such as attempting to perform an operation that requires elevated permissions.



//Part 1
//Write a C# program that prompts the user to input two numbers and divides them. Handle an exception when the user enters non-numeric values.
//Hint: Use the TryParse method to convert the input string to a number.
//Hint:Use FormatException for non-numeric values and DivideByZeroException for division by zero.

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
            Console.Write("Nhập số thứ nhất: ");
            string input1 = Console.ReadLine();

            Console.Write("Nhập số thứ hai: ");
            string input2 = Console.ReadLine();

            // Dùng TryParse
            if (!int.TryParse(input1, out int num1) || !int.TryParse(input2, out int num2))
            {
                throw new FormatException("Bạn phải nhập số hợp lệ!");
            }

            int result = num1 / num2; // Có thể gây lỗi chia cho 0
            Console.WriteLine("Kết quả: " + result);
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Lỗi định dạng: " + ex.Message);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Lỗi: Không thể chia cho 0!");
        }
    }
}*/


//Part 2
// Write a C# program that reads a string from the user and converts it to an integer. Handle the exception if the input cannot be parsed into an integer.
//Hint: Use the TryParse method to convert the input string to an integer.
//Hint: Use FormatException for invalid input.

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
            Console.Write("Nhập một chuỗi: ");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int number))
            {
                throw new FormatException("Dữ liệu nhập không phải là số nguyên!");
            }

            Console.WriteLine("Số sau khi chuyển: " + number);
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Lỗi định dạng: " + ex.Message);
        }
    }
}*/


//Part 3
//Write a C# program that implements a method that divides two numbers. Handle the DivideByZeroException that occurs if the denominator is 0.
//Hint: Use a try-catch block to catch the DivideByZeroException.

/*using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        int a = 10;
        int b = 0;

        try
        {
            int result = Divide(a, b); // Gọi hàm chia
            Console.WriteLine("Kết quả: " + result);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Lỗi: Không thể chia cho 0!");
        }
    }

    // Hàm thực hiện phép chia
    static int Divide(int x, int y)
    {
        return x / y; // Có thể gây lỗi nếu y = 0
    }
}*/


//Part 4
//Write a C# program that creates a method that takes a string as input and converts it to uppercase. Handle the NullReferenceException that occurs if the input string is null.
//Hint: Use a try-catch block to catch the NullReferenceException.

using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        string input = null; // Test: null

        try
        {
            string result = ToUpperCase(input); // Gọi hàm
            Console.WriteLine("Kết quả: " + result);
        }
        catch (NullReferenceException)
        {
            Console.WriteLine("Lỗi: Chuỗi đầu vào là null!");
        }
    }

    // Hàm chuyển chuỗi sang chữ hoa
    static string ToUpperCase(string str)
    {
        return str.ToUpper(); // Lỗi nếu str = null
    }
}


