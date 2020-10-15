using System;

namespace Subroutines_and_Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 23;
            int b = 34;
            int c = 75;

            task2(a, b, c);
        }

        static void task2(int a, int b, int c)
        {
            int result = a + b + c;
            Console.WriteLine(result);
        }
    }
}
