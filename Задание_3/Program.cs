using System;

namespace Задание_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во элементов массива");
            int arrayElement = int.Parse(Console.ReadLine());
            int[] Array = new int[arrayElement];
            Random rand = new Random();

            int k = 1;
            for (int i = 0; i < Array.Length; i++) {               
                Array[i] = rand.Next(1, 10);
                Console.Write(Array[i] + " ");
            }
            Console.WriteLine(" ");
            Console.WriteLine("==================================|");
            Console.WriteLine($"Массив со сдвигом на элемент: {k}");
            for (int i = 0; i < k; ++i) {
                int temp = Array[0];
                for (int j = 0; j < arrayElement - 1; j++) { 
                    Array[j] = Array[j + 1];
                    Array[arrayElement - 1] = temp;
                }
            }
            for (int i = 0; i < arrayElement; ++i) {
                Console.Write(Array[i]+ " ");
            }
            Console.WriteLine(" ");
        }
    }
}
