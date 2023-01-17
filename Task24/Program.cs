// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А
// 7 -> 28
//4 -> 10

Console.Write("Введите число а: ");
int a = Convert.ToInt32(Console.ReadLine());

int Sum (int number)
{
    int sum = 0;
    for (int i = 1; i <= a; i++)
    {
        sum+=i;
    }
    return sum;
}

int sum = Sum(a);
Console.WriteLine("Сумма: " + sum);