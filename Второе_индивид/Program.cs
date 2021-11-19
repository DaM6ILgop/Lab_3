using System;
using System.Linq;

namespace Второе_индивид
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность массива\n масcив должен быть четной размерности");
            int Razmer = int.Parse(Console.ReadLine());
            int[] array = new int[100];
            for (int i = 1; i < Razmer+1; i++) {
                Console.WriteLine("Задайте значение массива ");
                int w = int.Parse(Console.ReadLine());
                array[i] = w;
                
                Console.WriteLine(array[i]);
            }
            for (int i = 1; i < Razmer+1; i++) {
                
                Console.Write(array[i] + "  ");  
            }
            int x;
            int y;
            int counter= 0;
            int Razn;
            int YslovieOut;
            Console.WriteLine();
            for (int i = 1; i < Razmer + 1; i++) {
            
                x = Math.Abs(array[i]);
                y = Math.Abs(array[i-1]);
                Razn = x - y;
                YslovieOut = Math.Abs(Razn);
                if (YslovieOut <= 5) {
                    counter++;
                }
                else {
                    Console.WriteLine("Числа вышли за предел");
                }                          
            }
            Console.WriteLine("Результат ");
            Console.WriteLine("|" +  counter + "|");
        }
    }
}
//Math.Abs(-5);
