// Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.

Console.WriteLine("Введите количество строк ");
int rows = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество столбцов ");
int columns = int.Parse(Console.ReadLine());


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
        
        }
        
        Console.WriteLine();
    }
    
}

int[,] MultiplyArray(int[,] array, int[,] array2)
{
    int[,] result = new int[array.GetLength(0), array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            result[i, j] = array[i, j]*array2[i,j];
        }
    }
    return result;
}



int[,] array = GetArray(rows, columns, 1, 9);

int[,] array2 = GetArray(rows, columns, 1, 9);

Console.WriteLine("Первая матрица");
PrintArray(array);
Console.WriteLine("__________");
Console.WriteLine();
Console.WriteLine("Вторая матрица");
PrintArray(array2);
Console.WriteLine("__________");
Console.WriteLine();
Console.WriteLine("Результирующая матрица");
PrintArray(MultiplyArray(array, array2));