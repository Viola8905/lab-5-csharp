using System;

namespace лабка_5._3
{
    class Program
    {
        static int Factorial(int k)
        {
            if (k == 0)
                return 1;
            else
                return k * Factorial(k - 1);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("x");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("e");
            double e = Convert.ToDouble(Console.ReadLine());


            double s =x;

            int n = 2;
            double y = Math.Abs(Math.Pow(-1, n - 1) * (Math.Pow(x, 2 * n - 1) / Factorial(2*n - 1)));
            
            while (y > e)
            {

                s = s+ Math.Pow(-1, n - 1) * (Math.Pow(x, 2 * n - 1) / Factorial(2 * n - 1));
                n = n + 1;
                
                if (n==x)
                {
                    break;
                }
            }
            Console.WriteLine("sinx={0}", s);
        }
    }
}
