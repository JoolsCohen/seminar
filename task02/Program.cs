﻿// Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее
// a = 5; b = 7; max = 7
// a = 2; b = 10; max = 10
// a = -9; b = -3; max = -3

Console.Write("введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

int max = a;
int min = b;
if (a > b)
{
  max = a;
  min = b;
  Console.Write($"Максимальное число {max}, а Минимальное число {min}");
}
else
{
  max = b;
  min = a;
  Console.Write($"Максимальное число {max}, а Минимальное число {min}");
}