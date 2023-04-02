// Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).

Console.Clear();
Console.Write("input num. :");
string? inLine = Console.ReadLine();
if (inLine != null)
{
    int number1 = int.Parse(inLine);
    int numberMath = (int)Math.Pow(number1,2);
    Console.WriteLine(number1 * number1);
    Console.WriteLine(numberMath);
}