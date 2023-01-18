// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] array = new int[7];
Console.Write ("Массив: ");

for (int i = 0; i < 7; i++)
{
    array[i] = new Random().Next(100,1000);
    Console.Write (array[i] + " ");
}

int number = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i]%2 == 0)
    {
        number++;
    }
}
Console.WriteLine();
Console.WriteLine("Количество чётных чисел в массиве: " + number);
