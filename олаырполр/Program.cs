using System;

namespace олаырполр
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 9;
            const int m = 9;
            int[,] matrix = new int[n, m];

            int horiz = 0;
            int vert = 0;
            int HorizonX= 1;
            int VertY= 0;
            int Changes = 0;
            int visits = m;
            Console.WriteLine("Заполнение матрицы по спирали ");

            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[horiz, vert] = i + 1;
                if (--visits == 0)
                {
                    visits = m * (Changes % 2) + n * ((Changes + 1) % 2) - (Changes / 2 - 1) - 2;
                    int temp = HorizonX;
                    HorizonX = -VertY;
                    VertY = temp;
                    Changes++;
                }
                vert += HorizonX; //Отвечает за положение столбца 
                horiz += VertY;
            }
                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        Console.Write(matrix[i, j] + "  ");
                    }
                    Console.WriteLine(" ");
                }
        }
    }
}
