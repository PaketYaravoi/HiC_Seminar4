// Напишите программу которая принимает на вход число и выдает сумму цифр в числе.
// 452 ->  11
// 82 ->   10
// 9012 -> 12

using System;

class Progtram
{
    static void Main()
    {
        Console.Write("Enter integer: ");
        string input = Console.ReadLine()!;

        int numberFromStr = int.Parse(input);


        int sum2 = GetSumFromNum(numberFromStr);
        Console.WriteLine($"metod2 FromNumber = {sum2}");
        Console.WriteLine();

        int sum = GetSum(input);
        Console.WriteLine(sum);
        Console.WriteLine();

        static int GetSumFromNum(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                sum += number % 10;
                number /=10;
            }
            return sum;
        }

        //static int GetSum(string input)
        //{
        //    int sum = 0;
        //    foreach (char digit in input)
        //    {
        //        sum += int.Parse(digit.ToString());   метод цикла foreach на примере.
        //    }
        //    return sum;
        //}

        static int GetSum(string input)
        { 
            int sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                sum += int.Parse(input[i].ToString());     // разбивка строки на элементы(Int) без использования метода Split()
            }
            return sum;
        }
  
    }

}