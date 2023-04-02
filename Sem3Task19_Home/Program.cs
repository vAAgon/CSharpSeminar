Console.Clear();
// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.Write("Input namber: ");
string number = Console.ReadLine();  //Ввод числа 

void CheckNum(string number) // Метод сравнивания на палиндром 
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine($"{number} - palindrome");
    }
    else Console.WriteLine($"{number} -  Not a palindrome");
}
// Проверка 
if (number!.Length == 5) { CheckNum(number); }
else Console.WriteLine("Давай заного, но только с пятью цифрами ");



