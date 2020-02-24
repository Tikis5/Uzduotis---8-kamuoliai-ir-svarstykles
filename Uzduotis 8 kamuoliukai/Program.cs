using System;

namespace Uzduotis_8_kamuoliukai
{
    class Program
    {
        static void Main(string[] args)
        {
            var rnd = new Random();

            var k1 = 10;
            var k2 = 10;
            var k3 = 10;
            var k4 = 10;
            var k5 = 10;
            var k6 = 10;
            var k7 = 10;
            var k8 = 10;
            //pirmas variantas
            //rnd.Next(1, 8);

            //antras variantas
            int[] kamuoliai = {k1, k2, k3, k4, k5, k6, k7, k8};
            var a = rnd.Next(kamuoliai.Length);
            //tik tikrinimui kuris indeksas buvo parinktas is masyvo
            Console.WriteLine(a);
            //kamuolio mazinimas
            if (a == 0)
            {
                --k1;
            }
            else if (a == 1)
            {
                --k2;
            }
            else if (a == 2)
            {
                --k3;
            }
            else if (a == 3)
            {
                --k4;
            }
            else if (a == 4)
            {
                --k5;
            }
            else if (a == 5)
            {
                --k6;
            }
            else if (a == 6)
            {
                --k7;
            }
            else
            {
                --k8;
            }
            //Sverimas
            if ((k1 + k2 + k3) < (k4 + k5 + k6))
            {
                if (k1 > k2)
                {
                    Console.WriteLine("Antras kamuolys yra lengvesnis");
                }
                else if (k1 < k2)
                {
                    Console.WriteLine("Pirmas kamuolys yra lengvesnis");
                }
                else
                {
                    Console.WriteLine("Trecias kamuolys yra lengvesnis");
                }
            }
            else if ((k1 + k2 + k3) > (k4 + k5 + k6))
            {
                if (k4 > k5)
                {
                    Console.WriteLine("Penktas kamuolys yra lengvesnis");
                }
                else if (k4 < k5)
                {
                    Console.WriteLine("Ketvirtas kamuolys yra lengvesnis");
                }
                else
                {
                    Console.WriteLine("Sestas kamuolys yra lengvesnis");
                }
            }

            else
            {
                if (k7 > k8)
                {
                    Console.WriteLine("Astuntas kamuolys yra lengvesnis");
                }
                else
                {
                    Console.WriteLine("Septintas kamuolys yra lengvesnis");
                }
            }
            Console.ReadLine();

        }
    }
}
