//Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.

Console.Clear();
Console.WriteLine("Input first namber :");
string numline = Console.ReadLine();
Console.WriteLine("input second namber :");
string numline1 = Console.ReadLine();
if (numline != null && numline1 != null)
{
    int num1 = int.Parse(numline);
    int num2 = int.Parse(numline1);
    if (num1 == (int)Math.Pow(num2,2))
    {
        Console.WriteLine("Квадрат - да");
    }
    else
    {
        Console.WriteLine("Квадрат - нет ");
    }


}
