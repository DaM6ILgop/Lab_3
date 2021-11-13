using System;

namespace Задание_6_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 2, 3, 5, 6, 8, 9, 9, 7, 9, 12, 45, 65 };

            int minValue = array[0];
            for (int i = 1; i < array.Length; i++) {
                if (array[i] < minValue) {
                    minValue = array[i];
                }
            }
            Console.WriteLine($"Минимальное значение массива: {minValue}");
        }
    }
}
