Console.Clear();
//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 

Console.Write("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());
PrintNumbers(n);

//Выводим Числа 
void PrintNumbers(int num)
    {
        if (num > 0)
        {
            Console.Write(num+ (" "));
            PrintNumbers(num - 1);
        }
    }