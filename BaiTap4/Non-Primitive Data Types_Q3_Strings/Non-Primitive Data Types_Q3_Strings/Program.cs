// To test out your code , comment the other parts and uncomment the part you want to test.
//To comment a part, select the part and press Ctrl + K + C
//To uncomment a part, select the part and press Ctrl + K + U
//Press Ctrl + F5 to run the code.




//Part 1
//Create a program so that it concatenates three strings and then outputs the result in uppercase.
//Hint: You can use the ToUpper() method to convert a string to uppercase.
//Hint: You can use the Console.WriteLine() method to output the result.

/*using System;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        string str1 = "Hello";
        string str2 = " ";
        string str3 = "World";

        // Nối chuỗi
        string result = str1 + str2 + str3;

        // In ra chữ in hoa
        Console.WriteLine(result.ToUpper());


        //Part 2
        //Create a program so that it concatenates three strings and then outputs the result in lowercase.
        //Hint: You can use the ToLower() method to convert a string to lowercase.
        //Hint: You can use the Console.WriteLine() method to output the result.

        string str4 = "HELLO";
        string str5 = " ";
        string str6 = "WORLD";
        // Nối chuỗi
        string result2 = str4 + str5 + str6;
        // In ra chữ in thường
        Console.WriteLine(result2.ToLower());

        //Part 3
        //Write a program to find the length of a string.
        //Hint: You can use the Length property to find the length of a string.
        //Hint: You can use the Console.WriteLine() method to output the result.

        // Tìm độ dài của chuỗi
        int length = result.Length;
        // In ra độ dài
        Console.WriteLine("Length of the string: " + length);

        //Part 4
        //Write a program to find the index of a character in a string.
        //Hint: You can use the IndexOf() method to find the index of a character in a string.
        //Hint: You can use the Console.WriteLine() method to output the result.

        char characterToFind = 'o';
        // Tìm chỉ số của ký tự
        int index = result.IndexOf(characterToFind);
        // In ra chỉ số
        Console.WriteLine("Index of '" + characterToFind + "': " + index);


        //Part 5
        //Write a program to find the index of a character in a string starting from a specified position.
        //Hint: You can use the IndexOf() method to find the index of a character in a string starting from a specified position.
        //Hint: You can use the Console.WriteLine() method to output the result.

        int startIndex = 5;
        // Tìm chỉ số của ký tự bắt đầu từ vị trí chỉ định
        int indexFromPosition = result.IndexOf(characterToFind, startIndex);
        // In ra chỉ số
        Console.WriteLine("Index of '" + characterToFind + "' starting from index " + startIndex + ": " + indexFromPosition);


        //Part 6
        //Write a program to count the occurrences of a specific character in a string.
        //Hint: You can use the Count() method to count the occurrences of a specific character in a string.
        //Hint: You can use the Console.WriteLine() method to output the result.

        char characterToCount = 'o';
        // Đếm số lần xuất hiện của ký tự
        int count = result.Count(c => c == characterToCount);
        // In ra số lần xuất hiện
        Console.WriteLine("Occurrences of '" + characterToCount + "': " + count);


        //Part 7
        //Write a program to replace a character in a string with another character.
        //Hint: You can use the Replace() method to replace a character in a string with another character.
        //Hint: You can use the Console.WriteLine() method to output the result.

        char characterToReplace = 'e';
        char replacementCharacter = 'x';
        // Thay thế ký tự
        string replacedString = result.Replace(characterToReplace, replacementCharacter);
        // In ra chuỗi sau khi thay thế
        Console.WriteLine("String after replacement: " + replacedString);


        //Part 8
        //Write a program to remove a character from a string.
        //Hint: You can use the Remove() method to remove a character from a string.
        //Hint: You can use the Console.WriteLine() method to output the result.

        int indexToRemove = 4; // vị trí cần xóa (ký tự 'o')

        string removedString = result.Remove(indexToRemove, 1);

        Console.WriteLine("Chuỗi sau khi xóa: " + removedString);


        //Part 9
        //Write a program to replace all occurrences of a specific character in a string with another character.
        //Hint: You can use the Replace() method to remove all occurrences of a specific character from a string.
        //Hint: You can use the Console.WriteLine() method to output the result.

        char characterToReplaceAll = 'o';
        char replacementCharacterAll = 'x';
        // Thay thế tất cả các ký tự
        string replacedAllString = result.Replace(characterToReplaceAll, replacementCharacterAll);
        // In ra chuỗi sau khi thay thế
        Console.WriteLine("String after replacing all occurrences: " + replacedAllString);


        //Part 10
        //Write a program to extract a substring from a string.
        //Hint: You can use the Substring() method to extract a substring from a string.
        //Hint: You can use the Console.WriteLine() method to output the result.

        int startIndexSubstring = 6; // vị trí bắt đầu
        int lengthSubstring = 5; // độ dài của substring
        string substring = result.Substring(startIndexSubstring, lengthSubstring);
        Console.WriteLine("Extracted substring: " + substring);


        //Part 11
        //Write a program to extract a substring from a string starting from a specified position.
        //Hint: You can use the Substring() method to extract a substring from a string starting from a specified position.
        //Hint: You can use the Console.WriteLine() method to output the result.

        int startIndexSubstring2 = 3; // vị trí bắt đầu
        string substringFromPosition = result.Substring(startIndexSubstring2);
        Console.WriteLine("Extracted substring from position: " + substringFromPosition);


        //Part 12
        //Write a program to remove leading and trailing whitespace from a string.
        //Hint: You can use the Trim() method to remove leading and trailing whitespace from a string.
        //Hint: You can use the Console.WriteLine() method to output the result.

        string stringWithWhitespace = "   Hello World   ";
        string trimmedString = stringWithWhitespace.Trim();
        Console.WriteLine("String after trimming: '" + trimmedString + "'");


        //Part 13 
        //Write a program to parse a string to a number.
        //Hint: You can use the Parse() method to parse a string to a number.
        //Hint: You can use the Console.WriteLine() method to output the result.

        string numberString = "12345";
        int parsedNumber = int.Parse(numberString);
        Console.WriteLine("Parsed number: " + parsedNumber);


        //Part 14
        //Write a program to convert a number to a string.
        //Hint: You can use the ToString() method to convert a number to a string.
        //Hint: You can use the Console.WriteLine() method to output the result.

        int number = 67890;
        string numberToString = number.ToString();
        Console.WriteLine("Number converted to string: " + numberToString);
    }
}*/









