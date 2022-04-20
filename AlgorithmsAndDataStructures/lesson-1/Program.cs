using System;

namespace lesson_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var testCase1 = new TestCase()
            {
                Number = 4,
                Expected = false,
                ExpectedException = null
            };

            var testCase2 = new TestCase()
            {
                Number = 5,
                Expected = true,
                ExpectedException = null
            };

            var testCase3 = new TestCase()
            {
                Number = 6,
                Expected = true,
                ExpectedException = null
            };

            var testCase4 = new TestCase()
            {
                Number = 7,
                Expected = false,
                ExpectedException = null
            };

            TestPrimeNumberOrNot(testCase1);
            TestPrimeNumberOrNot(testCase2);
            TestPrimeNumberOrNot(testCase3);
            TestPrimeNumberOrNot(testCase4);

            Console.ReadKey();
        }

        public static bool ChekPrimeNumberOrNot(int number)
        {
            int d = 0;
            int i = 2;

            while (i < number)
            {
                if (number % i == 0)
                {
                    d++;
                }
                i++;
            }
            

            if (d==0)
            {
                Console.WriteLine($"Число {number} простое!");
                return true;
            }
            else
            {
                Console.WriteLine($"Число {number} не простое!");
                return false;
            }
        }


        public class TestCase
        {
            public int Number { get; set; }
            public bool Expected { get; set; }
            public Exception ExpectedException { get; set; }
        }

        static void TestPrimeNumberOrNot(TestCase testCase)
        {
            try
            {
                bool actual = ChekPrimeNumberOrNot(testCase.Number);
                if (actual == testCase.Expected)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("VALID TEST");
                    Console.ResetColor();
                    Console.WriteLine("=========================");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("INVALID TEST");
                    Console.ResetColor();
                    Console.WriteLine("=========================");
                }
            }
            catch (Exception ex)
            {
                if (testCase.ExpectedException != null)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("VALID TEST");
                    Console.ResetColor();
                    Console.WriteLine("=========================");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("INVALID TEST");
                    Console.ResetColor();
                    Console.WriteLine("=========================");
                }

            }
        }
    }
}
