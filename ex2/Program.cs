// Напишите программу, которая принимает на вход три числа и выдает максимальное из трех чисел.
Console.Write("введите первое значение: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("введите второе значение: ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.Write("введите третье значение: ");
int numberC = Convert.ToInt32(Console.ReadLine());
int max = Math.Max(numberA,Math.Max(numberB,numberC));
Console.WriteLine($"максимальное число: {max}");
