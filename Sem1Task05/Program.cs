//Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.

Console.Clear();
Console.WriteLine("Введите число");
string? num = Console.ReadLine();
if (num != null)
{
    int lastnum = int.Parse(num);
    int firstnum = lastnum * -1;
    string res = string.Empty;
    while (firstnum <= lastnum)
    {
        res = res + firstnum + " ";
        firstnum++;
    }
    Console.WriteLine(res);
}