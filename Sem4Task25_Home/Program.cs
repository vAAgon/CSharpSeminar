Console.Clear();
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
void PrintRes(string msg, int res) // Метод ввывода 
{
     Console.WriteLine(string.Empty);
    Console.WriteLine(msg + res);
}
int Exponent(int numA, int numB) // Метот выщета 
{
    int res = 1;
    for (int i = 0; i < numB; i++) { res = res * numA; }// Или можно проще int res = Math.Pow(numA,Num B)

    return res;
}
int ExponentMathPow(int numA, int numB) // Метот выщета 2
{
    int res2 = (int)Math.Pow(numA,numB);
    return res2;
}

Console.Write("Введите число A: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int numB = Convert.ToInt32(Console.ReadLine());

DateTime time1 = DateTime.Now;
int expo = Exponent(numA, numB);
PrintRes("Answer Exponent : ", (int)expo);
Console.WriteLine(DateTime.Now - time1);

DateTime time2 = DateTime.Now;
int expo2 = ExponentMathPow(numA,numB);
PrintRes("Answer ExponentMathPow : ", (int)expo2);
Console.WriteLine(DateTime.Now - time2);

