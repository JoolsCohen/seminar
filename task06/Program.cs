﻿// Напишите программу, которая на вход принимает число и выдает, является ли число четным (делится ли оно на два без остатка)
// 4 -> Да
// -3 -> Нет
// 7 -> Нет

Console.Write("введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 1)
{
  Console.Write("Число " + num + " является: НЕЧЁТНЫМ");
}
else
{
  Console.Write("Число " + num + " является: ЧЁТНЫМ");
}