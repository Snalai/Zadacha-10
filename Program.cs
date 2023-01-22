//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Write("Введите трёхзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());
int x;
if (a < 1000)
{
    int y = ((x = a % 100) - ((x = a % 100) % 10)) / 10;
    Console.WriteLine(y);
}
else
{
    Console.WriteLine("Число не трёхзначное");
}