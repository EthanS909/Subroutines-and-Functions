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

            int d = 36;
            int e = 78;
            int f = 58;
            int g = 0;
            g = task3(d, e, f);
            Console.WriteLine(g);

            Double h = 0d;
            Double i = 0d;
            Console.WriteLine("Enter a number:");
            h = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter a second number:");
            i = Convert.ToDouble(Console.ReadLine());
            task4(h, i);
        }

        static void task2(int a, int b, int c)
        {
            int result = a + b + c;
            Console.WriteLine(result);
        }

        static int task3(int a, int b, int c)
        {
            int result = a + b + c;

            return result;
        }

        static void task4(Double a, Double b)
        {
            Double opposite = Math.Pow(a, 2);
            Double adjacent = Math.Pow(b, 2);
            Double hyposquare = opposite + adjacent;
            Double hypo = Math.Sqrt(hyposquare);
            Console.WriteLine("Hypotenuse = {0}", hypo);
        }
    }
}