//////////////////Formating////////////////////





// Part 1

// You're organizing a team outing and need to print personalized event invitations.
// Develop a C# program that uses placeholders to create customized invitations.
// Replace the placeholders with the recipient's name, event date, and current time.
// Hint: Use composite formatting with placeholders to create personalized invitations.
// Test Data:
// Recipient's name: Alice
// Event date: January 15, 2025
// Expected Output:
// Hello, Alice! You're invited to our team outing on January 15, 2025. The event starts at 09:00.


/*using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        string name = "Alice";
        string date = "January 15, 2025";
        string time = "09:00";

        Console.WriteLine(
            "Hello, {0}! You're invited to our team outing on {1}. The event starts at {2}.",
            name, date, time
        );
    }
}
*/




// Part 2

// Imagine you're managing an online store and need to send order confirmation emails.
// Write a C# program that utilizes placeholders to generate order confirmation emails.
// Fill in the placeholders with the customer's name, order ID, and purchase details.
// Hint: Use composite formatting with placeholders to generate order confirmation emails.
// Test Data:
// Customer's name: John Doe
// Order ID: 123456
// Purchase details: 2 x T-shirts, 3 x Jeans
// Expected Output:
// Dear John Doe, your order (ID: 123456) has been confirmed. You've purchased: 2 x T-shirts, 3 x Jeans.

/*
using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        string customerName = "John Doe";
        int orderId = 123456;
        string details = "2 x T-shirts, 3 x Jeans";

        Console.WriteLine(
            "Dear {0}, your order (ID: {1}) has been confirmed. You've purchased: {2}.",
            customerName, orderId, details
        );
    }
}*/






// Part 3

// Picture yourself developing a task management application and need to display task reminders.
// Create a C# program that employs placeholders to format task reminder messages.
// Populate the placeholders with the task name, due date, and priority level.
// Hint: Use composite formatting with placeholders to format task reminder messages.
// Test Data:
// Task name: Complete Project Proposal
// Due date: May 10, 2025
// Priority level: High
// Expected Output:
// Reminder: Complete Project Proposal is due on May 10, 2025. Priority: High.

