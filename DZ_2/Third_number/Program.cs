// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

// НО ВЕДЬ СРАБОТАЕТ ТОЛЬКО ДО 99 999, А ПОТОМ НУЖНО ОПЯТЬ ДОБАВЛЯТЬ УСЛОВИЕ. А ЕСТЬ УНИВЕРСАЛЬНЫЙ ВАРИАНТ?

Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());
int num1 = number%10;

if (number/100>=1)
{
    if ((number<10000)&&(number>999))
    {
        num1 = number%100/10;
    }
    else 
    {
        if (number>9999)
        {
            num1 = number%1000/100;
        }
    }
    Console.WriteLine(num1);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}
