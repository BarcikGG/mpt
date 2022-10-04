using System.ComponentModel.Design;
using System.Linq.Expressions;
using System.Security.Cryptography;

namespace Three_Programs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Start();
        }

        static void Start()
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("1. Угадай число \n2. Таблица умножения \n3. Вывод делителей числа" +
                "\n4. Выход");
            Console.WriteLine("Введите цифру программы: ");
            int action = Convert.ToInt32(Console.ReadLine());

            switch (action)
            {
                case 1:
                    GuessRandom();
                    break;
                case 2:
                    Multiplication();
                    break;
                case 3:
                    Division();
                    break;
                case 4:
                    Environment.Exit(0);
                    break;
            }
        }

        static void GuessRandom() 
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Игра - Угадай число");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Введите число от 1 до 100: ");
            int user_number = Convert.ToInt32(Console.ReadLine());

            //работало только так (не знаю почему не работал обычный рандом)
            int pc_number = RandomNumberGenerator.GetInt32(101); 

            if (user_number == pc_number)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Вы угадали!");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Ваше число: {user_number} | Число компьютера: {pc_number}");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Вы не угадали :(");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Ваше число: {user_number} | Число компьютера: {pc_number}");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Поиграем? \n1. Да \n2. Меню");
                Console.ForegroundColor = ConsoleColor.White;
                int game = Convert.ToInt32(Console.ReadLine());
                if (game == 1)
                {
                    GuessRandom();
                }
                else 
                {
                    Start();
                }
            }
        }

        static void Multiplication()
        {
            Console.WriteLine("----------------------------------------" +
                "----------------------------");
            double[,] matrix = new double[10, 10];
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    matrix[i, j] = i * j;
                    Console.Write(matrix[i,j] + "\t");
                }
                Console.WriteLine("");
                Console.WriteLine("");
            }
            Console.WriteLine("----------------------------------------" +
                "----------------------------");
            Start();
        }

        static void Division()
        {
            Console.WriteLine("Введите число: ");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    Console.Write($"{i}\t");
                }
                else
                {
                    
                }
            }
            Console.WriteLine(number);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n1. Новое число\n2. Выход");
            Console.WriteLine("Введите число: ");
            Console.ForegroundColor = ConsoleColor.White;
            int action = Convert.ToInt32(Console.ReadLine());

            if (action == 1)
            {
                Division();
            }
            else 
            {
                Start();
            }
        }

    }
}