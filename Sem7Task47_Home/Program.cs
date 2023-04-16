Console.Clear();
// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// * При выводе матрицы показывать каждую цифру разного цвета(цветов всего 16)

Console.WriteLine("введите количество строк");
int lines = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите количество столбцов");
int columns = Convert.ToInt32(Console.ReadLine());

double[,] numbers = new double[lines, columns];

Gen2DArr(numbers);

PrintArr(numbers);

void Gen2DArr(double[,] array) //Метод генерации массива 
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}
void PrintArr(double[,] array) // Метод вывода массива
{
    ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};

    for (int i = 0; i < array.GetLength(0); i++)
    {
       // Console.Write("| ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.ForegroundColor = col[new Random().Next(0,16)];
            Console.Write(array[i, j] + " ");
            Console.ResetColor();
            Console.Write("|");
        }
        //Console.Write("|");
        Console.WriteLine("");
    }
}