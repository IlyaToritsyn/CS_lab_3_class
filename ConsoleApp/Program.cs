using System;
using ClassLibrary;

namespace ConsoleApp
{
    class Program
    {
        /// <summary>
        /// Ввод вещественного числа с клавиатуры.
        /// </summary>
        /// <param name="message">Сообщение для ввода</param>
        /// <returns>Вещественное число, введённое с клавиатуры</returns>
        public static double InputDouble(string message)
        {
            bool isParsed = false;

            double N = 0;

            while (!isParsed)
            {
                Console.WriteLine(message);

                isParsed = double.TryParse(Console.ReadLine(), out N);

                Console.WriteLine();
            }

            return N;
        }

        static void Main()
        {
            while (true)
            {
                Triangle triangle1 = null;

                do
                {
                    double a = InputDouble("Введите сторону a 1 треугольника:");
                    double b = InputDouble("Введите сторону b 1 треугольника:");
                    double c = InputDouble("Введите сторону c 1 треугольника:");

                    try
                    {
                        triangle1 = new Triangle(a, b, c);

                        Console.WriteLine("1 треугольник со сторонами: a = " + triangle1.A + ", b = " + triangle1.B + ", c = " + triangle1.C + ", - успешно создан.\n");
                    }

                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message + "\n");
                    }
                }
                while (triangle1 == null);

                Triangle triangle2 = null;

                do
                {
                    double a = InputDouble("Введите сторону a 2 треугольника:");
                    double b = InputDouble("Введите сторону b 2 треугольника:");
                    double c = InputDouble("Введите сторону c 2 треугольника:");

                    try
                    {
                        triangle2 = new Triangle(a, b, c);

                        Console.WriteLine("2 треугольник со сторонами: a = " + triangle2.A + ", b = " + triangle2.B + ", c = " + triangle2.C + ", - успешно создан.\n");
                    }

                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message + "\n");
                    }
                }
                while (triangle2 == null);

                if (triangle1 > triangle2)
                {
                    Console.WriteLine("1 треугольник больше 2 (" + Math.Round(triangle1.GetArea(), 2) + " > " + Math.Round(triangle2.GetArea(), 2) + ").\n");
                }

                else if (triangle1 < triangle2)
                {
                    Console.WriteLine("1 треугольник меньше 2 (" + Math.Round(triangle1.GetArea(), 2) + " < " + Math.Round(triangle2.GetArea(), 2) + ").\n");
                }

                else
                {
                    Console.WriteLine("Трегольники равны (" + Math.Round(triangle1.GetArea(), 2) + " = " + Math.Round(triangle2.GetArea(), 2) + ").\n");
                }

                Console.WriteLine("Нажмите любую клавишу, чтобы запустить программу заново.\n");

                Console.ReadKey(true);
            }
        }
    }
}
