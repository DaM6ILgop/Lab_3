using System;

namespace Задание_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во эллементов массива: ");
            int MassiveSize = int.Parse(Console.ReadLine());
            int[] Array = new int[MassiveSize];

            for (int i = 0; i < Array.Length; i++) {
                Console.Write(Array[i] + " ");
            }

            Console.WriteLine("Измененный массив: ");
            const int k = 2;
            for (int i = 0; i < k; ++i) {
                int Temp;
                for (int j = 0; j < MassiveSize - 1; j++) {
                    Array[j] = Array[j + 1];
                    int temp = Array[Array.Length - 1];
                }               
            }
            for (int i = 0; i < MassiveSize; ++i) {
                Console.Write(Array[i] + " ");
            }                
            Console.WriteLine();
        }
    }
}
