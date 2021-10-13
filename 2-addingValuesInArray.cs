using System;

// create 10 element array and adding user entered values to the array.

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            // creating array with 10 elements
            int[] Arr = new int[10];
            int a;
            // inserting array elements
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Please insert the {0} element for the array: ",i+1);
                a =Convert.ToInt32(Console.ReadLine());
                Arr[i] = a;
            }

            // squaring array elements and finding the average.
            int sum = 0;
            double avrg(int elemntNumber)
            {
                for (int i = 0; i < elemntNumber; i++)
                {
                    sum += Arr[i] * Arr[i];
                }
                return sum / elemntNumber; 
            }

            Console.WriteLine(avrg(10));
        }
    }
}
