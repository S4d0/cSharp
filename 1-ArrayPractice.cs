using System;

namespace ArrayPractice

{
    class ArrayPractice
    {
        static void Main(string[] args)
        {
            /* Create a array with 10 integer elements, print the array in reverse order,
             sorted and and the program that prints the element the user wants to 
            the screen with using Array Class functions. */
            
            int[] array = new int[] { 12, 43, 56, 32, 15, 76, 65, 23, 41, 77 };

            void printArray(int[] Arr) // printing array function
            {
                foreach(int elemans in Arr)
                {
                    Console.Write(elemans + ", ");
                }
                Console.Write("\n");
            }
            Console.WriteLine("Original Array");
            printArray(array); // printing array

            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("Print Reversed Array");
            Array.Reverse(array);
            printArray(array); // printing array

            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("Print Sorted Array");
            Array.Sort(array); // array sort function
            printArray(array);
            Console.WriteLine("--------------------------------------------------------");
            Console.Write("Please insert a number (between 0-9) : ");

            // get input from user
            int number = Convert.ToInt32(Console.ReadLine());
            if (number < 10 && number >= 0)
            {
                Console.WriteLine(array[number]);
            }
            else
            {
                Console.WriteLine("Wrong input, exiting the program.");
            }
        }
    }
}
