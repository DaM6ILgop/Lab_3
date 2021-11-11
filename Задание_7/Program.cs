using System;

namespace Задание_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int fibo(int n)
            {
                if (n == 1 || n == 2)
                {
                    return 1;
                }
                else
                {
                    return fibo(n - 1) + fibo(n - 2);
                }
            }
        point:
            Console.WriteLine("Введите число для нахождения члена ряда Фибоначчи");
            int f = int.Parse(Console.ReadLine());
            Console.WriteLine($"Под номером |{f}| стоит число -- |{fibo(f)}| из ряда Фибоначчи");
            goto point;
        }
    }
}