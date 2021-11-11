using System;

namespace Задание_4_лаба_3
{
    class Program
    {
        static int[,] MassivSum(int[,] MassiveOne, int[,] MassiveTwo)
        {
            int[,] SumMassive = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    SumMassive[i, j] = MassiveOne[i, j] + MassiveTwo[i, j];

                }
            }
            return SumMassive;
        }

        static int[,] MassiveDiff(int[,] MassiveOne, int[,] MassiveTwo)
        {
            int[,] DiffMassive = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    DiffMassive[i, j] = MassiveOne[i, j] - MassiveTwo[i, j];
                }
            }
            return DiffMassive;
        }
        static int[,] MasssiveSr(int[,] MassisveOne, int[,] MassiveTwo)
        {
            int[,] SrMassive = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    SrMassive[i, j] = MassisveOne[i, j] + MassiveTwo[i, j] / 2;
                }
            }
            return SrMassive;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("===============|");
            Console.WriteLine("ПЕРВЫЙ МАССИВ");
            int[,] MassiveOne = new int[3, 3];
            Random rand = new Random();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    MassiveOne[i, j] = rand.Next(10);
                    Console.Write(MassiveOne[i, j] + " ");
                }
                Console.WriteLine(" ");
            }
            Console.WriteLine("===============|");
            Console.WriteLine("ВТОРОЙ МАССИВ");
            int[,] MassiveTwo = new int[3, 3];
            Random rand2 = new Random();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    MassiveTwo[i, j] = rand2.Next(10);
                    Console.Write(MassiveTwo[i, j] + " ");
                }
                Console.WriteLine(" ");
            }
            Console.WriteLine("=============================|");
        point:
            try
            {
                Console.WriteLine("Выберите операцию с массивом: \nСумма--(1), Разность--(2), Среднее значение--(3)");
                int input = int.Parse(Console.ReadLine());

                if (input == 1)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            Console.Write(MassivSum(MassiveOne, MassiveTwo)[i, j] + " ");
                        }
                    }
                    Console.WriteLine(" ");
                }
                else if (input == 2)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            Console.Write(MassiveDiff(MassiveOne, MassiveTwo)[i, j] + " ");
                        }
                    }
                    Console.WriteLine(" ");
                }
                else if (input == 3)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            Console.Write(MasssiveSr(MassiveOne, MassiveTwo)[i, j] + " ");
                        }
                    }
                    Console.WriteLine(" ");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid Syntax. Enter the number");
                goto point;
            }

        }

    }
}