
Console.WriteLine("Введите количество элементов в массиве ");

int size = int.Parse(Console.ReadLine());

string[] array = new string[size];
int newSize = 0;
for (int i = 0; i < size; i++)
{
    Console.WriteLine("Введите элемент массива");
    array[i] = Console.ReadLine();
    if (array[i].Length <= 3)
    {
        newSize++;
    }
}
Console.WriteLine("Первоначальный массив [" + String.Join(",", array) + "]");

string[] newArray = new string[newSize];
int j = 0;
for (int i = 0; i < size; i++)
{

    if (array[i].Length <= 3)
    {
        newArray[j] = array[i];
        j++;
    }
}

Console.WriteLine("Итоговый массив [" + String.Join(",", newArray) + "]");