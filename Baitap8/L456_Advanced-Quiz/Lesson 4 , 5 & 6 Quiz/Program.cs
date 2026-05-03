
/*
Question 1:
BMI Calculation

The Body Mass Index (BMI) of a person is calculated based on the following formula: 
BMI = weight / (height x height)

Note:
- weight is in kilograms (e.g. 65.0)
- height is in metres (e.g. 1.70)

Write a C# program to:
- prompt the user to enter his/her weight and height
- calculate the BMI (body mass index)
- display the BMI and the health category according to the table below:

BMI Health category
Below 18.5    Underweight
18.5 - 23     Normal weight
23 - 27.5     Overweight
Above 27.5    Obese
*/


/*using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        // Nhập dữ liệu
        Console.Write("Enter weight (kg): ");
        double weight = double.Parse(Console.ReadLine());

        Console.Write("Enter height (m): ");
        double height = double.Parse(Console.ReadLine());

        // Tính BMI
        double bmi = weight / (height * height);

        string category;

        // Phân loại BMI
        if (bmi < 18.5)
        {
            category = "Underweight";
        }
        else if (bmi < 23)
        {
            category = "Normal weight";
        }
        else if (bmi <= 27.5)
        {
            category = "Overweight";
        }
        else
        {
            category = "Obese";
        }

        // Xuất kết quả
        Console.WriteLine($"BMI = {bmi:F2}");
        Console.WriteLine($"Health category: {category}");
    }
}*/










/*
Question 2:
Discount Calculation [using if..else]

The discount rate given by a shopping mall is shown below:
----------------------------------------------
| Amount spent ($)      |  Discount Rate (%) |
| 100 and below         |        0           |
| 100 < amount <= 500   |        5           |
| 500 < amount <= 1000  |       10           |
| Above 1000            |       20           |
----------------------------------------------
Write a C# program to:
- prompt the user to enter the amount spent 
- calculate and display the discount given (in percentage)
- calculate and display the discount amount
*/


/*using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        // Nhập số tiền
        Console.Write("Enter the amount spent ($): ");
        double amount = double.Parse(Console.ReadLine());

        double discountRate;

        // Xác định mức giảm giá
        if (amount <= 100)
        {
            discountRate = 0;
        }
        else if (amount <= 500)
        {
            discountRate = 5;
        }
        else if (amount <= 1000)
        {
            discountRate = 10;
        }
        else
        {
            discountRate = 20;
        }

        // Tính số tiền giảm
        double discountAmount = amount * discountRate / 100;

        // Xuất kết quả
        Console.WriteLine($"Discount rate: {discountRate}%");
        Console.WriteLine($"Discount amount: ${discountAmount:F2}");
    }
}*/






/*
Question 3:
Multiplication Table [using repetition structure]

Write a C# program to display the multiplication table for a given number from 1 to 12.

Example:
Enter a number : 8
1  8
2  16
3  24
4  32
5  40
6  48
7  56
8  64
9  72
10 80
11 88
12 96
*/


/*using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        // Nhập số
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        // Vòng lặp từ 1 đến 12
        for (int i = 1; i <= 12; i++)
        {
            Console.WriteLine($"{i}  {i * number}");
        }
    }
}*/


/*
Question 4:
Admin Menu [using methods, loop & nested if]

Write a C# program that displays the main menu and allows the user to select options to perform BMI calculation, discount calculation, or display a multiplication table. The program should repeatedly display the menu until the user chooses to exit.

Example:
------------- MENU --------------
[1] Calculate Body Mass Index
[2] Calculate Discount
[3] Display Multiplication Table
[0] Exit
---------------------------------
*/

