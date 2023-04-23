Console.Clear();
// Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

Console.WriteLine($"\nВведите размер массива X x Y x Z:");
int x = InputNumbers("Введите X: ");
int y = InputNumbers("Введите Y: ");
int z = InputNumbers("Введите Z: ");
Console.WriteLine();
int[,,] array3D = GenArray(x, y, z);
PrintArray(array3D);

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

void PrintArray(int[,,] array3D)
{

    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                Console.WriteLine($"array3D[{i},{j},{k}] = {array3D[i, j, k]}");
            }
        }
    }
}


int[,,] GenArray(int x, int y, int z)
{
    int[,,] array3D = new int[x, y, z];
    int num = 10;
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++)
            {
                array3D[i, j, k] = num;
                num++;
                if (num > 99) num = 10;
            }
        }
    }
    return array3D;
}
