//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
Console.Clear();
Console.Write("Введите чесло :");
string numline = Console.ReadLine();
if (numline != null)
{
//    char[] charArr = numline.ToCharArray();
  //  Console.WriteLine(charArr[charArr.Length - 1]);
int num = int.Parse(numline);
int res= num %10 ;
Console.WriteLine(res);
}