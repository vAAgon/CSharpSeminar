// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Clear();
Console.Write("Введите чесло :");
int num = Convert.ToInt32(Console.ReadLine());
int extra = 2;

if (num > 1)
{
    while (extra <= num)
    {
        Console.WriteLine(extra + " ");
        extra = extra + 2;  
    }

}






