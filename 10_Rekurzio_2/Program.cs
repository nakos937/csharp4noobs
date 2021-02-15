using System;

namespace _10_Rekurzio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int szam1 = 4; //index, szóval +1-et számolj rá

            //Console.WriteLine($"Sorozatszámítás rekurzívan, az első {szam1 + 1} elemre: {SorozatszamitasRekurziv(TombBeolvas1(), szam1)}");
            //Console.WriteLine($"Megszámlálás rekurzívan(páros számok by default), az első {szam1 + 1} elemre: {MegszamlalasRekurzivan(TombBeolvas1(), szam1)} db");
            //Console.WriteLine($"Maximum kiválasztás rekurzívan, az első {szam1 + 1} elemben: a max elem a {MaximumKivalasztasrekurziv(TombBeolvas1(), szam1) + 1} helyen van");
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

        static int SorozatszamitasRekurziv(int[] x, int jobb)
        {
            if (jobb == -1)
            {
                return 0;
            }
            else
            {
                return SorozatszamitasRekurziv(x, jobb - 1) + x[jobb];
            }
        }

        static int MegszamlalasRekurzivan(int[] x, int jobb)
        {
            if (jobb == -1)
            {
                return 0;
            }
            else if(x[jobb] % 2 == 0)
            {
                return 1 + MegszamlalasRekurzivan(x, jobb - 1);
            }
            else
            {
                return MegszamlalasRekurzivan(x, jobb - 1);
            }
        }

        static int MaximumKivalasztasrekurziv(int[] x, int jobb)
        {
            if (jobb == 0)
            {
                return 0;
            }
            else
            {
                int max = MaximumKivalasztasrekurziv(x, jobb - 1);
                if (x[jobb] > x[max])
                {
                    return jobb;
                }
                else
                {
                    return max;
                }
            }
        }
    }
}