/*using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        string taskName = "Complete Project Proposal";
        string dueDate = "May 10, 2025";
        string priority = "High";

        Console.WriteLine(
            "Reminder: {0} is due on {1}. Priority: {2}.",
            taskName, dueDate, priority
        );
    }
}*/







// Part 4

// You're working on a scheduling application and need to generate event reminders.
// Develop a C# program that utilizes placeholders to format event reminder notifications.
// Fill in the placeholders with the event title, location, and start time.
// Hint: Use composite formatting with placeholders to format event reminder notifications.
// Test Data:
// Event title: Team Meeting
// Location: Conference Room A
// Start time: 10:00 AM
// Expected Output:
// Reminder: Team Meeting at Conference Room A starts at 10:00 AM.


/*using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        string title = "Team Meeting";
        string location = "Conference Room A";
        string time = "10:00 AM";

        Console.WriteLine(
            "Reminder: {0} at {1} starts at {2}.",
            title, location, time
        );
    }
}
*/








// Part 5

// Imagine you're designing a travel app and need to provide flight departure information.
// Write a C# program that employs placeholders to format flight departure notifications.
// Populate the placeholders with the flight number, departure airport, and scheduled time.
// Hint: Use composite formatting with placeholders to format flight departure notifications.
// Test Data:
// Flight number: ABC123
// Departure airport: JFK International Airport
// Scheduled time: 08:30 AM
// Expected Output:
// Flight ABC123 departing from JFK International Airport is scheduled for 08:30 AM.


/*using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        string flightNumber = "ABC123";
        string airport = "JFK International Airport";
        string time = "08:30 AM";

        Console.WriteLine(
            "Flight {0} departing from {1} is scheduled for {2}.",
            flightNumber, airport, time
        );
    }
}*/











// Part 6

// You're developing a messaging application and want to greet the user.
// Write a C# program that asks the user to enter their name.
// Then, use interpolation to display a personalized greeting message.
// Hint: Use the Console.ReadLine() method to get user input and string interpolation to format the message.
// Test Data:
// Enter your name: Alice
// Expected Output:
// Hello, Alice! Welcome to our messaging app.


/*using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.Write("Nhập tên của bạn: ");
        string name = Console.ReadLine();

        Console.WriteLine($"Hello, {name}! Welcome to our messaging app.");
    }
}
*/








// Part 7

// You're organizing a fantasy-themed event and need to print custom badges for the participants.
// Develop a C# program that prompts the user to enter their character's name and class.
// Then, concatenate the name and class, and print the result.
// Hint: Use the + operator to concatenate strings and the Console.WriteLine() method to print the result.
// Test Data:
// Character's name: Legolas
// Character's class: Archer
// Expected Output:
// Custom Badge: Legolas the Archer

/*using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.Write("Nhập tên nhân vật: ");
        string name = Console.ReadLine();

        Console.Write("Nhập class: ");
        string characterClass = Console.ReadLine();

        string badge = "Custom Badge: " + name + " the " + characterClass;

        Console.WriteLine(badge);
    }
}
*/









// Part 8

// Picture yourself managing a music playlist and need to display the total duration of a song.
// Write a C# program that calculates and formats the total duration of a song in minutes and seconds.
// Prompt the user to enter the song's duration in seconds.
// Then, calculate the minutes and seconds and display the formatted duration.
// Hint: Use integer division and modulus to separate minutes and seconds, and composite formatting to display them.
// Test Data:
// Enter the song's duration in seconds: 245
// Expected Output:
// Song Duration: 4 minutes 5 seconds

/*using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.Write("Nhập thời lượng (giây): ");
        int totalSeconds = int.Parse(Console.ReadLine());

        int minutes = totalSeconds / 60;
        int seconds = totalSeconds % 60;

        Console.WriteLine(
            "Song Duration: {0} minutes {1} seconds",
            minutes, seconds
        );
    }
}*/






// Part 9

// Imagine you're developing a recipe app and want to display the serving size.
// Create a C# program that formats and displays the serving size of a recipe.
// Prompt the user to enter the number of servings.
// Then, display the serving size aligned to the right with a width of 5 characters.
// Hint: Use composite formatting with alignment to display the serving size.
// Test Data:
// Enter the number of servings: 8
// Expected Output:
// Serving Size:     8


/*using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.Write("Nhập số khẩu phần: ");
        int servings = int.Parse(Console.ReadLine());

        Console.WriteLine("Serving Size: {0,5}", servings);
    }
}
*/






