int[,] numbers = { { 1, 22, 3 }, { 4, 54, 61 }};
 
int rows = numbers.GetUpperBound(0) + 1;    // количество строк
int columns = numbers.Length / rows;        // количество столбцов
// или так
// int columns = numbers.GetUpperBound(1) + 1;
 
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write($"|{numbers[i, j]} |\t");
    }
    Console.WriteLine();
}