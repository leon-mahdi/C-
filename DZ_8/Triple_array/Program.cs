// Задача 60: Сформируйте трёхзначный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента

Console.WriteLine("Введите первый размер ");
int rows = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второй размер ");
int columns = int.Parse(Console.ReadLine());

Console.WriteLine("Введите третий размер ");
int cells = int.Parse(Console.ReadLine());


int[, ,] GetArray(int m, int n, int o, int min, int max)
{
    int[, ,] result = new int[m, n, o];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < o; k++)
            {
            result[i, j, k] = new Random().Next(min, max + 1);
            }
        }

    }
    return result;
}

void PrintArray(int[, ,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            for (int k = 0; k < inputArray.GetLength(2); k++ )
            {
            Console.Write(inputArray[i, j, k] +" " +(i,j,k) + "\t");
            }
            Console.WriteLine();
        }
              
    }
    
}

int[, ,] array = GetArray(rows, columns, cells, 10, 99);

PrintArray(array);
