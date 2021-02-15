using System;

namespace _9_Rekurzio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int szam1 = 5, szam2 = 3;
            //FaktorialisIterativ(szam1);
            //Console.WriteLine($"{szam1}! = {FaktorialisRekurziv(szam1)}");
            //Console.WriteLine($"Fibonacci sorozat {szam1}-adik eleme: {FibonacciRekurziv(szam1)}");
            //Console.WriteLine($"{szam1}^{szam2} = {HatvanyRekurziv(szam1, szam2)}");
            Console.WriteLine($"{szam1}^{szam2} = {HatvanyFelezosRekurziv(szam1, szam2)}");
        }

        static int[] TombBeolvas1()
        {
            Console.Write("Hány elemű az (első) tömb?: ");
            int[] x1 = new int[int.Parse(Console.ReadLine())];

            for (int i = 0; i < x1.Length; i++)
            {
                Console.Write($"{i + 1}. elem: ");
                x1[i] = int.Parse(Console.ReadLine());
            }
            return x1;
        }

        static int[] TombBeolvas2()
        {
            Console.Write("Hány elemű a második tömb?: ");
            int[] x2 = new int[int.Parse(Console.ReadLine())];

            for (int i = 0; i < x2.Length; i++)
            {
                Console.Write($"{i + 1}. elem: ");
                x2[i] = int.Parse(Console.ReadLine());
            }
            return x2;
        }

        static void Kiiras(int[] y, int db)
        {
            string yString = "";
            for (int i = 0; i < y.Length; i++)
            {
                yString += y[i] + ", ";
            }
            Console.WriteLine($"y = {yString}; db = {db + 1}");
        }

        static int[] Ujradeklaralas(int[] x)
        {
            int[] x2 = new int[x.Length + 1];
            for (int i = 0; i < x.Length; i++)
            {
                x2[i] = x[i];
            }
            x2[x2.Length - 1] = int.MaxValue;
            return x2;
        }

        static void FaktorialisIterativ(int N)
        {
            int ertek = 1;
            for (int i = 1; i <= N; i++)
            {
                ertek = ertek * i;
            }
            Console.WriteLine($"{N}! = {ertek}");
        }

        static int FaktorialisRekurziv(int N)
        {
            if (N == 0)
            {
                return 1;
            }
            else
            {
                return N * FaktorialisRekurziv(N - 1);
            }
        }

        static int FibonacciRekurziv(int N)
        {
            if (N <= 1)
            {
                return 1;
            }
            else
            {
                return FibonacciRekurziv(N - 2) + FibonacciRekurziv(N - 1);
            }
        }

        static int HatvanyRekurziv(int a, int N)
        {
            if (N == 1)
            {
                return a;
            }
            else
            {
                return a * HatvanyRekurziv(a, N - 1);
            }
        }

        static int HatvanyFelezosRekurziv(int a, int N)
        {
            if (N == 1)
            {
                return a;
            }
            else if(N % 2 == 0)
            {
                int seged = HatvanyFelezosRekurziv(a, N / 2);
                return seged * seged;
            }
            else
            {
                int seged = HatvanyFelezosRekurziv(a, (N-1) / 2);
                return a*seged * seged;
            }
        }
    } 
}
