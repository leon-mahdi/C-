// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

Console.WriteLine("Введите количество элементов в массиве");
int size = int.Parse(Console.ReadLine());

int [] array = new int [size];

int len = array.Length%2;
// новая переменная понадобится для массива с нечентым количеством элементов

for (int i = 0; i<array.Length; i++)
{
    array [i] = new Random().Next(10);
}

Console.WriteLine("[" + String.Join(",", array)+"]");
// выводим первоначальный массив в красивом формате

int index = array.Length-1;
// потому что номерация элементов начинается с 0 и на 1 меньше длины

int [] result = new int [array.Length/2 + array.Length%2];
// новый массив в длину будет равен первоначальному, разделенному на два + на два с остатком(на случай,
// если количество элементов в массиве было нечетным) 7:2 + 7%2 = 3 + 1= 4


for (int i = 0; i<result.Length; i++)
{
    result[i] = array[i] * array[index - i];
// то есть умножаем первый и первый с конца

    if (i == index - i)
    {
        result[i] = array[i];
        // чтобы центральный элемент нечетного массива не уможался сам на себя
    }

    // Console.Write(result[i] +",");
    // выведется без скобок, некрасиво
}

Console.WriteLine("Новый массив [" + String.Join(",", result)+"]");
