Console.WriteLine("Введите делимое: ");
string A = Console.ReadLine();
Console.WriteLine("Введите делитель: ");
string B = Console.ReadLine();
double result = Convert.ToDouble(A) / Convert.ToDouble(B);
int ost = Convert.ToInt32(A) % Convert.ToInt32(B);
Console.WriteLine($"Результат деления: {result}");
Console.WriteLine($"Остаток от деления: {ost}");




