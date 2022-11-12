// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

Console.WriteLine("Введите количество элементов в массиве ");

int size = Convert.ToInt32(Console.ReadLine());

int [] array = new int [size];

int sum = 0;

for (int i =0; i<size; i++)
{
    array[i]= new Random().Next(-100,101);
    if (i%2>0)
    {
        sum+=array[i];
    }

    Console.Write(array[i] + ", ");
}

Console.WriteLine();
Console.WriteLine("Сумма нечётных элементов массива равна " + sum);