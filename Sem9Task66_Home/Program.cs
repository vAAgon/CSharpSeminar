Console.Clear();
// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.WriteLine("Введите значение M:");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение N:");
int n = Convert.ToInt32(Console.ReadLine());

int sum = 0;
for (int i = m; i <= n; i++)
{
    sum += i;
}

Console.WriteLine($"Сумма натуральных элементов от {m} до {n} равна {sum}.");