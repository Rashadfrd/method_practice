using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 2, 2, 3, 4, 5, 6, 38, 8, 9 };
            int[] numbers2 = NewArray(numbers);
            foreach  (int item in numbers2)
            {
                Console.WriteLine(item);
            }


            static int[] NewArray(int[] numbers)
            {
                int result = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] % 2 == 0)
                    {
                        result++;
                    }
                }
                int[] numbers1 = new int[result];
                int j = 0;
                int netice = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] % 2 == 0)
                    {
                        numbers1[j] = numbers[i];
                        j++;
                    }
                }
                return numbers1;
            }
        }
    }
}
