using System;

namespace Задание_5
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] Array1 = new int[5, 5];
            Random rand = new Random();
            Console.WriteLine("Матрица размером 5x5");
            for (int i = 0; i < 5; i++)
            {

                for (int j = 0; j < 5; j++)
                {
                    Array1[i, j] = rand.Next(10);
                    Console.Write(Array1[i, j] + "  ");
                }
                Console.WriteLine();
            }
            int[,] Array2 = new int[5, 5];
            Random random = new Random();
            Console.WriteLine("Массив размера 5x5");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Array2[i, j] = rand.Next(9);
                    Console.Write(Array2[i, j] + "  ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Результат перемножения матриц");
            int[,] SumOFmatrices = new int[5, 5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    SumOFmatrices[i, j] = Array1[i, j] * Array2[i, j];
                    Console.Write(SumOFmatrices[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
