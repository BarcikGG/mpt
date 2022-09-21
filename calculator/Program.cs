using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Функции калькулятора: \n1. Сложить 2 числа \n2. Вычесть первое из второго" +
                "\n3. Перемножить два числа\n4. Разделить первое на второе\n5. Возвести в степень N первое число" +
                "\n6. Найти квадратный корень из числа\n7. Найти 1 процент от числа\n8. Найти факториал из числа" +
                "\n9. Выйти из программы");
            //извините за костыли, чета криво работало :(
            // но главное, что работает как надо :)
            do
            {
                Console.WriteLine("Введите цифру из списка: ");
                int action = Convert.ToInt32(Console.ReadLine());

                switch (action)
                {
                    case 1:
                        Console.WriteLine("Введите первое число: ");
                        double number_one = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите второе число: ");
                        double number_two = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"{number_one}+{number_two}={number_one + number_two}");
                    break;
                    case 2:
                        Console.WriteLine("Введите первое число: ");
                        double number_one_2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите второе число: ");
                        double number_two_2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"{number_two_2}-{number_one_2}={number_two_2 - number_one_2}");
                        break;
                    case 3:
                        Console.WriteLine("Введите первое число: ");
                        double number_one_3 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите второе число: ");
                        double number_two_3 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"{number_one_3}*{number_two_3}={number_one_3 * number_two_3}");
                        break;
                    case 4:
                        Console.WriteLine("Введите первое число: ");
                        double number_one_4 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите второе число: ");
                        double number_two_4 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"{number_one_4}/{number_two_4}={number_one_4 / number_two_4}");
                        break;
                    case 5:
                        Console.WriteLine("Введите первое число: ");
                        double number_5 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите степень: ");
                        double degree = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"{number_5}**{degree}={Math.Pow(number_5, degree)}");
                        break;
                    case 6:
                        Console.WriteLine("Введите число: ");
                        double number_6 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"квадратный корень из {number_6}={Math.Sqrt(number_6)}");
                        break;
                    case 7:
                        Console.WriteLine("Введите число: ");
                        double number_7 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"1% от {number_7}={number_7/100}");
                        break;
                    case 8:
                        Console.WriteLine("Введите число: ");
                        double number_8 = Convert.ToDouble(Console.ReadLine());
                        int factorial = 1;
                        for (int i = 2; i <= number_8; i++)
                        {
                            factorial = factorial * i;
                        }
                        Console.WriteLine($"!{number_8}={factorial}");
                        break;
                    case 9:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Цифра не входит в диапазон от 1 до 9");
                        break;
                }
            }
            while (true);
        }
    }
}
