// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.WriteLine("Введите количество строк ");
int rows = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество столбцов ");
int columns = int.Parse(Console.ReadLine());


int [,] matrix = new int [rows,columns];

for (int i =0; i<matrix.GetLength(0); i++) 
{
    for (int j =0; j<matrix.GetLength(1); j++)
    {
        matrix [i,j] = new Random().Next(101);
        Console.Write(matrix [i,j] + "\t");
    }
    Console.WriteLine();
}