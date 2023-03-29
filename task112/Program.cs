Console.Clear();
Console.WriteLine("Введите чесло 1 ");
double num1 = double.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите чесло 2 ");
double num2 = Convert.ToDouble(Console.ReadLine());
bool res = (num2 % num1 == 0) ? (Console.WriteLine($"число{num1} кратно{num2}")) : (Console.WriteLine("Остаток{num%num1} "));
