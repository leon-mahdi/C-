// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, 
// что такого элемента нет.

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
Console.WriteLine("Введите строку искомого элемента");
int x = int.Parse(Console.ReadLine());

Console.WriteLine("Введите столбец искомого элемента");
int y = int.Parse(Console.ReadLine());
if (x > rows || y > columns)
{
    Console.WriteLine("Позиция элемента указана неверно. Элемента с такой позицией нет.");
}
else
{
    Console.WriteLine("Элемент с искомой позицией равен " + matrix[x - 1, y - 1]);
}