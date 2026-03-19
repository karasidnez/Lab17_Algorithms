
Console.Write("Введите ваш вес (в кг): ");
double weight = double.Parse(Console.ReadLine());

Console.Write("Введите ваш рост (в метрах, например 1.75): ");
double height = double.Parse(Console.ReadLine());

double bmi = weight / (height * height);


string category;
string recommendation;

if (bmi < 18.5)
{
category = "Недостаточный вес";
recommendation = "еш";
}
else if (bmi >= 18.5 && bmi < 25)
{
category = "Нормальный вес";
recommendation = "продолжай";
}
else if (bmi >= 25 && bmi < 30)
{
category = "Избыточный вес";
recommendation = "меньше ешь";
}
else
{
    category = "Ожирение";
    recommendation = "вообще не ешь";
}

Console.WriteLine($"Категория: {category}");
Console.WriteLine($"Рекомендация: {recommendation}");