//Part 1
// Get two inputs from the userds and store them in two variables and use and if statement to check if the two inputs are equal and print out a message to the console.
// Hint: You can use the == operator to check if two values are equal.

/*using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.Write("Nhập giá trị thứ nhất: ");
        string input1 = Console.ReadLine();

        Console.Write("Nhập giá trị thứ hai: ");
        string input2 = Console.ReadLine();

        if (input1 == input2)
        {
            Console.WriteLine("Hai giá trị bằng nhau");
        }
        else
        {
            Console.WriteLine("Hai giá trị không bằng nhau");
        }
    }
}*/


//Part 2
// Get two inputs from the user and store them in two variables and use an if statement to check if the first input is greater than the second input and print out a message to the console.
// Hint: You can use the > operator to check if the first input is greater than the second input.

/*using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.Write("Nhập số thứ nhất: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Nhập số thứ hai: ");
        int num2 = int.Parse(Console.ReadLine());

        if (num1 > num2)
        {
            Console.WriteLine("Số thứ nhất lớn hơn số thứ hai");
        }
        else
        {
            Console.WriteLine("Số thứ nhất không lớn hơn số thứ hai");
        }
    }
}*/

//Part 3
// Get two inputs from the user and store them in two variables and use an if statement to check if the first input is less than the second input and print out a message to the console.
// Hint: You can use the < operator to check if the first input is less than the second input.

/*using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.Write("Nhập số thứ nhất: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Nhập số thứ hai: ");
        int num2 = int.Parse(Console.ReadLine());

        if (num1 < num2)
        {
            Console.WriteLine("Số thứ nhất nhỏ hơn số thứ hai");
        }
        else
        {
            Console.WriteLine("Số thứ nhất không nhỏ hơn số thứ hai");
        }
    }
}*/

//Part 4
// Get two inputs from the user and store them in two variables and use an if statement to check if the first input is not equal to the second input and print out a message to the console.
// Hint: You can use the != operator to check if two values are not equal.

/*using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.Write("Nhập giá trị thứ nhất: ");
        string input1 = Console.ReadLine();

        Console.Write("Nhập giá trị thứ hai: ");
        string input2 = Console.ReadLine();

        if (input1 != input2)
        {
            Console.WriteLine("Hai giá trị KHÁC nhau");
        }
        else
        {
            Console.WriteLine("Hai giá trị giống nhau");
        }
    }
}*/

//Part 5
// Get two inputs from the user and store them in two variables and use an if statement to check if the first input is greater than or equal to the second input and print out a message to the console.
// Hint: You can use the >= operator to check if the first input is greater than or equal to the second input.

/*using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.Write("Nhập số thứ nhất: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Nhập số thứ hai: ");
        int num2 = int.Parse(Console.ReadLine());

        if (num1 >= num2)
        {
            Console.WriteLine("Số thứ nhất lớn hơn hoặc bằng số thứ hai");
        }
        else
        {
            Console.WriteLine("Số thứ nhất nhỏ hơn số thứ hai");
        }
    }
}*/

//Part 6
// Get two inputs from the user and store them in two variables and use an if statement to check if the first input is less than or equal to the second input and print out a message to the console.
// Hint: You can use the <= operator to check if the first input is less than or equal to the second input.

/*using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.Write("Nhập số thứ nhất: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Nhập số thứ hai: ");
        int num2 = int.Parse(Console.ReadLine());

        if (num1 <= num2)
        {
            Console.WriteLine("Số thứ nhất nhỏ hơn hoặc bằng số thứ hai");
        }
        else
        {
            Console.WriteLine("Số thứ nhất lớn hơn số thứ hai");
        }
    }
}*/

//Part 7
// Create a math quiz that asks the user a math question and checks if the user's answer is correct. If the user's answer is correct, print out a message to the console. If the user's answer is incorrect, print out a different message to the console.
// Hint: You can use the Console.ReadLine() method to get input from the user and use an if statement to check if the user's answer is correct.

