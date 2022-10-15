// напишите программу, которая на вход принимает два числа и выдает, какое число больше, а какое меньше
Console.Write("введите первое число ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("введите второе число ");
int b = Convert.ToInt32(Console.ReadLine());

if (a < b )
{
    Console.WriteLine($"минимальное число = {a}, максимальное число = {b}");
}
else
{
    Console.WriteLine($"минимальное число = {b}, максимальное число = {a}");
}