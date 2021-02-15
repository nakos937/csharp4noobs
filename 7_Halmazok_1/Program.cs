using System;

namespace _7_Halmazok_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //TartalmazE(TombBeolvas1(), 5);
            ReszhalmazaE(TombBeolvas1(), TombBeolvas2()); //A halmaz részhalmaza-e B halmaznak
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

        static void TartalmazE(int[] a, int ertek)
        {
            int bal = 0;
            int jobb = a.Length - 1;
            int center = (bal + jobb) / 2;
            while ((bal <= jobb) && (a[center] != ertek))
            {
                if (a[center] > ertek)
                {
                    jobb = center - 1;
                }
                else
                {
                    bal = center + 1;
                }
                center = (bal + jobb) / 2;
            }
            bool van = bal <= jobb;
            if (van)
                Console.WriteLine("Benne van az elem.");
            else
                Console.WriteLine("Nincs benne az elem.");
        }

        static void ReszhalmazaE(int[] a, int[] b) //A halmaz részhalmaza-e B halmaznak
        {
            int i = 0;
            int j = 0;
            while ((i <= (a.Length - 1)) && (j <= (b.Length - 1)) && (a[i] >= b[j]))
            {
                if (a[i] == b[j])
                {
                    i++;
                }
                j++;
            }
            bool reszhalmaz = i > (a.Length - 1);
            if(reszhalmaz)
                Console.WriteLine("Részhalmaza");
            else
                Console.WriteLine("Nem részhalmaza");
        }
    }
}
