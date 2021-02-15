using System;

namespace Osszetett_Prog_Tetelek2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Metszet(TombBeolvas1(), TombBeolvas2());
            //KozosElemLetezese(TombBeolvas1(), TombBeolvas2());
            //Unio(TombBeolvas1(), TombBeolvas2());
            //IsmetlodesekKiszurese(TombBeolvas1());
            //Osszefuttatas(TombBeolvas1(), TombBeolvas2());
            OsszefuttatasModositott(TombBeolvas1(), TombBeolvas2());
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

        static void Metszet(int[] x1, int[] x2)
        {
            int[] y = new int[x1.Length];
            int db = -1;
            for (int i = 0; i < x1.Length; i++)
            {
                int j = 0;
                while ((j < x2.Length) && (x1[i] != x2[j]))
                {
                    j++;
                }
                if (j < x2.Length)
                {
                    db++;
                    y[db] = x1[i];
                    Kiiras(y, db);
                }
            }

            Kiiras(y, db);
        }

        static void KozosElemLetezese(int[] x1, int[] x2)
        {
            int i = 0;
            bool van = false;
            while ((i <= (x1.Length - 1)) && !van)
            {
                int j = 0;
                while ((j <= (x2.Length - 1)) && (x1[i] != x2[j]))
                {
                    j++;
                }
                if (j <= (x2.Length - 1))
                    van = true;
                else
                    i++;
            }
            Console.WriteLine(van);
        }

        static void Unio(int[] x1, int[] x2)
        {
            int[] y = new int[x1.Length + x2.Length];
            for (int i = 0; i < x1.Length; i++)
            {
                y[i] = x1[i];
            }
            int db = x1.Length - 1;
            Kiiras(y, db);

            for (int j = 0; j < x2.Length; j++)
            {
                int i = 0;
                while ((i <= (x1.Length - 1)) && x1[i] != x2[j])
                {
                    i++;
                }
                if (i > (x1.Length - 1))
                {
                    db++;
                    y[db] = x2[j];
                    Kiiras(y, db);
                }
            }
            Kiiras(y, db);
        }

        static void IsmetlodesekKiszurese(int[] x)
        {
            int db = 0;
            for (int i = 1; i < x.Length; i++)
            {
                int j = 0;
                while ((j <= db) && (x[i] != x[j]))
                {
                    j++;
                }
                if (j > db)
                {
                    db++;
                    x[db] = x[i];
                    Kiiras(x, db);
                }
            }
            Kiiras(x, db);
        }

        static void Osszefuttatas(int[] x1, int[] x2)
        {
            int[] y = new int[x1.Length + x2.Length];
            int i = 0;
            int j = 0;
            int db = -1;

            while ((i <= (x1.Length - 1)) && j <= (x2.Length - 1))
            {
                db++;
                if (x1[i] < x2[j])
                {
                    y[db] = x1[i];
                    i++;
                    Kiiras(y, db);
                }
                else
                {
                    if (x2[j] < x1[i])
                    {
                        y[db] = x2[j];
                        j++;
                        Kiiras(y, db);
                    }
                    else
                    {
                        y[db] = x1[i];
                        i++;
                        j++;
                        Kiiras(y, db);
                    }
                }
            }

            while (i <= (x1.Length - 1))
            {
                db++;
                y[db] = x1[i];
                i++;
                Kiiras(y, db);
            }
            while (j <= (x2.Length - 1))
            {
                db++;
                y[db] = x2[j];
                j++;
                Kiiras(y, db);
            }
            Kiiras(y, db);
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

        static void OsszefuttatasModositott(int[] x1, int[] x2)
        {
            int[] y = new int[x1.Length + x2.Length];
            x1 = Ujradeklaralas(x1);
            x2 = Ujradeklaralas(x2);
            int i = 0;
            int j = 0;
            int db = -1;

            while ((i < (x1.Length - 1)) || (j < (x2.Length - 1)))
            {
                db++;
                if (x1[i] < x2[j])
                {
                    y[db] = x1[i];
                    i++;
                    Kiiras(y, db);
                }
                else if (x2[j] < x1[i])
                {
                    y[db] = x2[j];
                    j++;
                    Kiiras(y, db);
                }
                else
                {
                    y[db] = x1[i];
                    i++;
                    j++;
                    Kiiras(y, db);
                }
            }
            Kiiras(y, db);
        }
    }
}
