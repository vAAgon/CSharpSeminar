Console.Clear();
System.Random rndNum = new System.Random();
//Console.WriteLine(rndNum);
char[] digits = rndNum.Next(100, 1000).ToString().ToCharArray();
Console.WriteLine(digits);
char[] res = { digits[0], digits[2] };
Console.WriteLine(res);
