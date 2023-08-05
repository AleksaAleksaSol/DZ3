// Задача 21 (branch task_2)
// Напишите программу, которая принимает на вход координаты
// двух точек и находит расстояние между ними в 
// 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Координаты XA: ");
int XA = int.Parse(Console.ReadLine());

Console.WriteLine("Координаты YA: ");
int YA = int.Parse(Console.ReadLine());

Console.WriteLine("Координаты ZA: ");
int ZA = int.Parse(Console.ReadLine());

Console.WriteLine("Координаты XB: ");
int XB = int.Parse(Console.ReadLine());

Console.WriteLine("Координаты YB: ");
int YB = int.Parse(Console.ReadLine());

Console.WriteLine("Координаты ZB: ");
int ZB = int.Parse(Console.ReadLine());

int A = XB - XA;
int B = YB - YA;
int C = ZA - ZB;

double NumCordAB = Math.Sqrt(A * A + B * B + C * C);
Console.WriteLine($"Расстояние от А до В {NumCordAB}");
