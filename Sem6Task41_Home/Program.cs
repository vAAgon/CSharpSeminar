Console.Clear();
//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.WriteLine("Enternumbers separated by commas:  ");
int[] numbers = ToNum(Console.ReadLine()); // ввод 

int sum = 0;
for (int i = 0; i < numbers.Length; i++) // подсчет колочества  
{
    if (numbers[i] > 0)
    {
        sum++;
    }
}

Console.WriteLine($"Above zero: {sum}"); // вывод 

void PrinrArr(int[] arr)// метод печати массива 
{
    Console.Write("[ ");
    for (int i = 0; i < arr.Length; i++) { Console.Write(arr[i] + " ");}
    Console.Write("]");
}
int[] ToNum(string input) // метод перевода строки 
{
    int count = 1;
    for (int i = 0; i < input.Length; i++) // убираем запятые 
    {
        if (input[i] == ',')
        {
            count++;
        }
    }

    int[] numbers = new int [count];
    int index = 0;

    for (int i = 0; i < input.Length; i++)
    {
        string temp = "";

        while (input [i] != ',')
        {
        if(i != input.Length - 1)
        {
            temp += input [i].ToString();
            i++;
        }
        else
        {
            temp += input [i].ToString();
            break;
        }
        }
        numbers[index] = Convert.ToInt32(temp); // переводим значение из string ->int 
        index++;
    }
    return numbers;
}