// Part 10

// You're designing a finance application and need to show the current account balance.
// Develop a C# program that formats and displays the account balance.
// Prompt the user to enter the account balance.
// Then, display the balance aligned to the right with two decimal places.
// Hint: Use composite formatting with alignment and precision to display the account balance.
// Test Data:
// Enter the account balance: 1050.75
// Expected Output:
// Account Balance: 1050.75


/*using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.Write("Nhập số dư tài khoản: ");
        double balance = double.Parse(Console.ReadLine());

        Console.WriteLine("Account Balance: {0,10:F2}", balance);
    }
}
*/





// Part 11

// You're building a movie ticket booking system and need to present the ticket price.
// Write a C# program that calculates and formats the ticket price with discounts.
// Prompt the user to enter the ticket price and discount percentage.
// Then, calculate the discounted price and display it aligned to the right with two decimal places.
// Hint: Use composite formatting with alignment and precision to display the discounted price.
// Test Data:
// Enter the ticket price: 25.50
// Enter the discount percentage: 15
// Expected Output:
// Discounted Price: 21.68


/*using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.Write("Nhập giá vé: ");
        double price = double.Parse(Console.ReadLine());

        Console.Write("Nhập % giảm giá: ");
        double discount = double.Parse(Console.ReadLine());

        // Tính giá sau giảm
        double discountedPrice = price * (1 - discount / 100);

        Console.WriteLine("Discounted Price: {0,10:F2}", discountedPrice);
    }
}
*/





// Part 12

// Picture yourself developing a gaming platform and need to display the player's score.
// Create a C# program that formats and displays the player's score.
// Prompt the user to enter the player's score.
// Then, display the score aligned to the right with a width of 8 characters.
// Hint: Use composite formatting with alignment to display the player's score.
// Test Data:
// Enter the player's score: 10325
// Expected Output:
// Player's Score:   10325

/*using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.Write("Nhập điểm số: ");
        int score = int.Parse(Console.ReadLine());

        Console.WriteLine("Player's Score: {0,8}", score);
    }
}*/






// Part 13

// You're working on a data analysis tool and need to present the statistical results.
// Develop a C# program that formats and displays the average value of a dataset.
// Prompt the user to enter a series of numbers separated by spaces.
// Then, calculate the average value and display it aligned to the right with two decimal places.
// Hint: Use composite formatting with alignment and precision to display the average value.
// Test Data:
// Enter a series of numbers: 10 15 20 25 30
// Expected Output:
// Average Value: 20.00


/*using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.Write("Nhập dãy số: ");
        string input = Console.ReadLine();

        string[] parts = input.Split(' ');

        double sum = 0;
        int count = 0;

        foreach (string part in parts)
        {
            double number = double.Parse(part);
            sum += number;
            count++;
        }

        double average = sum / count;

        Console.WriteLine("Average Value: {0,10:F2}", average);
    }
}
*/






// Part 14

// Imagine you're designing a weather app and need to show the temperature forecast.
// Write a C# program that calculates and formats the average temperature.
// Prompt the user to enter the temperatures for three days separated by spaces.
// Then, calculate the average temperature and display it aligned to the right with one decimal place.
// Hint: Use composite formatting with alignment and precision to display the average temperature.
// Test Data:
// Enter temperatures for 3 days: 25.5 28.7 22.3
// Expected Output:
// Average Temperature: 25.5

/*using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.Write("Nhập nhiệt độ 3 ngày: ");
        string input = Console.ReadLine();

        string[] parts = input.Split(' ');

        double sum = 0;

        foreach (string part in parts)
        {
            sum += double.Parse(part);
        }

        double average = sum / parts.Length;

        Console.WriteLine("Average Temperature: {0,10:F1}", average);
    }
}
*/







// Part 15

// You're building a fitness tracker and need to present the daily step count.
// Create a C# program that formats and displays the total steps for a day.
// Prompt the user to enter the steps taken.
// Then, display the step count aligned to the right with a width of 6 characters.
// Hint: Use composite formatting with alignment to display the step count.
// Test Data:
// Enter the steps taken: 12345
// Expected Output:
// Step Count:  12345



using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.Write("Nhập số bước: ");
        int steps = int.Parse(Console.ReadLine());

        Console.WriteLine("Step Count: {0,6}", steps);
    }
}

