Console.Clear();
Console.WriteLine("input nambers  :");
int numbers = Convert.ToInt32(Console.ReadLine());
string numbersText = Convert.ToString(numbers);
if (numbersText.Length > 2){
    Console.WriteLine("Therd num -> " + numbersText[2]);
}
else {
 Console.WriteLine("Third num nope" );
}
//string answer = numbersText.Length > 2 ? (Console.WriteLine("Therd num -> " + numbersText[2])) : (Console.WriteLine("Third num nope"));