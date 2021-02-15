using System;

namespace _4_Prog_Tetelek_Osszeepitese
{
    class Program
    {
        static void Main(string[] args)
        {
            //Masolas_Es_Maximumkivalasztas(TombBeolvas1());
            //Megszamlalas_Es_Kereses(TombBeolvas1(), 3);
            //Maximumkivalasztas_Es_Kivalogatas(TombBeolvas1());
            Kivalogatas_Es_Maximumkivalasztas(TombBeolvas1());
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

        static void Masolas_Es_Maximumkivalasztas(int[] x)
        {
            int max = 0;
            double maxertek = Math.Pow((double)x[0], 2.00);
            for (int i = 1; i < x.Length; i++)
            {
                double seged = Math.Pow((double)x[i], 2.00);
                if (maxertek < seged)
                {
                    max = i;
                    maxertek = seged;
                    Console.WriteLine($"Maxindex: {max + 1}, maxérték: {maxertek}");
                }
            }
            Console.WriteLine($"Maxindex: {max + 1}, maxérték: {maxertek}");
        }

        static void Megszamlalas_Es_Kereses(int[] x, int k/*hányadikig*/)
        {
            int db = 0;
            int i = -1;
            while ((i < x.Length - 1) && (db < k))
            {
                i++;
                if (x[i] % 2 == 0)
                {
                    db++;
                }
                Console.WriteLine($"db = {db}");
            }
            bool van = db == k;
            if (van)
            {
                Console.WriteLine($"Van legalább {k} ilyen elem, a legutolsó a {i + 1}. helyen.");
            }
            else
            {
                Console.WriteLine($"Nincs {k} ilyen elem.");
            }
        }

        static void Maximumkivalasztas_Es_Kivalogatas(int[] x)
        {
            int[] y = new int[x.Length];
            int maxertek = x[0];
            int db = 0;
            y[db] = 0;
            for (int i = 1; i < x.Length; i++)
            {
                if (x[i] > maxertek)
                {
                    maxertek = x[i];
                    db = 0;
                    y[db] = i;
                }
                else if (x[i] == maxertek)
                {
                    db++;
                    y[db] = i;
                }
            }

            string yString = "";
            for (int i = 0; i < y.Length; i++)
            {
                yString += (y[i] + 1) + ", ";
            }
            Console.WriteLine($"y = {yString}; db = {db + 1}");
        }

        static void Kivalogatas_Es_Maximumkivalasztas(int[] x)
        {
            int maxertek = int.MinValue;
            int max = -1;
            for (int i = 0; i < x.Length; i++)
            {
                if ((x[i] % 2 == 0) && (x[i] > maxertek))
                {
                    max = i;
                    maxertek = x[i];
                }
            }
            bool van = maxertek > int.MinValue;
            if (van)
            {
                Console.WriteLine($"Van ilyen, és a legnagyobb helye {max + 1}, értéke {maxertek}.");
            }
            else
            {
                Console.WriteLine("Nincs ilyen tulajdonságú elem.");
            }
        }
    }
}
