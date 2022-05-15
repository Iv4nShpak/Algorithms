using System;

namespace lesson_1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");

            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"{n}-ое число Фибонначи = {Fibonachi(n)}");
            Console.WriteLine($"{n}-ое число Фибонначи = {FibonachiCycle(n)}");


            Console.ReadKey();
        }

        public static int Fibonachi(int n)      //Версия функции с рекурсией
        {
            if (n == 0 || n == 1)
            {
                return n;
            }

            return Fibonachi(n - 1) + Fibonachi(n - 2);
        }

        public static int FibonachiCycle(int n) //Версия функции без рекурсии
        {
            int first = 0;
            int second = 1;
            int fibonacci = 0;

            if (n == 1)
            {
                fibonacci = second;
            }

            for (int i = 0; i < n - 1; i++)
            {
                fibonacci = first + second;
                first = second;
                second = fibonacci;
            }
            return fibonacci;
        }

        public class TestCase
        {
            public int N { get; set; }
            public int Expected { get; set; }
            public Exception ExpectedException { get; set; }
        }

        static int SumPositiv(int n)
        {
            if (n < 0)
            {
                throw new ArgumentException("Введенное число должно быть положительным");
            }

            return n = (n-1) + (n-2);
        }




    }
}
