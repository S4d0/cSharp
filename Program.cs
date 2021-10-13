using System;

namespace DiziUygulamaları
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 10 elemanlı integer sayılardan oluşan bir dizi oluşturun, diziyi
            tersten, sıralı ve kullanıcının istediği elemanı ekrana yazdıran 
            programı array class fonksiyonları kullanarak yazdırın. */

            int[] array = new int[] { 12, 43, 56, 32, 15, 76, 65, 23, 41, 77 };

            void printArray(int[] Arr)
            {
                foreach(int elemans in Arr)
                {
                    Console.Write(elemans + ", ");
                }
                Console.Write("\n");
            }
            Console.WriteLine("Original Array");
            printArray(array);
            
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("Print Reversed Array");
            Array.Reverse(array);
            printArray(array);
            
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("Print Sorted Array");
            Array.Sort(array);
            printArray(array);
            Console.WriteLine("--------------------------------------------------------");
            Console.Write("Lütfen bir rakam giriniz: ");
            
            //kullanıcıdan girdi alma
            int number = Convert.ToInt32(Console.ReadLine());
            if (number < 10 && number >= 0)
            {
                Console.WriteLine(array[number]);
            }
            else
            {
                Console.WriteLine("Yanlış rakam girdiniz programdan çıkış yapılıyor");
            }
        }
    }
}
