using System;

namespace _8_Halmazok_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //HalmazokUnioja(TombBeolvas1(), TombBeolvas2());
            //HalmazokMetszete(TombBeolvas1(), TombBeolvas2());
            //HalmazokKulonbsege(TombBeolvas1(), TombBeolvas2()); // a1\a2
            HalmazokSzimmetrikusDifferenciaja(TombBeolvas1(), TombBeolvas2());
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

        static void HalmazokUnioja(int[] a1, int[] a2)
        {
            int[] b = new int[a1.Length + a2.Length];
            int i = 0;
            int j = 0;
            int db = -1;
            a1 = Ujradeklaralas(a1);
            a2 = Ujradeklaralas(a2);
            while ((i < (a1.Length - 1)) || (j < (a2.Length - 1)))
            {
                db++;
                if (a1[i] < a2[j])
                {
                    b[db] = a1[i];
                    i++;
                }
                else if(a1[i] > a2[j])
                {
                    b[db] = a2[j];
                    j++;
                }
                else
                {
                    b[db] = a1[i];
                    i++;
                    j++;
                }
            }
            Kiiras(b, db);
        }

        static void HalmazokMetszete(int[] a1, int[] a2)
        {
            int[] b;
            if (a1.Length < a2.Length)
                b = new int[a1.Length];
            else
            {
                b = new int[a2.Length];
            }
            int i = 0;
            int j = 0;
            int db = -1;
            while ((i <= (a1.Length - 1)) && (j <= (a2.Length - 1)))
            {
                if (a1[i] < a2[j])
                {
                    i++;
                }
                else if (a1[i] > a2[j])
                {
                    j++;
                }
                else
                {
                    db++;
                    b[db] = a1[i];
                    i++;
                    j++;
                }
                Kiiras(b, db);
            }
            Kiiras(b, db);
        }

        static void HalmazokKulonbsege(int[] a1, int[] a2) //  a1\a2
        {
            int[] b = new int[a1.Length];
            int i = 0;
            int j = 0;
            int db = -1;
            while ((i <= (a1.Length - 1)) && (j <= (a2.Length - 1)))
            {
                if (a1[i] < a2[j])
                {
                    db++;
                    b[db] = a1[i];
                    i++;
                }
                else if (a1[i] > a2[j])
                {
                    j++;
                }
                else
                {
                    i++;
                    j++;
                }
                Kiiras(b, db);
            }
            while (i <= (a1.Length - 1))
            {
                db++;
                b[db] = a1[i];
                i++;
                Kiiras(b, db);
            }
            Kiiras(b, db);
        }

        static void HalmazokSzimmetrikusDifferenciaja(int[] a1, int[] a2)
        {
            int[] b = new int[a1.Length + a2.Length];
            int i = 0;
            int j = 0;
            int db = -1;
            while ((i <= (a1.Length - 1)) && (j <= (a2.Length - 1)))
            {
                if (a1[i] < a2[j])
                {
                    db++;
                    b[db] = a1[i];
                    i++;
                }
                else if (a1[i] > a2[j])
                {
                    db++;
                    b[db] = a2[j];
                    j++;
                }
                else
                {
                    i++;
                    j++;
                }
                Kiiras(b, db);
            }
            while (i <= (a1.Length - 1))
            {
                db++;
                b[db] = a1[i];
                i++;
                Kiiras(b, db);
            }
            while (j <= (a2.Length - 1))
            {
                db++;
                b[db] = a2[j];
                j++;
                Kiiras(b, db);
            }
            Kiiras(b, db);
        }
    }
}
