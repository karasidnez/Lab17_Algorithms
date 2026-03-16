static double Add(double a, double b) => a + b;
static double Subtract(double a, double b) => a - b;
static double Multiply(double a, double b) => a * b;
static double Divide(double a, double b) => a / b;

Console.Write("Введите первое число: ");
double a = double.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
double b = double.Parse(Console.ReadLine());
Console.Write("Операция (+, -, *, /): ");
string op = Console.ReadLine();
double result;
switch (op)
{
    case "+": result = Add(a, b); break;
    case "-": result = Subtract(a, b); break;
    case "*": result = Multiply(a, b); break;
    case "/": result = Divide(a, b); break;
    default:
    Console.WriteLine("Неверная операция");
    return;
}

Console.WriteLine($"Результат: {result}");
