//  Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.Clear();
Console.Write("Input number ");
string num = Console.ReadLine();
if (num != null)
{
    int x = int.Parse(num);

    if (x % 2 == 0)
    {
        Console.WriteLine("Четное");
    }
    else
    {
        Console.WriteLine("НЕ четное");
    }
}

