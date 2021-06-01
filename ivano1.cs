using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            double k = 0, sum = 0;

            for (int i = 0; i <= n; i++, k++)
                {
                sum = ((k + 1) * (k + 2)) / (k + 3);
                Console.WriteLine(sum);
            }
            Console.ReadLine();
        }
    }
}