/*using System;
using System.Text;

class Program
{
    static void Main()
    {

        Console.OutputEncoding = Encoding.UTF8;

        // Câu hỏi
        int a = 7;
        int b = 5;

        Console.WriteLine($"Câu hỏi: {a} + {b} = ?");
        Console.Write("Nhập đáp án: ");

        int answer = int.Parse(Console.ReadLine());

        if (answer == a + b)
        {
            Console.WriteLine("Chính xác!");
        }
        else
        {
            Console.WriteLine($"Sai rồi! Đáp án đúng là {a + b}");
        }
    }
}*/

//Part 8
// Create a program that asks the user for their age and checks if the user is old enough to vote. If the user is old enough to vote, print out a message to the console. If the user is not old enough to vote, print out a different message to the console.
// Hint: You can use the Console.ReadLine() method to get input from the user and use an if statement to check if the user is old enough to vote.

/*using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.Write("Nhập tuổi của bạn: ");

        int age = int.Parse(Console.ReadLine());

        if (age >= 18)
        {
            Console.WriteLine("Bạn đủ tuổi để bỏ phiếu");
        }
        else
        {
            Console.WriteLine("Bạn chưa đủ tuổi để bỏ phiếu");
        }
    }
}*/


//Part 9
// Create a program that check whihc state a enemy is in based on their health points. If the enemy has 100 health points, print out a message to the console. If the enemy has 50 health points, print out a different message to the console. If the enemy has 25 health points, print out a different message to the console. If the enemy has 0 health points, print out a different message to the console.
// Hint: You can use an if-else statement to check the enemy's health points and print out a message based on the enemy's health points.

/*using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.Write("Nhập HP của enemy: ");
        int hp = int.Parse(Console.ReadLine());

        if (hp == 100)
        {
            Console.WriteLine("Enemy is at full health");
        }
        else if (hp == 50)
        {
            Console.WriteLine("Enemy is injured");
        }
        else if (hp == 25)
        {
            Console.WriteLine("Enemy is in critical condition");
        }
        else if (hp == 0)
        {
            Console.WriteLine("Enemy is defeated");
        }
        else
        {
            Console.WriteLine("Enemy has an unknown health state");
        }
    }
}*/

//Part 10
// Create a program that checks if a user is eligible for a discount based on their age. If the user is 18 years old or older, print out a message to the console. If the user is younger than 18 years old, print out a different message to the console.
// Hint: You can use an if-else statement to check the user's age and print out a message based on the user's age.

/*using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.Write("Nhập tuổi của bạn: ");
        int age = int.Parse(Console.ReadLine());

        if (age >= 18)
        {
            Console.WriteLine("Bạn đủ điều kiện nhận giảm giá");
        }
        else
        {
            Console.WriteLine("Bạn không đủ điều kiện nhận giảm giá");
        }
    }
}*/





////////////// Break , Continue Statements //////////////


//Part 1
// Create a program that counts from 1 to 20, but skips counting the number 5.
// Hint: Use a for loop to iterate through the numbers and a continue statement to skip the number 5.

/*using System;

class Program
{
    static void Main()
    {
        for (int i = 1; i <= 20; i++)
        {
            if (i == 5)
                continue; // bỏ qua số 5

            Console.WriteLine(i);
        }
    }
}*/

//Part 2
// Create a program that prints the numbers from 1 to 10, but breaks the loop if the number 7 is encountered.
// Hint: Use a for loop to iterate through the numbers and a break statement to exit the loop when 7 is encountered.

/*using System;

class Program
{
    static void Main()
    {
        for (int i = 1; i <= 10; i++)
        {
            if (i == 7)
                break; // dừng vòng lặp khi gặp 7

            Console.WriteLine(i);
        }
    }
}*/

//Part 3
// Write a program to print all even numbers from 1 to 20, but skip printing the number 10.
// Hint: Use a for loop to iterate through the numbers and an if statement with a continue statement to skip printing 10.

