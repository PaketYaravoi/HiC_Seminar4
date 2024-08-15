// Напишите программу, которая принимает на вход число и выдает количество цифр в числе:
// 456 -> 3 

using System;

class Program
{
    static void Main()
    {
        int number = 0;

        Console.Write("Please enter integer: ");
        while (!int.TryParse(Console.ReadLine(), out number))
        { 
            Console.WriteLine("Input error!");
            Console.Write("Please restart enter: ");
        }

        string strFromN = GetStrFromNumber(number);
        Console.WriteLine(GetLenghthNumber(strFromN));
    }

    static string GetStrFromNumber(int number)
    { 
        string str = String.Empty;
        return str = number.ToString();
    }

    static int GetLenghthNumber(string str)
    {   
        int length = str.Length;
        return length;
        
    }

}
