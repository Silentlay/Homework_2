/*
// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и
// k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
// */

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Программа для нахождения точки пересечения прямых.");

        // Ввод параметров для первой прямой
        Console.Write("Введите точку (b1): ");
        double b1 = double.Parse(Console.ReadLine());

        Console.Write("Введите точку (k1): ");
        double k1 = double.Parse(Console.ReadLine());

        // Ввод параметров для второй прямой
        Console.Write("Введите точку (b2): ");
        double b2 = double.Parse(Console.ReadLine());

        Console.Write("Введите точку (k2): ");
        double k2 = double.Parse(Console.ReadLine());

        // Находим точку пересечения
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;

        //Console.WriteLine($"Точка пересечения прямых: ({x}; {y})");
         Console.WriteLine($"{nameof(b2)} = {b2}, {nameof(k2)} = {k2} -> ({x:0.0; -0.0}; {y:0.0; -0.0})");
    }
}
