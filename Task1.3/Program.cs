Console.WriteLine("Введите A: ");
string a = Console.ReadLine();
Console.WriteLine("Введите B: ");
string b = Console.ReadLine();
string c = a;
a = b;
b = c;
Console.WriteLine($"а = {a}");
Console.WriteLine($"b = {b}");
