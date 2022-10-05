// напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел
Console.Clear;
Console.WriteLine("Введите три числа");
int a1 = int.Parse (Console.ReadLine());
int a2 = int.Parse (Console.ReadLine());
int a3 = int.Parse (Console.ReadLine());
int max = a1;
if (a2 > max ) max = a2;
if (a3 > max ) max = a3;
Console.WriteLine ("Максимальное из трех чисел =" + max);
