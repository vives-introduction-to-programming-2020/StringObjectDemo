using System;

namespace StringObjectDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string hello = "Hello";
            string hallo = new string("Hello");

            if (hello == hallo)     // INHOUDELIJKE VERGELIJKING
            {
                Console.WriteLine("Both are equal");
            }

            int[] number = { 1, 2, 3 };
            int[] values = { 1, 2, 3 };

            if (number == values)       // REFERENTIES WORDEN VERGELEKEN
            {
                Console.WriteLine("Numbers == values");
            }

            Random generator1 = new Random();
            Random generator2 = generator1;
            Random generator3 = new Random();

            if (generator1 == generator2)
            {
                Console.WriteLine("generator1 == generator2");
            }

            if (generator1 == generator3)
            {
                Console.WriteLine("generator1 == generator3");
            }

            int a = 5;
            int b = a;

            if (b == a)
            {
                Console.WriteLine("1. b == a");
            }

            b = 6;

            if (b == a)
            {
                Console.WriteLine("2. b == a");
            }
        }
    }
}
