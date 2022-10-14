// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите первое число");
int number_1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int number_2 = Convert.ToInt32(Console.ReadLine());

int max = number_1;

if (number_2>max)
{
    Console.Write("Максимальное число ");
    Console.Write(number_2);
}
else
{
    Console.Write("Максимальное число ");
    Console.Write(number_1);
}