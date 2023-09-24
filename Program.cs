using System;

class Program
{
static void Main()
{
bool exit = false;

while (!exit)
{
Console.WriteLine("Выбери программу, которую хочешь запустить:");
Console.WriteLine("1. Игра 'Угадай число'");
Console.WriteLine("2. Таблица умножения");
Console.WriteLine("3. Вывод делителей числа");
Console.WriteLine("4. Выйти из программы");

int choice = Convert.ToInt32(Console.ReadLine());

switch (choice)
{
case 1:
GuessNumber();
break;
case 2:
MultiplicationTable();
break;
case 3:
PrintDivisors();
break;
case 4:
exit = true;
break;
default:
Console.WriteLine("Такой программы не существует!");
break;
}

Console.WriteLine();
}
}

static void GuessNumber()
{
Random random = new Random();
int number = random.Next(0, 101);
int attempts = 0;

Console.WriteLine("Угадай число от 0 до 100!");

while (true)
{
int guess = Convert.ToInt32(Console.ReadLine());
attempts++;

if (guess < number)
Console.WriteLine("Загаданное число больше.");
else if (guess > number)
Console.WriteLine("Загаданное число меньше.");
else
{
Console.WriteLine($"Ты угадал число за {attempts} попыток! Умничка!");
break;
}
}
}

static void MultiplicationTable()
{
Console.WriteLine("Вот твоя таблица умножения:");

for (int i = 1; i <= 9; i++)
{
for (int j = 1; j <= 9; j++)
{
int result = i * j;
Console.Write($"{result}\t");
}

Console.WriteLine();
}
}
    static void PrintDivisors()
    {
        Console.WriteLine("Для выхода из программы напиши 'выйти'.");
      
        Console.WriteLine("Введи число:");
        while (true)
        {
            string input = Console.ReadLine();

            if (input.ToLower() == "выйти")
                break;

            int number = Convert.ToInt32(input);

            Console.WriteLine($"Делители числа {number}:");
           
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                    Console.WriteLine(i);
              
            }

            Console.WriteLine("Введи еще число:");
        }
    }
}
