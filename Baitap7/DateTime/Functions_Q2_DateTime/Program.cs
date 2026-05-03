

//Part 1
//Write a C# program to add and subtract days from the date.
//Test Data:
//Enter the date: 12/10/2020
//Enter the number of days to add or subtract: 5
//Expected Output:
//Date after 5 days: 17/10/2020
//Date before 5 days: 07/10/2020

/*using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the date (dd/MM/yyyy): ");
        DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

        Console.Write("Enter the number of days to add or subtract: ");
        int days = int.Parse(Console.ReadLine());

        DateTime after = date.AddDays(days);
        DateTime before = date.AddDays(-days);

        Console.WriteLine("Date after " + days + " days: " + after.ToString("dd/MM/yyyy"));
        Console.WriteLine("Date before " + days + " days: " + before.ToString("dd/MM/yyyy"));
    }
}*/

//Part 2
//Write a C# program to take input from the user and calculate the age of the user.
//Test Data:
//Enter your date of birth: 12/10/1990
//Expected Output:
//You are 30 years, 1 months, 21 days old

/*using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.Write("Enter your date of birth (dd/MM/yyyy): ");
        DateTime dob = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

        DateTime today = DateTime.Now;

        int years = today.Year - dob.Year;
        int months = today.Month - dob.Month;
        int days = today.Day - dob.Day;

        // Nếu ngày âm → mượn tháng trước
        if (days < 0)
        {
            months--;
            DateTime previousMonth = today.AddMonths(-1);
            days += DateTime.DaysInMonth(previousMonth.Year, previousMonth.Month);
        }

        // Nếu tháng âm → mượn năm trước
        if (months < 0)
        {
            years--;
            months += 12;
        }

        Console.WriteLine($"You are {years} years, {months} months, {days} days old");
    }
}*/

//Part 3
//Write a C# program to take input from the user and calculate the difference between two dates.
//Test Data:
//Enter the first date: 12/10/2020
//Enter the second date: 16/10/2020
//Expected Output:
//The difference between two dates is: 4 days

/*using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.Write("Enter the first date (dd/MM/yyyy): ");
        DateTime date1 = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

        Console.Write("Enter the second date (dd/MM/yyyy): ");
        DateTime date2 = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

        // Tính khoảng cách giữa 2 ngày
        TimeSpan difference = date2 - date1;

        // Lấy số ngày (luôn dương)
        int days = Math.Abs(difference.Days);

        Console.WriteLine("The difference between two dates is: " + days + " days");
    }
}*/

//Part 4
//Write a C# program to take the input (days) from the user and Convert days into years, weeks and days.
//Test Data:
//Enter the number of days: 1329
//Expected Output:
//Years: 3
//Weeks: 33
//Days: 3

/*using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the number of days: ");
        int totalDays = int.Parse(Console.ReadLine());

        int years = totalDays / 365;
        int remainingDays = totalDays % 365;

        int weeks = remainingDays / 7;
        int days = remainingDays % 7;

        Console.WriteLine("Years: " + years);
        Console.WriteLine("Weeks: " + weeks);
        Console.WriteLine("Days: " + days);
    }
}*/

//Part 5
//Write a C# program to take the input from the user and print day name of week.
//Test Data:
//Enter the number of day: 4
//Expected Output:
//Thursday

/*using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the number of day: ");
        int day = int.Parse(Console.ReadLine());

        switch (day)
        {
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            case 4:
                Console.WriteLine("Thursday");
                break;
            case 5:
                Console.WriteLine("Friday");
                break;
            case 6:
                Console.WriteLine("Saturday");
                break;
            case 7:
                Console.WriteLine("Sunday");
                break;
            default:
                Console.WriteLine("Invalid day number");
                break;
        }
    }
}*/

//Part 6
//Write a C# Sharp program to retrieve the current date.
//Expected Output:
//The current date is: 12/10/2020

/*using System;

class Program
{
    static void Main()
    {
        DateTime currentDate = DateTime.Now;

        Console.WriteLine("The current date is: " + currentDate.ToString("dd/MM/yyyy"));
    }
}*/

//Part 7
//Write a C# program to retrieve the current date and time.
//Expected Output:
//The current date and time is: 12/10/2020 10:30:50

using System;

class Program
{
    static void Main()
    {
        DateTime now = DateTime.Now;

        Console.WriteLine("The current date and time is: "
            + now.ToString("dd/MM/yyyy HH:mm:ss"));
    }
}

