// Напишите программу, которая будет выдавать название дня недели по заданному номеру.

Console.Clear();
Console.WriteLine("Ввидете день недели :");
string? weekday = Console.ReadLine();
if (weekday != null)
{
    string[] dayweek = new string[7];
    dayweek[0] = "Mon";
    dayweek[1] = "Tue";
    dayweek[2] = "Wed";
    dayweek[3] = "Thur";
    dayweek[4] = "Fri";
    dayweek[5] = "Sat";
    dayweek[6] = "Sun";
    int day = int.Parse(weekday);
    Console.WriteLine(dayweek[day - 1]);
}

// решить с помощья CASE 
