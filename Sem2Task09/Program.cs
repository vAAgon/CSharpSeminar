// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
Console.Clear();
System.Random numSintez = new System.Random();
int randNum = numSintez.Next(10, 100);
//  if (firstNum > secondNum)                     //Обычный метод
// {
//     Console.WriteLine(firstNum);
// }
// else
// {
//     Console.WriteLine(secondNum);
// }
//int z = (firstNum > secondNum) ? firstNum : secondNum; // Тернарный метод( операция )
//Console.WriteLine(z);

//Var 2 
char[] numds = numSintez.Next(10, 100).ToString().ToCharArray();
Console.WriteLine(numds);
int firstNum = numds[0] - 48;
int secondNum = numds[1] - 48;
int w = (firstNum > secondNum) ? firstNum : secondNum;
Console.WriteLine(w);

// var 3 табличное решение 
