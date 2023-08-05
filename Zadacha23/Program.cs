// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Enter number N : ");
int N = int.Parse(Console.ReadLine());
int i=1;

while (N>=i)
{
 System.Console.WriteLine($"{i*i*i}");
 i++;
}