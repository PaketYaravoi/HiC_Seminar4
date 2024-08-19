using System;

class Program
{
    static void Main()
    {
        int num1 = 0;
        int num2 = 0;

        Console.Write("Enter integer: ");
        while (!int.TryParse(Console.ReadLine(), out num1))
        {
            Console.WriteLine("Input error!");
            Console.Write("Please restart enter: ");
        }

        Console.Write("enter the power of the number: ");
        while (!int.TryParse(Console.ReadLine(), out num2))
        {
            Console.WriteLine("Input error!");
            Console.Write("Please restart enter: ");
        }
        Console.WriteLine();


        int unswer = NumToThePow(num1, num2);
        Console.WriteLine($"number {num1} to thr power of {num2} = {unswer}");

        static int NumToThePow(int num, int pow)
        {
            int unswer = num;
            for (int i = 1; i < pow; i++)
            {
                unswer *= num;
            }
            return unswer;
        }

    }
}

