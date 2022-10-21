// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трёхзначное число");
int number = Convert.ToInt32(Console.ReadLine());
int num1 = number%100/10;
if ((number>99)&&(number<1000))
{
    Console.WriteLine($"Вторая цифра введённого числа " + num1);
}
else
{
    Console.WriteLine("Введённое число не трёхзначное");
}
