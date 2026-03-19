using System;

class GuessNumber
{
    static void Main()
    {
        Random rnd = new Random();
        bool again = true;

        while (again)
        {
            int secret = rnd.Next(1, 101);
            int attempts = 0;
            int guess = 0;
            bool guessed = false;

            Console.WriteLine("Я загадал число от 1 до 100.");

            while (!guessed)
            {
                Console.Write("Твой вариант: ");
                // Проверка ввода
                while (!int.TryParse(Console.ReadLine(), out guess))
                    Console.Write("Ошибка! Введи число: ");

                attempts++;

                if (guess < secret) Console.WriteLine("Больше");
                else if (guess > secret) Console.WriteLine("Меньше");
                else guessed = true;
            }

            Console.WriteLine($"Ты угадал! Число: {secret}. Попыток: {attempts}");
            Console.Write("Сыграем ещё? (да/нет): ");
            again = Console.ReadLine().ToLower() == "да";
        }
    }
}