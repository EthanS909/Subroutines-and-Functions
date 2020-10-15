using System;

namespace Subroutines_and_Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            int c = 0;
            Console.WriteLine("Enter 3 numbers:");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            task2(a, b, c);

            int d = 36;
            int e = 78;
            int f = 58;
            int g = 0;
            Console.WriteLine("Enter 3 numbers:");
            d = Convert.ToInt32(Console.ReadLine());
            e = Convert.ToInt32(Console.ReadLine());
            f = Convert.ToInt32(Console.ReadLine());
            g = task3(d, e, f);
            Console.WriteLine(g);

            Double h = 0d;
            Double i = 0d;
            Console.WriteLine("Enter a number:");
            h = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter a second number:");
            i = Convert.ToDouble(Console.ReadLine());
            task4(h, i);

            Double j = 0d;
            Double k = 0d;
            Double l = 0d;
            Console.WriteLine("Enter a number:");
            j = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter a second number:");
            k = Convert.ToDouble(Console.ReadLine());
            l = task5(j, k);
            Console.WriteLine("Hypotenuse = {0}", l);
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

        static Double task5(Double a, Double b)
        {
            Double opposite = Math.Pow(a, 2);
            Double adjacent = Math.Pow(b, 2);
            Double hyposquare = opposite + adjacent;
            Double hypo = Math.Sqrt(hyposquare);

            return hypo;
        }
    }
}
