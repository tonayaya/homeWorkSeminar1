// напишите программу, которая на вход принимает число и выдает, является ли число четнымым
Console.Write("введите любое число: ");
int x = Convert.ToInt32(Console.ReadLine());
if (x % 2 == 0)
{
    Console.WriteLine("число четное");
}
else
{
    Console.WriteLine("число не четное");
}