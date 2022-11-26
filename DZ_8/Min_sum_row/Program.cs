// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.WriteLine("Введите количество строк ");
int rows = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество столбцов ");
int columns = int.Parse(Console.ReadLine());

int sum = 0;

int sumRes = int.MaxValue;

int minSumRow = 0;

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);

        }

    }
    return result;
}

void PrintArray(int[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write(inputArray[i, j] + "\t");
            sum = sum + inputArray[i, j];
        }
        if (sum < sumRes)
        {
            sumRes = sum;
            minSumRow = i + 1;
        }
        Console.WriteLine("Сумма равна " + sum);
        sum = 0;
    }
    Console.WriteLine();
    Console.WriteLine("Номер строки с минимальной суммой элементов " + minSumRow);
}


int[,] array2 = GetArray(rows, columns, 1, 100);

PrintArray(array2);

