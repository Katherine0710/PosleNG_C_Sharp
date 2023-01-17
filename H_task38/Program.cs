// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

double[] array = new double[7];
Console.Write ("Массив: ");

for (int i = 0; i < 7; i++)
{
    array[i] = new Random().Next(100,1000);
    Console.Write (array[i] + " ");
}

double max = array[0];
double min = array[0];
for(int i = 1; i<7; i++)
{
    if (array[i]>max)
    {
        max = array[i];
    }
    if (array[i]<min)
    {
        min = array[i];
    }
}
Console.WriteLine ();
Console.WriteLine ("max: " + max);
Console.WriteLine ("min: " + min);

double razniza = max - min;
Console.WriteLine ("Разница междду max и min: " + razniza);