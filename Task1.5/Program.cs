Console.WriteLine("Введите X1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите Y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите X2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите Y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());
double a = -(y1 - y2);
double b = -(x1 * y2 - x2 * y1);
double c = x2 - x1;
Console.WriteLine($"Y = {a / c}X + {b / c}");

