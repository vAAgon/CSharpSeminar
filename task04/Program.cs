//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Clear();
Console.Write("First: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Second : ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Thirst: ");
int c = Convert.ToInt32(Console.ReadLine());
int max = 0;
if (a > max)
{
    max = a;
}
if (b > max)
{
    max = b;
}
if (c > max)
{
    max = c;
}

Console.WriteLine("max = " + max);

