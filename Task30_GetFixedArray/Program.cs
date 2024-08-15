// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

// [1,0,1,1,0,1,0,0]

using System;

class Program
{
    static void Main()
    {
        int[] array = new int[8];
        int rndNumber = GetRandomNum(0, 5);
        array = FillArray(array, GetRandomNum(0,5));
        PrintArray(array);

        
    }

    static int GetRandomNum(int value1, int value2)
    {
        int rnd = new Random().Next(value1, value2);
        return rnd;
    }

    static int[] FillArray(int[] arr, int rnd)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rnd;  
        }
        return arr;
    }

    static void PrintArray(int[] arr)
    {
        for (int i = 0; i < arr.Length -1; i++)
        { 
            Console.Write($"{arr[i]}, ");
        }
        Console.WriteLine($"{arr[7]}");
    }
    
                    
    
}
    
