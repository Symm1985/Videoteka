﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoTeka
{
    class Bongeszfuggveny
    {
        static public void Cimkeres(List<Filmek> Videotar)
        {
            foreach (Filmek x in Videotar)
            {
                Console.WriteLine("Kérem adja meg melyik filmet keresi:");
                string filmkeres = Console.ReadLine();
                if (filmkeres == x.Cim)
                {
                    Console.WriteLine("Cím: {0}", x.Cim);
                    Console.WriteLine("Megjelenés: {0}", x.Megjelenesdatuma);
                    Console.WriteLine("Korhatár: {0}", x.Korhatar);
                    Console.WriteLine("Műfaj: {0}", x.Mufaj);
                    Console.WriteLine("Elhelyezkedés: {0}", x.Holvan);
                }
                else
                {
                    Console.WriteLine("A film nem található a videotárban.");
                }
            }
        }
        static public void Mufajkeres(List<Filmek> Videotar)
        {
            foreach (Filmek x in Videotar)
            {
                Console.WriteLine("Kérem adja meg milyen műfajú filmet keres:");
                string mufajkeres = Console.ReadLine();
                if (mufajkeres == x.Mufaj)
                {
                    Console.WriteLine("Cím: {0}", x.Cim);
                    Console.WriteLine("Megjelenés: {0}", x.Megjelenesdatuma);
                    Console.WriteLine("Korhatár: {0}", x.Korhatar);
                    Console.WriteLine("Műfaj: {0}", x.Mufaj);
                    Console.WriteLine("Elhelyezkedés: {0}", x.Holvan);
                    Console.WriteLine("*****************************************");
                }
                else
                {
                    Console.WriteLine("Ilyen műfajú film nem található a videótárban.");
                }
            }
        }
        static public void Korahatarkeres(List<Filmek> Videotar)
        {
            foreach (Filmek x in Videotar)
            {
                Console.WriteLine("Kérem adja meg milyen korhatárú filmet keres:");
                int korhatarkeres = Convert.ToInt32(Console.ReadLine());
                if (korhatarkeres == x.Korhatar)
                {
                    Console.WriteLine("Cím: {0}", x.Cim);
                    Console.WriteLine("Megjelenés: {0}", x.Megjelenesdatuma);
                    Console.WriteLine("Korhatár: {0}", x.Korhatar);
                    Console.WriteLine("Műfaj: {0}", x.Mufaj);
                    Console.WriteLine("Elhelyezkedés: {0}", x.Holvan);
                    Console.WriteLine("*****************************************");
                }
                else
                {
                    Console.WriteLine("Ilyen korhatárú film nem található a videótárban.");
                }
            }
        }
    }
}

