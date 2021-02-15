using System;

namespace _6._Rendezett_tombok
{
    class Program
    {
        static void Main(string[] args)
        {
            //LinearisKeresesRendezettben(TombBeolvas1(), 5);
            //LogaritmikusKereses(TombBeolvas1(), 5);
            //EldontesRendezettben(TombBeolvas1(), 5);
            //ModositottEldontesRendezettben(TombBeolvas1(), 3, 5);
            //KivalasztasRendezettben(TombBeolvas1(), 5);
            //KivalogatasRendezettben(TombBeolvas1(), 5);
            MegszamlalasRendezettben(TombBeolvas1(), 5);
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
            Console.WriteLine("----------------------------------------------");
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
            Console.WriteLine("----------------------------------------------");
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
        
        static void LinearisKeresesRendezettben(int[] x, int ertek)
        {
            int i = 0;
            while ((i <= (x.Length - 1)) && (x[i] < ertek))
            {
                i++;
                Console.WriteLine(i + ". belépés a ciklusba.");
            }
            Console.WriteLine("----------------------------------------------");
            bool van = (i <= (x.Length - 1)) && (x[i] == ertek);
            if (van)
            {
                Console.WriteLine($"Létezik a keresett elem, a {i + 1}. helyen.");
            }
            else
            {
                Console.WriteLine("Nem létezik a keresett elem.");
            }
        }

        static void LogaritmikusKereses(int[] x, int ertek)
        {
            int bal = 0;
            int jobb = x.Length - 1;
            int center = (bal + jobb) / 2;
            while ((bal <= jobb) && (x[center] != ertek))
            {
                if (x[center] > ertek)
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
            {
                Console.WriteLine($"A keresett elem létezik a {center + 1}. helyen.");
            }
            else
            {
                Console.WriteLine("A keresett elem nem létezik.");
            }
        }

        static void EldontesRendezettben(int[] x, int ertek)
        {
            int bal = 0;
            int jobb = x.Length - 1;
            int center = (bal + jobb) / 2;
            while ((bal <= jobb) && (x[center] != ertek))
            {
                if (x[center] > ertek)
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
            if(van)
                Console.WriteLine("Van ilyen elem.");
            else
                Console.WriteLine("Nincs ilyen elem.");
        }

        static void ModositottEldontesRendezettben(int[] x, int alsohatar, int felsohatar)
        {
            int bal = 0;
            int jobb = x.Length - 1;
            int center = (bal + jobb) / 2;
            while ((bal <= jobb) && !((alsohatar <= x[center]) && x[center] <= felsohatar))
            {
                if (x[center] > felsohatar)
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
                Console.WriteLine("Van olyan elem, ami az intervallumba esik.");
            else
                Console.WriteLine("Nincs olyan elem, ami az intervallumba esik.");
        }
        
        static void KivalasztasRendezettben(int[] x, int ertek)
        {
            int bal = 0;
            int jobb = x.Length - 1;
            int center = (bal + jobb) / 2;
            while (x[center] != ertek)
            {
                if (x[center] > ertek)
                {
                    jobb = center - 1;
                }
                else
                {
                    bal = center + 1;
                }
                center = (bal + jobb) / 2;
            }
            Console.WriteLine($"A keresett elem a {center + 1}. helyen van.");
        }

        static void KivalogatasRendezettben(int[] x, int ertek)
        {
            int bal = 0;
            int jobb = x.Length - 1;
            int center = (bal + jobb) / 2;
            while ((bal <= jobb) && (x[center] != ertek))
            {
                if (x[center] > ertek)
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
            {
                bal = center;
                while ((bal > 0) && (x[bal - 1] == ertek))
                {
                    bal--;
                }
                jobb = center;
                while ((jobb < x.Length - 1) && (x[jobb + 1] == ertek))
                {
                    jobb++;
                }
                Console.WriteLine($"Van(nak) ilyen elem(ek), {bal + 1}. elemtől, a {jobb + 1}. elemig.");
            }
            else
            {
                Console.WriteLine("Nincs egy ilyen elem sem.");
            }
        }

        static void MegszamlalasRendezettben(int[] x, int ertek)
        {
            int bal = 0;
            int jobb = x.Length - 1;
            int center = (bal + jobb) / 2;
            while ((bal <= jobb) && (x[center] != ertek))
            {
                if (x[center] > ertek)
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
            {
                bal = center;
                while ((bal > 0) && (x[bal - 1] == ertek))
                {
                    bal--;
                }
                jobb = center;
                while ((jobb < x.Length - 1) && (x[jobb + 1] == ertek))
                {
                    jobb++;
                }
                Console.WriteLine($"Van {jobb - bal + 1} darab a keresett elemből.");
            }
            else
            {
                Console.WriteLine("Nincs egy ilyen elem sem.");
            }
        }
    }
}
