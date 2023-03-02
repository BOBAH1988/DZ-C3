// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.WriteLine("Введите 5ти значное число: ");
// int value = Convert.ToInt32(Console.ReadLine());
// int a = value / 10000;
// int b = (value / 1000) % 10;
// int d = (value / 10) % 10;
// int e = value % 10;

// if(value > 9999 && value < 100000)
// {
//     if(a == e && d == b)
//     {
//     Console.WriteLine("Да");
//     }
//     else
//     {
//         Console.WriteLine("Нет");
//     }
// }

// else
// {
//     Console.WriteLine("Вы ввели не верное число!");
// }

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.Write("Введите координату Х1: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату Y1: ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату Z1: ");
// int z1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите координату Х2: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату Y2: ");
// int y2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату Z2: ");
// int z2 = Convert.ToInt32(Console.ReadLine());

// double d = Math.Round(Math.Sqrt(Math.Pow(x1-x2, 2) + Math.Pow(y1-y2, 2) + Math.Pow(z1-z2, 2)), 2);

// Console.WriteLine(d);


// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

