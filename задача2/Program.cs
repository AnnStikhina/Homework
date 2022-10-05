// Напишите программу , которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее

Console.Clear();
Console.Write("ВВедите два числа");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
if (a > b) Console.WriteLine (первое число :" + a + " больше второго: "+ b");
else Console.WriteLine("первое число: " + a +" меньше второго " + b ");
