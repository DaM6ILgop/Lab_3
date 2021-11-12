using System;

namespace Задание_6_2
{
    class Program
    {
        static int Summa(int[] array,int i = 0 ) {
            if ( i >= array.Length)
            {
                return 0;
            }
            else {
                int result = Summa(array, i + 1);
                return array[i] + result;
            }
        }
        static void Main(string[] args)
        {           
            int[] array = { 2,4,5,6,3,8,5};
            int result = Summa(array);
            Console.WriteLine($"Рекурсивная сумма массива == {result}");
        } 
           
              
       
    }
}
