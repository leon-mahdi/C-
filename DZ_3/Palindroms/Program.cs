// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.WriteLine("Введите число");
string text = Console.ReadLine();
bool palindrom (string text)
{
    int n = text.Length;
    for(int i=0;i<n/2;i++)
    {
        if (text[i]!=text[n-1-i])
        {
            return false;
        }
    }
    return true;
}
if (palindrom(text))
{
    Console.WriteLine("Палиндром");
}
else
{
        Console.WriteLine("Не палиндром");
}
