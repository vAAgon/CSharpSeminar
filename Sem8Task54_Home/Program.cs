Console.Clear();
//Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int[,] table = new int[5, 5];
Gen2DArr(table);
PrintArr(table);
FromLargestToSmallest(table);
Console.WriteLine();
PrintArr(table);


//Метод растоновки 
void FromLargestToSmallest(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}

// Метод генирации Двемерного массива
void Gen2DArr(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToInt32(new Random().Next(0, 10));
        }
    }
}

// Метод вывода Массива 
void PrintArr(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {

            // if (i == j)
            // {
            //     Console.ForegroundColor = ConsoleColor.Blue;
            // }

            Console.Write(array[i, j] + " ");
            // Console.ResetColor();
            Console.Write("");

        }
        Console.Write("]");
        Console.WriteLine("");
    }
}
