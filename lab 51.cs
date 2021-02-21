using System;

namespace лабка_5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //сішарп лабка 5.1
            float[] M = new float[12];
            M[0] = 4;
            Console.WriteLine("b=");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("n=");
            int n = int.Parse(Console.ReadLine());
            int i;
            
            for (i = 0; i < n; i++) ;
                double  y,x;
                x = (Math.Pow(b, i)) / 12;
                y = Math.Sin(x);
                double el;
                el = M[i - 1] + y;
                Console.WriteLine("a12={0}",el);
        }
    }
}
