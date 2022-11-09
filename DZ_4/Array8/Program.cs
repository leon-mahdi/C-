// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]




// Этот вариант будет принимать элементы от пользователя




int[]array = GetArray (8);

int [] GetArray (int size)
{
    int[]array = new int [8];

    Console.WriteLine("Поочерёдно введите элементы массива");

    for(int i=0; i<8; i++)
    {
        array[i] = int.Parse(Console.ReadLine());
    }

    return array;

}

Console.WriteLine("[" + String.Join(",", array)+ "]");


