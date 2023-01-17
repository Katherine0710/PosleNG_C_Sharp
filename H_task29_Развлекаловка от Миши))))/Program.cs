// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

using System;

class Program 
{
    static void Main()
    {   
        int[] arr = new int[8];
        int i = 0;
        for (;;)
        {
            try {
                arr[i] = new Random().Next();
                Console.WriteLine(arr[i]);
            }
            catch{
                break;
            }
            i++;
        }
    }
}