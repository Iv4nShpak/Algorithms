using System;

namespace lesson_1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = {1, 55, 33};

            Console.WriteLine(StrangeSum(inputArray));
        }


        public static int StrangeSum(int[] inputArray)  //Асимпотическая сложность функции: O(1 + N^3 + 1) => O(2N^3) => O(N^3)
        {
            int sum = 0;  //O(1)
            for (int i = 0; i < inputArray.Length; i++) //O(N)
            {
                for (int j = 0; j < inputArray.Length; j++) //O(N)
                {
                    for (int k = 0; k < inputArray.Length; k++) //O(N)
                    {
                        int y = 0;
                        if (j != 0)
                        {
                            y = k / j;
                        }
                        sum += inputArray[i] + i + k + j + y;
                    }
                }
            }
            return sum;  //O(1)
        }
    }
}