/*using System;

class Program
{
    static void Main()
    {
        for (int i = 1; i <= 20; i++)
        {
            // kiểm tra số chẵn
            if (i % 2 == 0)
            {
                if (i == 10)
                    continue; // bỏ qua số 10

                Console.WriteLine(i);
            }
        }
    }
}*/

//Part 4
// Create a program that searches for the word "apple" in a list of fruits. If found, print "Apple found!"; otherwise, continue searching.
// Hint: Use a foreach loop to iterate through the list of fruits and an if statement to check if the current fruit is "apple". Use a continue statement to continue searching if "apple" is not found.

/*using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> fruits = new List<string>
        {
            "banana", "orange", "grape", "apple", "mango"
        };

        foreach (string fruit in fruits)
        {
            if (fruit != "apple")
                continue; // bỏ qua nếu không phải apple

            Console.WriteLine("Apple found!");
        }
    }
}*/

//Part 5
// Write a program to count from 1 to 100, but skip counting by 10s.
// Hint: Use a for loop to iterate through the numbers and an if statement with a continue statement to skip counting by 10s.

/*using System;

class Program
{
    static void Main()
    {
        for (int i = 1; i <= 100; i++)
        {
            if (i % 10 == 0)
                continue; // bỏ qua bội số của 10

            Console.WriteLine(i);
        }
    }
}*/

//Part 6
// Create a program to print the letters of the alphabet from A to G, but skip printing the letter 'E'.
// Hint: Use a for loop to iterate through the alphabet and an if statement with a continue statement to skip printing 'E'.

/*using System;

class Program
{
    static void Main()
    {
        for (char c = 'A'; c <= 'G'; c++)
        {
            if (c == 'E')
                continue; // bỏ qua chữ E

            Console.WriteLine(c);
        }
    }
}*/

//Part 7
// Write a program to find and print all prime numbers between 1 and 50, skipping non-prime numbers.
// Hint: Use a for loop to iterate through the numbers and an if statement with a continue statement to skip non-prime numbers.

/*using System;

class Program
{
    static void Main()
    {
        for (int i = 2; i <= 50; i++)
        {
            bool isPrime = true;

            // kiểm tra số nguyên tố
            for (int j = 2; j <= Math.Sqrt(i); j++)
            {
                if (i % j == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (!isPrime)
                continue; // bỏ qua nếu không phải số nguyên tố

            Console.WriteLine(i);
        }
    }
}*/

//Part 8
// Create a program to print the numbers from 1 to 10, but skip printing the number 3.
// Hint: Use a for loop to iterate through the numbers and an if statement with a continue statement to skip printing 3.

/*using System;

class Program
{
    static void Main()
    {
        for (int i = 1; i <= 10; i++)
        {
            if (i == 3)
                continue; // bỏ qua số 3

            Console.WriteLine(i);
        }
    }
}*/

//Part 9
// Write a program to search for the number 20 in an array of integers. If found, print its index; otherwise, continue searching.
// Hint: Use a for loop to iterate through the array and an if statement to check if the current element is 20. Use a continue statement to continue searching if 20 is not found.

/*using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 5, 10, 15, 20, 25 };

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] != 20)
                continue; // bỏ qua nếu không phải 20

            Console.WriteLine("Found 20 at index: " + i);
        }
    }
}*/

//Part 10
// Create a program that prints the names of different fruits, but skips printing the name "banana".
// Hint: Use a foreach loop to iterate through the list of fruits and an if statement with a continue statement to skip printing "banana".

/*using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> fruits = new List<string>
        {
            "apple", "banana", "orange", "grape", "mango"
        };

        foreach (string fruit in fruits)
        {
            if (fruit == "banana")
                continue; // bỏ qua banana

            Console.WriteLine(fruit);
        }
    }
}*/





////////////// Extra Challenges //////////////

