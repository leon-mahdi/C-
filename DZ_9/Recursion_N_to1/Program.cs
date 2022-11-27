// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
int end = 1;

string PrintNumber(int start)
{

    if (start == end)
    {
        return end.ToString();
    }
    return (start + ", " + PrintNumber(start-1));



}

Console.WriteLine(PrintNumber(N));