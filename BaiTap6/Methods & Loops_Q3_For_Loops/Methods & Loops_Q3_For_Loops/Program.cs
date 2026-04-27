//Use For Loops to solve the following problems.



//Part 1
//Write a program in C to display the first 10 natural numbers.
//Expected Output:
//1 2 3 4 5 6 7 8 9 10

/*using System;

class Program
{
    static void Main()
    {
        int i = 1;

        while (i <= 10)
        {
            Console.Write(i + " ");
            i++;
        }
    }
}*/

//Part 2
//Write a program in C to display the cube of the number up to an integer.
//Expected Output:
//Input number of terms: 5
//Number is: 1 and cube of the 1 is: 1
//Number is: 2 and cube of the 2 is: 8
//Number is: 3 and cube of the 3 is: 27
//Number is: 4 and cube of the 4 is: 64
//Number is: 5 and cube of the 5 is: 125

/*using System;

class Program
{
    static void Main()
    {
        Console.Write("Input number of terms: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int i = 1;

        while (i <= n)
        {
            int cube = i * i * i;

            Console.WriteLine($"Number is: {i} and cube of the {i} is: {cube}");

            i++;
        }
    }
}*/

//Part 3
//Write a program in C to display the multiplication table of a given integer.
//Expected Output:
//Input the number (Table to be calculated): 15
//15 X 1 = 15
//...
//15 X 10 = 150

/*using System;

class Program
{
    static void Main()
    {
        Console.Write("Input the number (Table to be calculated): ");
        int number = Convert.ToInt32(Console.ReadLine());

        int i = 1;

        while (i <= 10)
        {
            Console.WriteLine($"{number} X {i} = {number * i}");
            i++;
        }
    }
}*/


//Part 4
//Write a C# Sharp program to display an alphabet pattern like Y with an asterisk.
//Hint: Use nested loop
//Expected Output:
// *     *
//  *   *
//   * *
//    *
//    *
//    *
//    *

/*using System;

class Program
{
    static void Main()
    {
        int n = 4; // chiều cao phần trên (có thể chỉnh)

        int i = 1;

        // Phần trên (chữ V)
        while (i <= n)
        {
            int j = 1;

            while (j <= n * 2)
            {
                if (j == i || j == (n * 2 - i))
                    Console.Write("*");
                else
                    Console.Write(" ");

                j++;
            }

            Console.WriteLine();
            i++;
        }

        // Phần dưới (thân chữ Y)
        int k = 1;

        while (k <= n)
        {
            int j = 1;

            while (j <= n * 2)
            {
                if (j == n)
                    Console.Write("*");
                else
                    Console.Write(" ");

                j++;
            }

            Console.WriteLine();
            k++;
        }
    }
}*/

// Part 5: Character Health Regeneration
// Simulate the regeneration of a game character's health over 5 rounds. Display the character's health after each round, regenerating 10 health points per round.
// Expected Output:
// Round 1: Health 10
// Round 2: Health 20
// ...
// Round 5: Health 50

/*using System;

class Program
{
    static void Main()
    {
        int round = 1;
        int health = 0;

        while (round <= 5)
        {
            health += 10;
            Console.WriteLine($"Round {round}: Health {health}");
            round++;
        }
    }
}*/


/////////// For Each Loop ///////////

//Use For Each Loops to solve the following problems.

//Part 6
// Create an list of names and iterate through each name and display the name.
//Expected Output:
//Name: John
//Name: James
//Name: Luke
//Name: Lila

/*using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Tạo list tên
        List<string> names = new List<string>
        {
            "John",
            "James",
            "Luke",
            "Lila"
        };

        // Duyệt bằng foreach
        foreach (string name in names)
        {
            Console.WriteLine("Name: " + name);
        }
    }
}*/

//Part 7
//Create a list of number , iterate through them and display the square of each number.
//Expected Output:
//Square of 2: 4
//Square of 3: 9
//Square of 4: 16
//Square of 5: 25

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Tạo danh sách số
        List<int> numbers = new List<int> { 2, 3, 4, 5 };

        // Duyệt và in bình phương
        foreach (int num in numbers)
        {
            int square = num * num;
            Console.WriteLine($"Square of {num}: {square}");
        }
    }
}


