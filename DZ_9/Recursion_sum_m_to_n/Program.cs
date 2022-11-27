// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите начальное число");
int M = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите конечное число");
int N = Convert.ToInt32(Console.ReadLine());

int PrintSum(int start, int end)
{

    if (start == end)
    {
        return end;
    }
    int sum = start + PrintSum(start + 1, end);
    return sum;

}

Console.WriteLine(PrintSum(M, N));