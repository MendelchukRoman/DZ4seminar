﻿//Напишите метод(ы), которай задаёт массив из 8 элементов и выводит их на экран.
int [] numbers = new int[8];
Console.Write("[");
for (int i = 0; i < numbers.Length; i++)
 {
    numbers [i] = new Random().Next(0, 11);
    Console.Write(" " + Metod (i) + " ");
 }
Console.Write("]");
int Metod (int a)
{
    return numbers[a];
}
