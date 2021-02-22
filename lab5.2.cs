using System;

namespace лабка_5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("x=");
            int X = Convert.ToInt32(Console.ReadLine());
            int k;

            k = X % 10;
            X = X / 10;



            while (X > 0)
            {
                k = Math.Max(k, X % 10);
                X = X / 10;

            }
            Console.WriteLine(k);


            
        }
    }
}
