// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

Console.WriteLine("Введите количество элементов в массиве ");

int size = int.Parse(Console.ReadLine());

int [] array = new int [size];

int count = 0;

for (int i = 0; i<size; i++)
{
    array[i] = new Random().Next(100,1000);
    if (array[i]%2==0)
    {
        count++;
    }
    Console.Write(array[i] + ", ");
}
Console.WriteLine();
Console.WriteLine("Количество чётных чисел в массиве " + count);


