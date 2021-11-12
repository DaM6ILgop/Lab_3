using System;

namespace Задание_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            Random rand = new Random();
            int suma = 0;
            for (int i = 0; i < array.Length; ++i) {
                array[i] = rand.Next(1, 10);
                suma += array[i];
                Console.Write(array[i] + " ");
                Console.WriteLine(" ");
            }
            Console.WriteLine($"Сумма массива равна: {suma}");
        }
    }
}
