﻿// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


// Мой вариант сработает ТОЛЬКО ДО 99 999, А ПОТОМ НУЖНО ОПЯТЬ ДОБАВЛЯТЬ УСЛОВИЕ. А ЕСТЬ УНИВЕРСАЛЬНЫЙ ВАРИАНТ?


// Обратите внимание на условие задачи и примеры к ней. Там отсчёт должен идти не с конца, как Вы решили на семинаре, а с начала?

// Пытался написать через string, но не знаю, что делать с числами, у которых нет третьей цифры. 
//По сути, тогда ведь мы запрашиваем у программы число с индексом 2, а массив короче.

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
