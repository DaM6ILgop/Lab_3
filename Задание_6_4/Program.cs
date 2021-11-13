using System;

namespace Задание_6_4
{
    class Program
    {
        static int MinValue(int[] Array, int i) {
            if (i + 1 == Array.Length) {
                return Array[i];
            }
            else {
                return Math.Min(Array[i], MinValue(Array, ++i));
            }
        } 

        static void Main(string[] args) {     
            int[] Array = { 23,2435,4, 23, 43, 35, 72,19, 20, 23, 45, 6, 543, 987 };
            int result = MinValue(Array,0);
            Console.WriteLine($"Минимальное значение :{result}");        
        }
    }
}
