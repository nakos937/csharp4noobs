using System;

namespace _5_Rendezesek
{
    class Program
    {
        static void Main(string[] args)
        {
            //MinimumKilavasztasos(TombBeolvas1());
            //Buborekrendezes(TombBeolvas1());
            //JavitottBuborek(TombBeolvas1());
            //Beilleszteses(TombBeolvas1());
            JavitottBeilleszteses(TombBeolvas1());
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

        static void Kiiras(int[] y)
        {
            string yString = "";
            for (int i = 0; i < y.Length; i++)
            {
                yString += y[i] + ", ";
            }
            Console.WriteLine($"y = {yString}");
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

        static void MinimumKilavasztasos(int[] x)
        {
            for (int i = 0; i < x.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < x.Length; j++)
                {
                    if (x[min] > x[j])
                    {
                        min = j;
                    }
                }
                int seged = x[i];
                x[i] = x[min];
                x[min] = seged;
                Kiiras(x);
            }
            Kiiras(x);
        }
        static void Buborekrendezes(int[] x)
        {
            for (int i = x.Length; i > 0; i--)
            {
                for (int j = 0; j < i - 1; j++)
                {
                    if (x[j] > x[j + 1])
                    {
                        int seged = x[j];
                        x[j] = x[j + 1];
                        x[j + 1] = seged;
                        Kiiras(x);
                    }
                }
            }
            Kiiras(x);
        }

        static void JavitottBuborek(int[] x)
        {
            int i = x.Length;
            while (i >= 1)
            {
                int idx = 0;
                for (int j = 0; j < i - 1; j++)
                {
                    if (x[j] > x[j + 1])
                    {
                        int seged = x[j];
                        x[j] = x[j + 1];
                        x[j + 1] = seged;
                        idx = j + 1;
                        Kiiras(x);
                    }
                }
                i = idx;
            }
            Kiiras(x);
        }

        static void Beilleszteses(int[] x)
        {
            for (int i = 1; i < x.Length; i++)
            {
                int j = i - 1;
                while ((j > -1) && (x[j] > x[j + 1]))
                {
                    int seged = x[j];
                    x[j] = x[j + 1];
                    x[j + 1] = seged;
                    j--;
                    Kiiras(x);
                }
                Kiiras(x);
            }
        }

        static void JavitottBeilleszteses(int[] x)
        {
            for (int i = 1; i < x.Length; i++)
            {
                int j = i - 1;
                int seged = x[i];
                while ((j > -1) && (x[j] > seged))
                {
                    x[j + 1] = x[j];
                    j--;
                    Kiiras(x);
                }
                x[j + 1] = seged;
                Kiiras(x);
            }
            Kiiras(x);
        }
    }
}
