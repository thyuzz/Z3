﻿/* Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());
int i = 1;

while (i <= N) {
    Console.Write(Math.Pow(i, 3));
    Console.Write(" ");
    i++;
}