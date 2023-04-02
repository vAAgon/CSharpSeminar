Console.Clear();

int ReadData(string msg)
{
    Console.WriteLine(msg);
    int res = int.Parse(Console.ReadLine()?? "0");
    return res;
}
void PritTest(int quoter)
{
    if (quoter == 1) Console.WriteLine("x+ and y+");
    if (quoter == 2) Console.WriteLine("x+ and y-");
    if (quoter == 3) Console.WriteLine("x- and y-");
    if (quoter == 4) Console.WriteLine("x- and y+");

}
int quoterint = ReadData("Ввидите четверть ");

PritTest(quoterint);


