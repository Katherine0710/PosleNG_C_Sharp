// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. (без использования Math.Pow)

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите степень, в которую число будет возведено: ");
int b = Convert.ToInt32(Console.ReadLine());

int number = 1;

for (int i = 1; i <= b; i++)
{
    number = number * a;
}
Console.WriteLine(number);