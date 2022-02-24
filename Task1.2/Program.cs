Console.WriteLine("Введите делимое: ");
double A = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите делитель: ");
double B = Convert.ToDouble(Console.ReadLine());
double C = (5 * A + B * B) / (B - A);
Console.WriteLine($"Результат: {C}");