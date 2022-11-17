// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3


// Дополнительно вариант, где пользователь задает только количество чисел, а сами числа случайны



Console.WriteLine("Введите количество чисел");
int M = Convert.ToInt32(Console.ReadLine());

int count=0;

int [] array = GetArray(M);

int [] GetArray(int M)
{
    int [] array = new int [M];
    for (int i =0; i<M; i++)
    {
        array[i] = new Random().Next(-1000,1001);
        if (array[i] < 0)
        {
            count++;
        }
    }
    return array;
}

Console.WriteLine("[" + String.Join(",", array)+"]");

Console.WriteLine("Количество чисел менее 0: " + count);

