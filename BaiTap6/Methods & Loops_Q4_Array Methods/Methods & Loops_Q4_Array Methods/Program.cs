// ---------------------------------------------------------------------
// Question: Finding the First Element Meeting a Condition in an Array
// Write a C# program to find and display the first element greater than 50 in an integer array.
// Hint: Use the Array.Find() method with a condition-checking function (Predicate) to find the first element greater than 50 in the array.
// Define a condition-checking function that returns true if the element is greater than 50.

/*using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 10, 25, 40, 55, 70, 30 };

        // Gọi Array.Find với hàm điều kiện
        int result = Array.Find(numbers, IsGreaterThan50);

        Console.WriteLine("First number greater than 50: " + result);
    }

    // Hàm điều kiện (Predicate)
    static bool IsGreaterThan50(int num)
    {
        return num > 50;
    }
}*/

// ---------------------------------------------------------------------
// Question: Find the First Element Greater Than 10
// Write a C# program that finds the first element greater than 10 in an integer array and displays it.
// Hint: Define an array of integers. Use Array.Find() method with a condition-checking function to find the first element greater than 10.
// Define a condition-checking function that returns true if the element is greater than 10.

/*using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 3, 7, 9, 12, 5, 20 };

        // Tìm phần tử đầu tiên > 10
        int result = Array.Find(numbers, IsGreaterThan10);

        Console.WriteLine("First number greater than 10: " + result);
    }

    // Hàm điều kiện
    static bool IsGreaterThan10(int num)
    {
        return num > 10;
    }
}*/


//---------------------------------------------------------------------
// Question: Find the First Negative Number
// Write a C# program to find the first negative number in an array of integers and display it.
// Hint: Define an array of integers. Use Array.Find() method with a condition-checking function to find the first negative number.
// Define a condition-checking function that returns true if the element is negative.

using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 5, 8, -3, 10, -7 };

        // Tìm số âm đầu tiên
        int result = Array.Find(numbers, IsNegative);

        Console.WriteLine("First negative number: " + result);
    }

    // Hàm điều kiện
    static bool IsNegative(int num)
    {
        return num < 0;
    }
}