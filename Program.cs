// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.Clear();
// Console.Write("Введите число: ");
// int n = int.Parse(Console.ReadLine()!);
// while(n < 10000 || n > 99999)
//     {
//     Console.Write("Вы ошиблись! \nВведите 5-значное число: ");
//     n = int.Parse(Console.ReadLine()!);
//     }
// int n1 = n / 10000;
// int n2 = n / 1000 % 10;
// int n4 = n % 100 / 10;
// int n5 = n % 10;
// if (n1 == n5 && n2 == n4) Console.Write($"{n} -> да");
// else Console.Write($"{n} -> нет");



// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.Clear();
// Console.Write("Координату X(1): ");
// double x1 = double.Parse(Console.ReadLine()!);
// Console.Write("Координату Y(1): ");
// double y1 = double.Parse(Console.ReadLine()!);
// Console.Write("Координату Z(1): ");
// double z1 = double.Parse(Console.ReadLine()!);
// Console.Write("Координату X(2): ");
// double x2 = double.Parse(Console.ReadLine()!);
// Console.Write("Координату Y(2): ");
// double y2 = double.Parse(Console.ReadLine()!);
// Console.Write("Координату Z(2): ");
// double z2 = double.Parse(Console.ReadLine()!);
// double S = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
// Console.WriteLine($"Расстояние равно {Math.Round(S, 2)}");

// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();
Console.Write("Ведите число: ");
int x = int.Parse(Console.ReadLine()!);
for (int i = 1; i <= x; i++)
    {
    double s = Math.Pow(i, 3);
    Console.Write ($" {s}");
    }