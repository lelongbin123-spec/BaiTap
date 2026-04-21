
//**Arrays unlike lists have a fixed size and cannot be changed once they are created.**//


//---------------------------------------------------------------------
// Part 1: Printing Array Elements
// Create an array of 5 countries and then print them out to the console.
// Hint: Use a foreach loop to print the array elements.

// Array names = new string[5] { "John", "Jane", "Jack", "Jill", "James" };
// foreach (string name in names)
// {
//     Console.WriteLine(name);
// }

using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        // Tạo mảng 5 quốc gia
        string[] countries = { "Vietnam", "USA", "Japan", "Korea", "France" };

        // In ra bằng foreach
        foreach (string country in countries)
        {
            Console.WriteLine(country);
        }


        //---------------------------------------------------------------------
        // Part 2: Accessing Array Elements by Index
        // Using the array of countries, find the name in the 3rd position and print it out to the console.
        // Hint: Use the index of the array to access the name in the 3rd position.

        // Truy cập phần tử ở vị trí thứ 3 (index 2)
        string thirdCountry = countries[2];

        Console.WriteLine("Quốc gia thứ 3 là: " + thirdCountry);

        //---------------------------------------------------------------------
        // Part 3: Removing an Element from the Array
        // Using the array of countries, remove the name in the 2nd position and then print the array out to the console.
        // Hint: Use the RemoveAt() method to remove an item from the array.

        // Mảng có kích thước cố định, không thể xóa phần tử trực tiếp
        // Thay vào đó, chúng ta sẽ tạo một mảng mới mà không bao gồm phần tử cần xóa
        string[] newCountries = new string[countries.Length - 1];
        int index = 0;
        for (int i = 0; i < countries.Length; i++)
        {
            if (i != 1) // Bỏ qua phần tử ở vị trí thứ 2 (index 1)
            {
                newCountries[index] = countries[i];
                index++;
            }
        }
        // In ra mảng mới sau khi đã loại bỏ phần tử
        Console.WriteLine("Mảng sau khi loại bỏ phần tử ở vị trí thứ 2:");
        foreach (string country in newCountries)
        {
            Console.WriteLine(country);
        }

        //---------------------------------------------------------------------
        // Part 4: Replacing an Element in the Array
        // Using the array of countries, replace the name in the 3rd position with a new name and then print the array out to the console.
        // Hint: Use the index of the array to replace the name in the 3rd position with a new name.

        // Thay thế phần tử ở vị trí thứ 3 (index 2) bằng một tên mới
        countries[2] = "Germany";
        // In ra mảng sau khi đã thay thế phần tử
        Console.WriteLine("Mảng sau khi thay thế phần tử ở vị trí thứ 3:");
        foreach (string country in countries)
        {
            Console.WriteLine(country);
        }

        //---------------------------------------------------------------------
        // Part 5: Finding the Length of the Array
        // Using the array of countries, find the length of the array and print it out to the console.
        // Hint: Use the Length property to find the length of the array.

        // Tìm độ dài của mảng
        int length = countries.Length;
        Console.WriteLine("Độ dài của mảng là: " + length);


        //---------------------------------------------------------------------
        // Part 6: Checking if an Element Exists in the Array
        // Using the array of countries, check if a name exists in the array and print out if it exists or not.
        // Hint: Use the Contains() method to check if a name exists in the array.

        // Kiểm tra nếu một tên tồn tại trong mảng

        string search = "USA";

        if (countries.Contains(search))
        {
            Console.WriteLine("Tên tồn tại trong mảng");
        }
        else
        {
            Console.WriteLine("Tên không tồn tại trong mảng");
        }

        //---------------------------------------------------------------------
        // Part 7: Finding the Index of an Element in the Array
        // Using the array of countries, find the index of a name in the array and print it out to the console.
        // Hint: Use the IndexOf() method to find the index of a name in the array.

        // Tìm chỉ số của một tên trong mảng
        string newSearch = "France";

        int indexOfSearch = Array.IndexOf(countries, newSearch);

        if (indexOfSearch != -1)
        {
            Console.WriteLine("Chỉ số của " + newSearch + " là: " + indexOfSearch);
        }
        else
        {
            Console.WriteLine(newSearch + " không tồn tại trong mảng");
        }
    }
}

