Console.Clear();
// . Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает 
// значение этого элемента или же указание, что такого элемента нет.
// * Заполнить числами Фиббоначи и выделить цветом найденную цифру

Console.WriteLine("Введите номер строки");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите номер столбца");
int m = Convert.ToInt32(Console.ReadLine());

int[,] numbers = new int[10, 10];

Gen2DArr(numbers);

if (n > numbers.GetLength(0) || m > numbers.GetLength(1)) // проверка 
{
    Console.WriteLine("Такого элемента нет");
}
else
{
    Console.WriteLine($"Значение элемента {n} строки и {m} столбца равно {numbers[n - 1, m - 1]}");
}

Console.WriteLine();
PrintArr(numbers);

void Gen2DArr(int[,] array)// Метод генирации массива 
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToInt32(new Random().Next(10, 100));
        }
    }
}
void PrintArr(int[,] array) //Метод вывода массива и вывод элимента по координатам 
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("| ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == (n - 1) && j == (m - 1))
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            Console.Write(array[i, j] + " ");
            Console.ResetColor();
            Console.Write("| ");
        }
        Console.WriteLine("");
    }
}

