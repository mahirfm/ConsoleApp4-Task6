﻿namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1.  a massivinin (a[0],a[1] .... a[n])  |a[i]| < c sertini odeyen elementlerini cap etmek
                (c deyisheninin qiymeti istifadeciden sorushulur,hemcinin a massivinin elementleri de)
               */ // Done

            int[] ints = new int[6];

            int counter = 0;

            Console.WriteLine("6 eded daxil edin:");

            ints[0] = int.Parse(Console.ReadLine());
            ints[1] = int.Parse(Console.ReadLine());
            ints[2] = int.Parse(Console.ReadLine());
            ints[3] = int.Parse(Console.ReadLine());
            ints[4] = int.Parse(Console.ReadLine());
            ints[5] = int.Parse(Console.ReadLine());

            double reply = 0;
            int[] ededler;
            int[] Kededler;

            double len = 0;
            double sum = 0;
            int a = 0;
            double sm = 1;
            double hno;


            Console.WriteLine("secdiyiniz ededler:");

            for (int u = 0; u < ints.Length; u++)
            {
                Console.WriteLine(ints[u]);
            }

            Console.WriteLine("Muqayise olunacaq ededi daxil et:");
            int eded = int.Parse(Console.ReadLine());




            for (int i = 0; i < ints.Length; i++)
            {
                /*2.  a massivinin (a[0],a[1] .... a[n])  |a[i]| < c sertini odeyen
                * elementlerinin ededi ortasini tapmaq*/ // Done



                if (ints[i] < eded)
                {
                    counter++;
                    int x = counter - 1;
                    ededler = new int[counter];
                    ededler[x] = ints[i];


                    Console.WriteLine($"Yeni Massiv ---   " + ededler[x]);


                    for (a = 0; a < ededler.Length; a++)
                    {
                        sum += ededler[a];


                    }



                    Console.WriteLine("----------------------------------------------------------------------");

                    sm *= ededler[x];
                    len = ededler.Length;



                }

                // 2 Ci aray


                if (ints[i] > eded)
                {
                    counter++;
                    int F = counter - 1;
                    Kededler = new int[counter];
                    Kededler[F] = ints[i];
                    Console.WriteLine($"Yeni Massiv 2 ---   " + Kededler[F]);

                    Array.Sort(Kededler);
                    Array.Reverse(Kededler);

                    Console.WriteLine($"Yeni Massiv 2 Z-A ---   " + Kededler[F]);


                }











            }

            reply = sum / len;
            double ok = 1 / len;



            hno = Math.Pow(sm, ok);



            Console.WriteLine("Hendesi orta --");
            Console.WriteLine(hno);



            Console.WriteLine("ededi orta --");

            Console.WriteLine(reply);







        }
    }
}