﻿//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

//4 -> да
//-3 -> нет
//7 -> нет



Console.WriteLine("Проверка чётности числа введённого пользователем");

Console.Write("Введите число: ");
int numberUser = Convert.ToInt32(Console.ReadLine());

if (numberUser % 2 == 0)
{
  Console.WriteLine("Чётное");
}
else
{
  Console.WriteLine("Нечётное");
}