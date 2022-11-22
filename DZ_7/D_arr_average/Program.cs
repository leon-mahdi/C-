// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

Console.WriteLine("Введите количество строк ");
int rows = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество столбцов ");
int columns = int.Parse(Console.ReadLine());

int[,] matrix = new int[rows, columns];

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        matrix[i, j] = new Random().Next(11);
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine("Среднее арифметическое");
Console.WriteLine();
double[] sum = new double[rows];
double average = 0;
for (int j = 0; j < rows; j++)
{
    sum[j] = 0;
    for (int i = 0; i < columns; i++)
    {
        sum[j] += matrix[i, j];
    }
    average = sum[j] / rows;
    Console.Write(average + "\t");
}
