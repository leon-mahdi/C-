// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет


Console.WriteLine("Введите число от 1 до 7");
int number = Convert.ToInt32(Console.ReadLine());
if (number==6 || number==7)
{
    Console.WriteLine("Это выходной");
}
else
{
    if (number>7 || number<1)
    {
        Console.WriteLine("Вы ввели число вне интервала. Перезапустите программу и введите число в интервале от 1 до 7");
    }
    else
    {
        Console.WriteLine("Это будний");
    }
}