/*
Part 11

ABC Company pays its sales agents on a commission basis. 
Each agent is paid 10% commission for monthly sales above or equal to $10,000 and 5% commission for monthly sales below $10,000.

Write a program to accept the monthly sales of a particular agent and based on the amount, determine and print out the commission earned.

Example:
Enter the monthly sales: 12000
Commission earned: $1200.00

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the monthly sales: ");
        double sales = double.Parse(Console.ReadLine());

        double commission;

        if (sales >= 10000)
        {
            commission = sales * 0.10;
        }
        else
        {
            commission = sales * 0.05;
        }

        Console.WriteLine("Commission earned: ${0:F2}", commission);
    }
}
*/


/*
Part 12

Write a program that generates two integers between 0 and 100 inclusive and prompts the user to enter the sum of these 2 integers. The program reports if the answer is correct or wrong (program will also print the correct answer if the user's answer is wrong).

Hint: You need to use the random module.

Example:
Enter the sum of 43 and 58: 100
Correct!


using System;

class Program
{
    static void Main()
    {
        Random rand = new Random();

        int num1 = rand.Next(0, 101); // 0 → 100
        int num2 = rand.Next(0, 101);

        Console.Write($"Enter the sum of {num1} and {num2}: ");

        int userAnswer = int.Parse(Console.ReadLine());
        int correctAnswer = num1 + num2;

        if (userAnswer == correctAnswer)
        {
            Console.WriteLine("Correct!");
        }
        else
        {
            Console.WriteLine($"Wrong! The correct answer is {correctAnswer}");
        }
    }
}
 */


/*
 Part 13

The grade that you get for a module depends on your marks. The table below shows the grade for each range of marks.

Marks   |   Grade   |   Comment
---------------------------------
>= 85   |     A+    |  Excellent!
>= 80   |     A     |  Well done.
>= 75   |     B+    |
>= 70   |     B     |
>= 65   |     C+    |
>= 60   |     C     |
>= 55   |     D+    |
>= 50   |     D     |
< 50    |     F     |  See me.

Write a program that asks for a student’s marks, then displays the correct grade and the corresponding comment (if any).

Example:
Enter student's marks: 82
Grade: A
Comment: Well done.
 


using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter student's marks: ");
        int marks = int.Parse(Console.ReadLine());

        string grade;
        string comment = "";

        if (marks >= 85)
        {
            grade = "A+";
            comment = "Excellent!";
        }
        else if (marks >= 80)
        {
            grade = "A";
            comment = "Well done.";
        }
        else if (marks >= 75)
        {
            grade = "B+";
        }
        else if (marks >= 70)
        {
            grade = "B";
        }
        else if (marks >= 65)
        {
            grade = "C+";
        }
        else if (marks >= 60)
        {
            grade = "C";
        }
        else if (marks >= 55)
        {
            grade = "D+";
        }
        else if (marks >= 50)
        {
            grade = "D";
        }
        else
        {
            grade = "F";
            comment = "See me.";
        }

        Console.WriteLine($"Grade: {grade}");

        if (!string.IsNullOrEmpty(comment))
        {
            Console.WriteLine($"Comment: {comment}");
        }
    }
}
 */



/*
 Part 14

 A guard in a computer game acts as follows:

If sees_player == False, he will wait

If sees_player == True:
    - If dist_from_player <= 1, he will attack
    - If 2 <= dist_from_player <= 4, he will advance
    - If dist_from_player >= 5, he will wait

Write a program that shows how the guard will act.

Example:
sees_player = True
dist_from_player = 3

The guard will advance.
 
 */
using System;

class Program
{
    static void Main()
    {
        Console.Write("Sees player (true/false): ");
        bool seesPlayer = bool.Parse(Console.ReadLine());

        Console.Write("Distance from player: ");
        int distance = int.Parse(Console.ReadLine());

        if (!seesPlayer)
        {
            Console.WriteLine("The guard will wait.");
        }
        else
        {
            if (distance <= 1)
            {
                Console.WriteLine("The guard will attack.");
            }
            else if (distance >= 2 && distance <= 4)
            {
                Console.WriteLine("The guard will advance.");
            }
            else
            {
                Console.WriteLine("The guard will wait.");
            }
        }
    }
}