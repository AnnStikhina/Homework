// Напишите программу, которая на вход принимает число и выдает , является ли число четным
Console.Clear();
Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());
if (a % 2 == 0) Console.WriteLine ("Число является ЧЕТНЫМ");
else Console.WriteLine("Число является НЕЧЕТНЫМ");
