Console.Clear();

int ReadData(string msg)
{
    Console.WriteLine(msg);
    int res = int.Parse(Console.ReadLine()?? "0");
    return res;
}
void PritTest(int x, int y)
{
    if (x > 0 && y > 0) Console.WriteLine("I");
    if (x > 0 && y < 0) Console.WriteLine("II");
    if (x < 0 && y < 0) Console.WriteLine("III");
    if (x < 0 && y > 0) Console.WriteLine("IV");

}
int coordx = ReadData("Ввидите координату X");
int coordy = ReadData("Ввидите координату Y");
PritTest(coordx, coordy);