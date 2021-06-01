using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C;
            Console.WriteLine("Введите A:");
            A = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Введите B:");
            B = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Введите C:");
            C = Convert.ToInt16(Console.ReadLine());
            int[] x = Max(A, B, C);

            for (int i = 0; 1 < 3; i++)
            {
                x[i] = x[i] + (i + 1);
            }
            int[] n = Max(x[0], x[1], x[2]);
            Console.WriteLine("большое: {0}\nсреднее: {1}\nмаленькое: {2}\n", n[0], n[1], n[2]);
            Console.ReadLine();

        }
        static int[] Max(int a, int b, int c) {
            int[] n = new int[3];
            if (a < b) {
                if (b < c)
                {
                    n[0] = c;
                    if(a>b)
                    {
                        n[2] = b;
                        n[1] = a;
                    }
                    else
                    {
                        n[2] = a;
                        n[1] = b;

                    }
                }
                else
                {
                    n[0] = b;
                    if (a > c)
                    {
                        n[2] = c;
                        n[1] = a;
                    }
                    else
                    {
                        n[2] = a;
                        n[1] = c;
                    }

                }
            }
            else
            {
                if(a < c)
                {
                    n[0] = c;
                    if (a > b)
                    {
                        n[2] = b;
                        n[1] = a;
                    }
                    else
                    {
                        n[2] = a;
                        n[1] = b;
                    }
                }
                else
                {
                    n[0] = a;
                    if (c>b)
                    {
                        n[2] = b;
                        n[1] = c;
                    }
                    else
                            {
                        n[2] = c;
                        n[1] = b;
                            }
                }
            }
            return n;
        }
    }

}
