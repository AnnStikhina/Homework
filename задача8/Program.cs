// напишите программу , которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N
Console.Clear();
Console.WriteLine("Введите число");
int N = int.Parse(Console.ReadLine());
int I = 1;
Console.Write("Все четные числа в диапозоне от 1 до + N +");
while ( I <= N);
{
    if ( I % 2 == 0) Console.Write( I + " ");
    I = I + 1;
}