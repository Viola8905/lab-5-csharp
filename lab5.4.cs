using System;

namespace lab_5._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int fi=0, fi_1=0, fi_2,fi_3;
            fi_2=fi_3 = 9;
            Console.WriteLine("n=");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 3; i <= n; i++)
            {
                fi = fi_3 + fi_2 + fi_1;
                fi_3 = fi_2;
                fi_2 = fi_3;
                fi_3 = fi;
            }
            Console.WriteLine($"f{n}={fi}"); 

        }
    }
}
