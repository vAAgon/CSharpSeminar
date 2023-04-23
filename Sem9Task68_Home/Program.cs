Console.Clear();
//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.Write("Введите m: ");
if (!int.TryParse(Console.ReadLine(), out int m) || m < 0)
{
    Console.WriteLine("Ошибка ввода m.");
}

Console.Write("Введите n: ");
if (!int.TryParse(Console.ReadLine(), out int n) || n < 0)
{
    Console.WriteLine("Ошибка ввода n.");
}

Console.WriteLine($"A({m}, {n}) = {Ackermann(m, n)}");

int Ackermann(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (n == 0)
        return Ackermann(m - 1, 1);
    else
        return Ackermann(m - 1, Ackermann(m, n - 1));
}

