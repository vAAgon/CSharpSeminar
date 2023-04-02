Console.Clear();
int ReadData(string msg) //
{
    Console.WriteLine(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}
double CalcLen3D(int x1, int x2, int y1, int y2, int z1, int z2)
{
    return Math.Sqrt(Math.Pow((x1 - x2), 2) + (Math.Pow((y1 - y2), 2)) + (Math.Pow((z1 - z2), 2)));
}
int x1 = ReadData("Введите координаты x1 точки 'A'");
int y1 = ReadData("Введите координаты y1 точки 'A'");
int z1 = ReadData("Введите координаты z1 точки 'A'");
int x2 = ReadData("Введите координаты x2 точки 'B'");
int y2 = ReadData("Введите координаты y2 точки 'B'");
int z2 = ReadData("Введите координаты z2 точки 'B'");
Console.WriteLine("Lengs " + CalcLen3D(x1, x2, y1, y2, z1, z2));