//Part 1
//Create a list of 5 names and then print them out to the console.
//Hint: You can use the Add() method to add items to the list and then use a foreach loop to print them out to the console.

/*using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main()
    {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;
        // Tạo list
        List<string> names = new List<string>();

        // Thêm 5 tên
        names.Add("An");
        names.Add("Binh");
        names.Add("Chi");
        names.Add("Dung");
        names.Add("Huy");

        // In ra bằng foreach
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }

        //Part 2
        //Using the list of names and find the name in the 3rd position and print it out to the console.
        //Hint: You can use the index of the list to find the name in the 3rd position.
        // Tìm tên ở vị trí thứ 3 (index 2)


        string thirdName = names[2];
        Console.WriteLine("Tên ở vị trí thứ 3: " + thirdName);


        //Part 3
        //Using the list of names, remove the name in the 2nd position and then print the list out to the console.
        //Hint: You can use the RemoveAt() method to remove an item from the list.
        // Xóa tên ở vị trí thứ 2 (index 1)


        names.RemoveAt(1);
        // In lại danh sách sau khi xóa
        Console.WriteLine("Danh sách sau khi xóa:");
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }

        //Part 4
        //Using the list of names, add a new name to the list and then print the list out to the console.
        //Hint: You can use the Add() method to add a new name to the list.
        // Thêm một tên mới


        names.Add("Lan");
        // In lại danh sách sau khi thêm
        Console.WriteLine("Danh sách sau khi thêm:");
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }


        //Part 5
        //Using the list of names , find the length of the list and print it out to the console.
        //Hint: You can use the Count property to find the length of the list.
        // Tìm độ dài của danh sách


        int length = names.Count;
        Console.WriteLine("Độ dài của danh sách: " + length);

        //Part 6
        //Using the list of names , check if a name exists in the list and print out if it exists or not.
        //Hint: You can use the Contains() method to check if a name exists in the list.
        // Kiểm tra nếu tên "Chi" tồn tại trong danh sách


        string nameToCheck = "Lan";
        if (names.Contains(nameToCheck))
        {
            Console.WriteLine(nameToCheck + " tồn tại trong danh sách.");
        }
        else
        {
            Console.WriteLine(nameToCheck + " không tồn tại trong danh sách.");
        }

        //Part 7
        //Using the list of names, find the index of a name in the list and print it out to the console.
        //Hint: You can use the IndexOf() method to find the index of a name in the list.
        // Tìm index của tên "Dung"


        string nameToFind = "Lan";
        int index = names.IndexOf(nameToFind);
        if (index != -1)
        {
            Console.WriteLine("Index của " + nameToFind + ": " + index);
        }
        else
        {
            Console.WriteLine(nameToFind + " không tồn tại trong danh sách.");
        }

        //Part 8
        //Using the list of names, insert a new name at the 3rd position and print the list out to the console.
        //Hint: You can use the Insert() method to insert a new name at a specific position in the list.
        // Chèn một tên mới vào vị trí thứ 3 (index 2)
        names.Insert(2, "Minh");
        // In lại danh sách sau khi chèn


        Console.WriteLine("Danh sách sau khi chèn:");
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }

        //Part 9
        //Using the list of names, sort the list and print it out to the console.
        //Hint: You can use the Sort() method to sort the list.
        // Sắp xếp danh sách
        names.Sort();
        // In lại danh sách sau khi sắp xếp
        Console.WriteLine("Danh sách sau khi sắp xếp:");
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }


        //Part 10
        //Using the list of names , use findlastindex() method to find the last index of a name in the list and print it out to the console.
        //Hint: You can use the FindLastIndex() method to find the last index of a name in the list.
        // Tìm index cuối cùng của tên "Minh"
        int lastIndex = names.FindLastIndex(name => name == "Lan");
        if (lastIndex != -1)
        {
            Console.WriteLine("Index cuối cùng của Lan: " + lastIndex);
        }
        else
        {
            Console.WriteLine("Lan không tồn tại trong danh sách.");
        }



        //Part 11
        //Using the list of names, clear the list and print the list out to the console.
        //Hint: You can use the Clear() method to clear the list.
        // Xóa tất cả các tên trong danh sách
        names.Clear();
        // In lại danh sách sau khi xóa
        Console.WriteLine("Danh sách sau khi xóa:");
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
    }
}*/
//Part 12
//Create a new list of strings and integers and print them out to the console.
//Hint: You can use the Add() method to add items to the list and then use a foreach loop to print them out to the console.

using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main()
    {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;
        // List chứa chuỗi
        List<string> names = new List<string>();
        names.Add("An");
        names.Add("Binh");
        names.Add("Chi");

        // List chứa số nguyên
        List<int> numbers = new List<int>();
        numbers.Add(1);
        numbers.Add(2);
        numbers.Add(3);

        // In list string
        Console.WriteLine("Danh sách tên:");
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }

        // In list int
        Console.WriteLine("Danh sách số:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}



