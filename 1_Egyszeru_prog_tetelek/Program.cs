using System;

namespace _1_Egyszeru_prog_tetelek
{
    class Program
    {
        static void Main(string[] args)
        {
            //int sorozatszam = Sorozatszámítás(TombBekeres()); 
            //bool eldontes = Eldontes(TombBekeres()); //van-e olyan elem?
            //bool modositottEldontes = ModositottEldontes(TombBekeres()); //minden elem olyan?
            //int idxKivalasztas = Kivalasztas(TombBekeres()); //tudjuk, hogy van, de hol?
            //LinearisKereses(TombBekeres());
            //Megszamlalas(TombBekeres());
            //MaximumKivalasztas(TombBekeres());

        }

        static int[] TombBekeres()
        {
            Console.WriteLine("Hány elemű tömb?");
            int[] x = new int[int.Parse(Console.ReadLine())];
            for (int i = 0; i < x.Length; i++)
            {
                Console.Write($"{i + 1}. elem: ");
                x[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("---------------------------------------------");
            return x;
        }

        static int Sorozatszámítás(int[] x)
        {
            int ertek = 0;
            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine($"{i + 1}. számítás: {ertek} + {x[i]} = {ertek + x[i]}");
                ertek = ertek + x[i];
            }
            Console.WriteLine("Végső érték: " + ertek);
            return ertek;
        }

        static bool Eldontes(int[] x)
        {
            int i = 0;
            while ((i <= (x.Length - 1)) && !(x[i] % 2 == 0))
            {
                Console.WriteLine($"{i + 1}. lefutás");
                i++;
            }
            bool van = (i <= (x.Length - 1));
            Console.WriteLine(van);
            return van;
        }

        static bool ModositottEldontes(int[] x)
        {
            int i = 0;
            while ((i <= (x.Length - 1)) && (x[i] % 2 == 0))
            {
                Console.WriteLine($"{i + 1}. lefutás");
                i++;
            }
            bool van = (i > (x.Length - 1));
            Console.WriteLine(van);
            return van;
        }

        static int Kivalasztas(int[] x)
        {
            int i = 0;
            while (!(x[i] % 2 == 0))
            {
                Console.WriteLine($"{i + 1}. lefutás");
                i++;
            }
            int idx = i + 1;
            Console.WriteLine("Az első előfordulás: " + idx);
            return idx;
        }

        static void LinearisKereses(int[] x)
        {
            int i = 0;
            while ((i <= x.Length - 1) && !(x[i] % 2 == 0))
            {
                Console.WriteLine((i + 1) + ". lefutás.");
                i++;
            }
            bool van = (i <= x.Length - 1);
            if (van)
                Console.WriteLine($"Igaz, és idx = {i + 1}");
            else
                Console.WriteLine("Nincs");
        }

        static void Megszamlalas(int[] x)
        {
            int db = 0;
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] % 2 == 0)
                    db++;
                Console.WriteLine((i + 1) + ". lefutás: db = " + db);
            }
            Console.WriteLine("Vissza: " + db);
        }

        static void MaximumKivalasztas(int[] x)
        {
            int max = 0;
            for (int i = 1; i < x.Length; i++)
            {
                if (x[i] > x[max])
                    max = i;
                Console.WriteLine($"{i + 1}. elem vizsgálata: jelenleg a max index = {max + 1}");
            }
            Console.WriteLine("Vissza: " + (max + 1));
        }
    }
}
