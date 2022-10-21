// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число");
int N = int.Parse(Console.ReadLine());
int number = 1;
double cube = 0;
while (number<=N)
{
    cube = Math.Pow(number,3);
    Console.WriteLine(cube);
    number++;
}