Console.Clear();
// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// * Дополнительно диагональ выделить разным цветом.
Console.WriteLine("введите количество строк");
int lines = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите количество столбцов");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] numbers = new int[lines, columns];

Gen2DArr(numbers);
Console.WriteLine();
PrintArr(numbers);
Console.WriteLine();



for (int j = 0; j < numbers.GetLength(1); j++) // Нхождение среднего 
{
    double avarage = 0;
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        avarage = (avarage + numbers[i, j]);
    }
    avarage = avarage / lines;
    
    Console.Write(avarage + "   ");
   
}
Console.WriteLine();

void Gen2DArr(int[,] array)  // Метод генирации Двемерного массива  
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToInt32(new Random().Next(0, 10));
        }
    }
}
void PrintArr(int[,] array)  // Метод вывода Массива  с веделением диоганали 
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {

            if (i == j)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }
             
            Console.Write(array[i, j] + " ");
            Console.ResetColor();
            Console.Write("");
            
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}
