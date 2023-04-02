// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Clear();
Console.Write("Введите первое число : ");
string? num1 = Console.ReadLine();
Console.Write("Введите второе число : ");
string? num2 = Console.ReadLine();
if (num1 != null && num2 != null)
{
    int x = int.Parse(num1);
    int y = int.Parse(num2);
    if (x == y)
    {
        Console.WriteLine("Same");
    }
    if (x < y)
    {
        Console.WriteLine($"max= {y} min= {x}");
    }
    if (x > y)
    {
        Console.WriteLine($"max= {x} min= {y}");
    }
}