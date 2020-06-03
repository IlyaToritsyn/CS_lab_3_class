using System;

namespace ClassLibrary
{
    /// <summary>
    /// Класс тругольника.
    /// </summary>
    public class Triangle
    {
        /// <summary>
        /// Сторона a.
        /// </summary>
        private double a;

        /// <summary>
        /// Сторона b.
        /// </summary>
        private double b;

        /// <summary>
        /// Сторона c.
        /// </summary>
        private double c;

        /// <summary>
        /// Сторона a.
        /// </summary>
        public double A
        {
            get
            {
                return a;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new Exception("Треугольник не может иметь сторону a = " + value + ".");
                }

                a = value;
            }
        }

        /// <summary>
        /// Сторона b.
        /// </summary>
        public double B
        {
            get
            {
                return b;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new Exception("Треугольник не может иметь сторону b = " + value + ".");
                }

                b = value;
            }
        }

        /// <summary>
        /// Сторона c.
        /// </summary>
        public double C
        {
            get
            {
                return c;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new Exception("Треугольник не может иметь сторону c = " + value + ".");
                }

                c = value;
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
        /// <param name="a">Сторона a.</param>
        /// <param name="b">Сторона b.</param>
        /// <param name="c">Сторона c.</param>
        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;

            if (!IsTriangleExisting())
            {
                throw new Exception("Треугольник со сторонами a = " + A + ", b = " + B + ", c = " + C + " не существует.");
            }
        }

        /// <summary>
        /// Получение строкового представления треугольника.
        /// </summary>
        /// <returns>Строковое представление треугольника</returns>
        public override string ToString()
        {
            return "a = " + A + "; b = " + B + "; c = " + C;
        }

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
        /// <param name="a">Сторона a.</param>
        /// <param name="b">Сторона b.</param>
        /// <param name="c">Сторона c.</param>
        /// <returns>true - треугольник существует; false - нет</returns>
        public bool IsTriangleExisting() => (A < B + C) && (B < A + C) && (C < A + B);

        /// <summary>
        /// Вычисление периметра треугольника.
        /// </summary>
        /// <param name="a">Сторона a.</param>
        /// <param name="b">Сторона b.</param>
        /// <param name="c">Сторона c.</param>
        /// <returns>Периметр треугольника</returns>
        public double GetPerimeter()
        {
            if (!IsTriangleExisting())
            {
                throw new Exception("Треугольник со сторонами a = " + A + ", b = " + B + ", c = " + C + " не существует.");
            }

            return A + B + C;
        }

        /// <summary>
        /// Вычисление площади треугольника.
        /// </summary>
        /// <param name="a">Сторона a.</param>
        /// <param name="b">Сторона b.</param>
        /// <param name="c">Сторона c.</param>
        /// <returns>Площадь треугольника</returns>
        public double GetArea()
        {
            if (!IsTriangleExisting())
            {
                throw new Exception("Треугольник со сторонами a = " + A + ", b = " + B + ", c = " + C + " не существует.");
            }

            double p = GetPerimeter() / 2;

            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
}
