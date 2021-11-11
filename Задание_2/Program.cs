using System;

namespace Задание2_из_3_Лабы
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] Array = new int[7, 7];
            Random rand = new Random();
            Console.WriteLine("Массив размера 7x7");
            for (int counter = 0; counter < 7; counter++)
            {

                for (int counter2 = 0; counter2 < 7; counter2++)
                {
                    Array[counter, counter2] = rand.Next(9);
                    Console.Write(Array[counter, counter2] + "  ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Пернвернутый массив на 90°");
            for (int count = 0; count < 7; count++)
            {                                       //вертикаль
                for (int count2 = 6; count2 >= 0; --count2)
                { //горизонталь
                    Console.Write(Array[count2, count] + "  ");
                }
                Console.WriteLine();
                //  ᕦ(ò_óˇ)ᕤ
            }
        }
    }
}