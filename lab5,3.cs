using System;

namespace лабка_5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("x");
            double x = Convert.ToDouble(Console.ReadLine());
            const double e = 2.7;
            
            double s=x;
            Console.WriteLine("n");
            int  n =Convert.ToInt32( Console.ReadLine());
             
            int factorial=1;

            for (int i = 2; i <=2*n-1; i++) 
            {
                factorial = factorial * i;
            }

            double y = Math.Pow(-1, n - 1) * (Math.Pow(x, 2 * n - 1) / factorial);

            while (y <= e)
            {

                s = Math.Pow(-1, n - 1) * (Math.Pow(x, 2 * n - 1) / factorial);
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
