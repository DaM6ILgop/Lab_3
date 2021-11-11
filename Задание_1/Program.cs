using System;

namespace Задание_1_лаб_3
{
    class Program
    {
        public static void Reverse(int[] array) { }
        static void Main(string[] args)
        {
             point:
            try
            {
                Console.WriteLine("Введите кол-во элементов массива");
                int mas = int.Parse(Console.ReadLine());
                int[] myArray = new int[mas];
                Random rand = new Random();
                int variable =0;

                for (int x = 0; x < myArray.Length; x++) {
                
                    myArray[x] = rand.Next(-30, 45);
                    Console.Write(myArray[x] + " ");
                    variable++;
                    while (variable == 9) {
                    
                        Console.WriteLine(" ");
                        variable = 0;
                    }
                }
                Console.WriteLine(" ");
                Console.WriteLine("=================================================");
                Console.WriteLine("Положительные элементы в обратном порядке ");
                variable = 1;
                Array.Reverse(myArray);
                foreach (int num in myArray) { 
                
                    if (num >= 0) {
                    
                        Console.Write(num + " ");
                        variable++;
                    }
                    while (variable == 9) {
                    
                        Console.WriteLine("");
                        variable = 0;
                    }
                }
            } 
            catch (FormatException) {
                Console.WriteLine("Ошибка ввода");
                goto point;
            }
        }  
    }
}
