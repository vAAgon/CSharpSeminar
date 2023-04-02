Console.Clear();
// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
int ReadData(string msg) // Метод вывода 
{
    Console.WriteLine(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}
double CalcLen3D(int x1, int x2, int y1, int y2, int z1, int z2) //Метод преобразавания 
{
    return Math.Sqrt(Math.Pow((x1 - x2), 2) + (Math.Pow((y1 - y2), 2)) + (Math.Pow((z1 - z2), 2)));
}
// Ввывод текста перерд вводом 
int x1 = ReadData("Введите координаты x1 точки 'A'");
int y1 = ReadData("Введите координаты y1 точки 'A'");
int z1 = ReadData("Введите координаты z1 точки 'A'");
int x2 = ReadData("Введите координаты x2 точки 'B'");
int y2 = ReadData("Введите координаты y2 точки 'B'");
int z2 = ReadData("Введите координаты z2 точки 'B'");
//Ввывод ответа 
Console.WriteLine("Lengs " + CalcLen3D(x1, x2, y1, y2, z1, z2));