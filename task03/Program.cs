// Напишите программу, которая будет выдавать название дня недели по заданному номеру.

Console.Clear();
Console.WriteLine("Ввидете день недели :");
string? weekday = Console.ReadLine();
if (weekday != null)
{
    string[] dayweek = new string[7];
    dayweek[0] = "Пон";
    dayweek[1] = "Втор";
    dayweek[2] = "Сред";
    dayweek[3] = "Чет";
    dayweek[4] = "Пят";
    dayweek[5] = "Суб";
    dayweek[6] = "Вос";
    int day = int.Parse(weekday);
    Console.WriteLine(dayweek[day - 1]);
}