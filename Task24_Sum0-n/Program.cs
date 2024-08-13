// Задача 24: Напишите программу которая будет считать сумму от 0 до n
using System;

class Program
{
    static void Main()
    {
        int number = 0;
        Console.Write("Enter integer: ");

        while (!int.TryParse(Console.ReadLine(), out number))
        {
            Console.WriteLine("input error!");
            Console.Write("Please restart enter: ");
        }
        Console.WriteLine();
        
        Console.WriteLine($"sum to N = {SumToN(number)}");
        Console.WriteLine();

        Console.WriteLine($"Method2: sum to N = {FastSumFrom1ToN(number)}");
        Console.WriteLine();


        static int SumToN(int n)
        {
            int sum = 0;
            for (int i = 0; i <= n; i++)
            {
                sum += i;
                Console.WriteLine($"sum from 0 to {i} = {sum}");
            }
            Console.WriteLine();
            return sum;
        }

        static int FastSumFrom1ToN(int n)
        {
            return n * (n + 1) / 2; // просто , возвращаюем результат операции формулы нахождения суммы от 0 до N
        }
    }
}



