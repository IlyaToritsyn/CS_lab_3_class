using System;

namespace ClassLibrary
{
    /// <summary>
    /// Класс треугольника.
    /// </summary>
    public class Triangle
    {
        /// <summary>
        /// Сторона a.
        /// </summary>
        private double a = double.NaN;

        /// <summary>
        /// Сторона b.
        /// </summary>
        private double b = double.NaN;

        /// <summary>
        /// Сторона c.
        /// </summary>
        private double c = double.NaN;

        /// <summary>
        /// Сторона a.
        /// </summary>
        public double A
        {
            get => a;

            set
            {
                if (value <= 0)
                {
                    throw new Exception("Треугольник не может иметь сторону a = " + value + ".");
                }

                if (double.IsNaN(B) || double.IsNaN(C) || IsTriangleExisting(value, B, C))
                {
                    a = value;
                }

                else
                {
                    throw new Exception("Треугольник со сторонами a = " + value + ", b = " + B + ", c = " + C + " не существует.");
                }
            }
        }

        /// <summary>
        /// Сторона b.
        /// </summary>
        public double B
        {
            get => b;

            set
            {
                if (value <= 0)
                {
                    throw new Exception("Треугольник не может иметь сторону b = " + value + ".");
                }

                if (double.IsNaN(A) || double.IsNaN(C) || IsTriangleExisting(A, value, C))
                {
                    b = value;
                }

                else
                {
                    throw new Exception("Треугольник со сторонами a = " + A + ", b = " + value + ", c = " + C + " не существует.");
                }
            }
        }

        /// <summary>
        /// Сторона c.
        /// </summary>
        public double C
        {
            get => c;

            set
            {
                if (value <= 0)
                {
                    throw new Exception("Треугольник не может иметь сторону c = " + value + ".");
                }

                if (double.IsNaN(A) || double.IsNaN(B) || IsTriangleExisting(A, B, value))
                {
                    c = value;
                }

                else
                {
                    throw new Exception("Треугольник со сторонами a = " + A + ", b = " + B + ", c = " + value + " не существует.");
                }
            }
        }

        /// <summary>
        /// Конструктор без параметров.
        /// </summary>
        public Triangle()
        {
            A = 1;
            B = 1;
            C = 1;
        }

        /// <summary>
        /// Конструктор с параметрами.
        /// </summary>
        /// <param name="a">Сторона a</param>
        /// <param name="b">Сторона b</param>
        /// <param name="c">Сторона c</param>
        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        /// <summary>
        /// Получение строкового представления треугольника.
        /// </summary>
        /// <returns>Строковое представление треугольника</returns>
        public override string ToString() => "a = " + A + "; b = " + B + "; c = " + C;

        /// <summary>
        /// Перегрузка оператора ">".
        /// </summary>
        /// <param name="first">1 треугольник</param>
        /// <param name="second">2 треугольник</param>
        /// <returns>true - 1 треугольник больше 2; false - 1 треугольник меньше 2 или равен ему</returns>
        public static bool operator >(Triangle first, Triangle second) => first.GetArea() > second.GetArea();

        /// <summary>
        /// Перегрузка оператора "<".
        /// </summary>
        /// <param name="first">1 треугольник</param>
        /// <param name="second">2 треугольник</param>
        /// <returns>true - 1 треугольник меньше 2; false - 1 треугольник больше 2 или равен ему</returns>
        public static bool operator <(Triangle first, Triangle second) => first.GetArea() < second.GetArea();

        /// <summary>
        /// Перегрузка оператора ">=".
        /// </summary>
        /// <param name="first">1 треугольник</param>
        /// <param name="second">2 треугольник</param>
        /// <returns>true - 1 треугольник больше 2 или равен ему; false - 1 треугольник меньше 2</returns>
        public static bool operator >=(Triangle first, Triangle second) => first.GetArea() >= second.GetArea();

        /// <summary>
        /// Перегрузка оператора "<=".
        /// </summary>
        /// <param name="first">1 треугольник</param>
        /// <param name="second">2 треугольник</param>
        /// <returns>true - 1 треугольник меньше 2 или равен ему; false - 1 треугольник больше 2</returns>
        public static bool operator <=(Triangle first, Triangle second) => first.GetArea() <= second.GetArea();

        /// <summary>
        /// Проверка: существует ли треугольник.
        /// </summary>
        /// <param name="a">Сторона a</param>
        /// <param name="b">Сторона b</param>
        /// <param name="c">Сторона c</param>
        /// <returns>true - треугольник существует; false - нет</returns>
        public static bool IsTriangleExisting(double a, double b, double c) => (a < b + c) && (b < a + c) && (c < a + b);

        /// <summary>
        /// Вычисление периметра треугольника.
        /// </summary>
        /// <param name="a">Сторона a</param>
        /// <param name="b">Сторона b</param>
        /// <param name="c">Сторона c</param>
        /// <returns>Периметр треугольника</returns>
        public double GetPerimeter() => A + B + C;

        /// <summary>
        /// Вычисление площади треугольника.
        /// </summary>
        /// <param name="a">Сторона a</param>
        /// <param name="b">Сторона b</param>
        /// <param name="c">Сторона c</param>
        /// <returns>Площадь треугольника</returns>
        public double GetArea()
        {
            double p = GetPerimeter() / 2;

            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
}
