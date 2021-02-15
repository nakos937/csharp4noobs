using System;

namespace _2_osszetett_prog_tetelek1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Masolas(TombBekeres());
            //Kivalogatas(TombBekeres());
            //KivalogatasEredetiTomb(TombBekeres());
            //KivalogatasEredetiTomb_EredetiElemMegtart(TombBekeres());
            //Szetvalogatas(TombBekeres());
            //SzetvalogatasEgyUjTomb(TombBekeres());
            //SzetvalogatasEredetiTombben(TombBekeres());
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

        static void Masolas(int[] x)
        {
            int[] y = new int[x.Length];
            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine($"{i + 1}. lefutás, y[{i + 1}] = f(x[{i + 1}])");
                y[i] = x[i] * 2;
            }
            Console.WriteLine("------------------------\nVissza:\n");
            for (int i = 0; i < y.Length; i++)
            {
                Console.WriteLine($"y[{i + 1}] = {y[i]}");
            }
        }

        static void Kivalogatas(int[] x)
        {
            int[] y = new int[x.Length];
            int db = -1;
            for (int i = 0; i < y.Length; i++)
            {
                if (x[i] % 2 == 0)
                {
                    db++;
                    y[db] = x[i];
                    Console.WriteLine($"{i + 1}. ciklus, db = {db + 1}, y[db] = {y[db]}");
                }
            }
            Console.WriteLine("----------------------------------\nVissza:\n");
            for (int i = 0; i < y.Length; i++)
            {
                Console.WriteLine($"y[{i + 1}] = {y[i]}");
            }
            Console.WriteLine("Db = " + (db + 1));
        }

        static void KivalogatasEredetiTomb(int[] x)
        {
            int db = -1;
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] % 2 == 0)
                {
                    db++;
                    x[db] = x[i];
                    Console.WriteLine($"{i + 1}. ciklus, db = {db + 1}, x[db] = {x[db]}");
                }
            }
            Console.WriteLine("----------------------------------\nVissza:\n");
            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine($"x[{i + 1}] = {x[i]}");
            }
            Console.WriteLine("Db = " + (db + 1));
        }

        static void KivalogatasEredetiTomb_EredetiElemMegtart(int[] x)
        {
            int db = -1;
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] % 2 == 0)
                {
                    db++;
                    int seged = x[db];
                    x[db] = x[i];
                    x[i] = seged;

                    Console.WriteLine($"{i + 1}. ciklus, db = {db + 1}, x[db] = {x[db]}");
                }
            }
            Console.WriteLine("----------------------------------\nVissza:\n");
            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine($"x[{i + 1}] = {x[i]}");
            }
            Console.WriteLine("Db = " + (db + 1));
        }

        static void Szetvalogatas(int[] x)
        {
            int[] y1 = new int[x.Length];
            int[] y2 = new int[x.Length];
            int db1 = -1;
            int db2 = -1;

            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] % 2 == 0)
                {
                    db1++;
                    y1[db1] = x[i];
                    Console.WriteLine($"{i + 1}. ciklus, y1-hez kerül az elem({y1[db1]}), db1 = {db1 + 1}");
                }
                else
                {
                    db2++;
                    y2[db2] = x[i];
                    Console.WriteLine($"{i + 1}. ciklus, y2-hez kerül az elem({y2[db2]}), db2 = {db2 + 1}");
                }
            }

            string y1String = "";
            for (int i = 0; i < y1.Length; i++)
            {
                y1String += y1[i] + ", ";
            }
            Console.WriteLine($"y1 = {y1String}; db1 = {db1 + 1}");

            string y2String = "";
            for (int i = 0; i < y2.Length; i++)
            {
                y2String += y2[i] + ", ";
            }
            Console.WriteLine($"y2 = {y2String}; db2 = {db2 + 1}");
        }

        static void SzetvalogatasEgyUjTomb(int[] x)
        {
            int[] y = new int[x.Length];
            int db = -1;
            int jobb = x.Length;

            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] % 2 == 0)
                {
                    db++;
                    y[db] = x[i];
                    Console.WriteLine($"{i + 1}. ciklus, y elejére kerül az elem({y[db]}), db = {db + 1}");
                }
                else
                {
                    jobb--;
                    y[jobb] = x[i];
                    Console.WriteLine($"{i + 1}. ciklus, y végére kerül az elem({y[jobb]}), jobb = {jobb + 1}");
                }
            }

            string y1String = "";
            for (int i = 0; i < y.Length; i++)
            {
                y1String += y[i] + ", ";
            }
            Console.WriteLine($"y = {y1String}; db = {db + 1}");  
        }

        static void SzetvalogatasEredetiTombben(int[] x)
        {
            int bal = 0;
            int jobb = x.Length - 1;
            int seged = x[0];
            int counter = 0;
            while (bal < jobb)
            {
                counter++;
                Console.WriteLine(counter + ". belépés a külső ciklusba: ");
                while ((bal < jobb) && !(x[jobb] % 2 == 0))
                {
                    jobb--;
                    Console.WriteLine("Eltolom a jobbot balra, jobb = " + (jobb + 1));
                }

                if (bal < jobb)
                {
                    x[bal] = x[jobb];
                    Console.WriteLine("Baladik elemet egyenlővé teszem a jobbadik elemmel.");
                    bal++;
                    Console.WriteLine("Balt eltolom jobbra, bal = " + (bal + 1));
                    while ((bal < jobb) && (x[bal] % 2 == 0))
                    {
                        bal++;
                        Console.WriteLine("Eltolom a balt jobbra, bal = " + (bal + 1));
                    }
                    if (bal < jobb)
                    {
                        x[jobb] = x[bal];
                        Console.WriteLine("Jobbadik elemet egyenlővé teszem a Baladik elemmel.");
                        jobb--;
                        Console.WriteLine("Jobbot eltolom balra, jobb = " + (jobb + 1));
                    }
                }

                string xString = "";
                for (int i = 0; i < x.Length; i++)
                {
                    xString += x[i] + ", ";
                }
                Console.WriteLine($"y = {xString}; bal = {bal + 1}; jobb = {jobb + 1}");
            }
            x[bal] = seged;
            Console.WriteLine("Baladik elem = segéd");
            int db;
            if (x[bal] % 2 == 0)
            {
                db = bal;
                Console.WriteLine("Segédre igaz a feltétel db = bal");
            }
            else
            {
                db = bal - 1;
                Console.WriteLine("Segédre nem igaz a feltétel db = bal - 1");
            }

            string xString2 = "";
            for (int i = 0; i < x.Length; i++)
            {
                xString2 += x[i] + ", ";
            }
            Console.WriteLine($"y = {xString2}; db = {db + 1}");
        }
    }
}
