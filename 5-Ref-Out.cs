using System;

namespace RefOut
{
    class Program
    {
        static int recursiveFactorial(int num)
        {
            if (num == 1)
                return 1;
            return recursiveFactorial(num - 1) * num;
        }

        static void RefAdd(ref int add, int a, int b)
        {
            add = a + b;
        }

        static void OutMultply(out int multply, int a, int b)
        {
            multply = a * b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(recursiveFactorial(7));
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("*****************************");
            Console.WriteLine();
            Console.WriteLine();
            
            int sum = 0;
            RefAdd(ref sum, 25, 5);
            Console.WriteLine(sum);
            Console.WriteLine("*****************************");
            Console.WriteLine();
            Console.WriteLine();
            int multply;
            OutMultply(out multply, 25, 5);
            Console.WriteLine(multply);

        }
    }
}
