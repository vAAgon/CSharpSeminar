Console.Clear();
//Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
int ReadData(string massage) // Метод ввода 
{
    Console.Write(massage);
   int res = Convert.ToInt32(Console.ReadLine());
    return res;
}

string LineGen(int num, int pow) // Метод ввывода чисел 
{
    string res = "";
    for (int i = 1; i <= num; i++)
    {
        res += Math.Pow(i, pow) + " ";
    }
    return res ;
}
// Ввывод в кансоль 
int numN = ReadData("Input num :");
Console.WriteLine(LineGen(numN, 1));
Console.WriteLine(LineGen(numN, 3));
