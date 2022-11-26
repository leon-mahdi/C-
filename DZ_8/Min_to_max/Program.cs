// Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы 
// каждой строки двумерного массива.

Console.WriteLine("Введите количество строк ");
int rows = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество столбцов ");
int columns = int.Parse(Console.ReadLine());


int[,] matrix = new int[rows, columns];
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        matrix[i, j] = new Random().Next(20);
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        for (int k = 0; k < columns - 1; k++)
        {
            if (matrix[i, k + 1] > matrix[i, k])
            {
                int max = matrix[i, k + 1];
                matrix[i, k + 1] = matrix[i, k];
                matrix[i, k] = max;
            }
        }
    }
    Console.WriteLine();
}

void PrintArray(int[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write(inputArray[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

PrintArray(matrix);