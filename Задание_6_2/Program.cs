using System;

namespace Задание_6_2
{
    class Program
    { 

        
        static void Main(string[] args)
        {
            int recursion(int[] array) {
                array = new int[10];
                Random rand = new Random();

               int recursion = 0;               
                for (int i = 0; i<array.Length;++i) {
                    array[i] = rand.Next(1, 10);
                    recursion += array[i];
                    Console.WriteLine(array[i]);
                }              
                return recursion;
            }
            int[] f = new int[0];          
            Console.WriteLine($"Сумма элементов массива равна: {recursion(f)}");
        }  
    }
}
