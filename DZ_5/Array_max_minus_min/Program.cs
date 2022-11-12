// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

Console.WriteLine("Введите количество элементов в массиве ");

int size = int.Parse(Console.ReadLine());

int [] array = new int [size];

int min = 0;
int max = 0;


for (int i =0; i<size; i++)
{
    array[i] = new Random().Next(100);
    min=array[1];
    if(array[i]>=max)
    {
        max = array[i];
    }
    else
    {
        min = array[i];
    }
    
    Console.Write(array[i] + ", ");
    
}
int result = max - min;
Console.WriteLine();
Console.WriteLine("Разница между максимальным и минимальным элементов массива составляет " + result);