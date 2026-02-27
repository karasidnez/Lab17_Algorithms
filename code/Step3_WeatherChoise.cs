Console.WriteLine("Выбор одежды");
Console.Write("Введите текущую температуру (С):");
int temperature = Convert.ToInt32(Console.ReadLine());
if (temperature >= 20)
{
    Console.WriteLine("Наденьте лёгкую одежду");

}
else
{
    Console.WriteLine("Наденьте тёплую одежду");
}
Console.WriteLine("Хорошего дня!");