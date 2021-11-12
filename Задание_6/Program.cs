using System;

namespace Задание_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum(int[] array)
            {
                array = new int[10];
                Random rand = new Random();

                int sum = 0;
                for (int i = 0; i < array.Length; ++i)
                {
                    array[i] = rand.Next(1, 10);
                    sum += array[i];
                    Console.WriteLine($"|{ array[i]}|");
                }

                return sum;
            }
            int[] f = new int[0];
            Console.WriteLine($"Сумма элементов массива равна: |{sum(f)}|");
        }
    }
}