/*using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        int choice;

        do
        {
            // MENU
            Console.WriteLine("------------- MENU --------------");
            Console.WriteLine("[1] Calculate Body Mass Index");
            Console.WriteLine("[2] Calculate Discount");
            Console.WriteLine("[3] Display Multiplication Table");
            Console.WriteLine("[0] Exit");
            Console.WriteLine("---------------------------------");

            Console.Write("Enter your choice: ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                CalculateBMI();
            }
            else if (choice == 2)
            {
                CalculateDiscount();
            }
            else if (choice == 3)
            {
                MultiplicationTable();
            }
            else if (choice == 0)
            {
                Console.WriteLine("Exiting program...");
            }
            else
            {
                Console.WriteLine("Invalid choice!");
            }

            Console.WriteLine();

        } while (choice != 0);
    }

    // ================= BMI METHOD =================
    static void CalculateBMI()
    {
        Console.Write("Enter weight (kg): ");
        double weight = double.Parse(Console.ReadLine());

        Console.Write("Enter height (m): ");
        double height = double.Parse(Console.ReadLine());

        double bmi = weight / (height * height);

        string category;

        if (bmi < 18.5)
            category = "Underweight";
        else if (bmi < 23)
            category = "Normal weight";
        else if (bmi <= 27.5)
            category = "Overweight";
        else
            category = "Obese";

        Console.WriteLine($"BMI = {bmi:F2}");
        Console.WriteLine($"Category: {category}");
    }

    // ================= DISCOUNT METHOD =================
    static void CalculateDiscount()
    {
        Console.Write("Enter amount spent: ");
        double amount = double.Parse(Console.ReadLine());

        double rate;

        if (amount <= 100)
            rate = 0;
        else if (amount <= 500)
            rate = 5;
        else if (amount <= 1000)
            rate = 10;
        else
            rate = 20;

        double discount = amount * rate / 100;

        Console.WriteLine($"Discount rate: {rate}%");
        Console.WriteLine($"Discount amount: {discount:F2}");
    }

    // ================= MULTIPLICATION TABLE =================
    static void MultiplicationTable()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        for (int i = 1; i <= 12; i++)
        {
            Console.WriteLine($"{i}  {i * number}");
        }
    }
}*/



/*
Question 5:
Write a program that adds up to 5 unique words to a list. 
The user can enter ‘x’ to stop adding words. 
Once either 5 words are added or the user stops the program early, 
the words are listed and the total number of letters in the words are displayed.

Example:
Enter a word (or 'x' to stop): apple
Enter a word (or 'x' to stop): banana
Enter a word (or 'x' to stop): orange
Enter a word (or 'x' to stop): x

List of words:
- apple
- banana
- orange

Total number of letters: 16
*/

/*using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        List<string> words = new List<string>();
        int totalLetters = 0;

        while (words.Count < 5)
        {
            Console.Write("Enter a word (or 'x' to stop): ");
            string input = Console.ReadLine();

            if (input.ToLower() == "x")
            {
                break;
            }

            words.Add(input);
            totalLetters += input.Length;
        }

        // In danh sách từ
        Console.WriteLine("\nList of words:");
        foreach (string word in words)
        {
            Console.WriteLine("- " + word);
        }

        // Tổng số chữ cái
        Console.WriteLine($"\nTotal number of letters: {totalLetters}");
    }
}*/



/*
Question 6:
Write a program that simulates a number guessing game. 
It first generates a random number between 1 and 100. 
It then prompts the user to guess the correct number. 
The user can enter -1 to end the game, or the game will end after 5 tries.


Example:
Guess the number (between 1 and 100, or enter -1 to quit): 50
Too high!
Guess the number (between 1 and 100, or enter -1 to quit): 25
Too low!
Guess the number (between 1 and 100, or enter -1 to quit): 37
Too high!
Guess the number (between 1 and 100, or enter -1 to quit): 30
Congratulations! You guessed the correct number in 4 tries.

*/

using System;

class Program
{
    static void Main()
    {
        Random rand = new Random();
        int secretNumber = rand.Next(1, 101); // 1 đến 100

        int guess = 0;
        int tries = 0;
        int maxTries = 5;

        Console.WriteLine("Guess the number (between 1 and 100, or enter -1 to quit):");

        while (tries < maxTries)
        {
            Console.Write("Your guess: ");
            guess = int.Parse(Console.ReadLine());

            if (guess == -1)
            {
                Console.WriteLine("Game exited!");
                return;
            }

            tries++;

            if (guess > secretNumber)
            {
                Console.WriteLine("Too high!");
            }
            else if (guess < secretNumber)
            {
                Console.WriteLine("Too low!");
            }
            else
            {
                Console.WriteLine($"Congratulations! You guessed the correct number in {tries} tries.");
                return;
            }
        }

        Console.WriteLine($"Game over! The correct number was: {secretNumber}");
    }
}
