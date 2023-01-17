// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] array = new int[7];
Console.Write ("Массив: ");

for (int i = 0; i < 7; i++)
{
    array[i] = new Random().Next(100,1000);
    Console.Write (array[i] + " ");
}

int sum = 0;

for (int i = 0; i < 7; i+=2)
{
    sum = sum + array[i];
}
Console.WriteLine ();
Console.WriteLine ("Сумма нечётных элементов массива: " + sum);
