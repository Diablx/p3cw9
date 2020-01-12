using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab9
{
    public static class ExtensionMethods
    {
        public static (int wynik, int resztaZDzielenia) DzielenieZreszta(this int liczba, int dzielnik)
        {
            return (liczba / dzielnik, liczba % dzielnik);
        }
        public static int ZliczZnaki(this string tekst, char znak)
        {
            return tekst.Count(x => x.Equals(znak));
        }

        public static int ZliczZnaki(this string tekst, string znak)
        {
            if (znak.Length>1)
            {
                Console.WriteLine("nie da sie");
            }

            return  ZliczZnaki(tekst, znak[0]);
        }

        public static int SumaGrupWiekowych(this Reklama.GrupaWiekowa grupa)
        {
            int suma = 0;
            foreach (var item in Enum.GetValues(typeof(Reklama.GrupaWiekowa)))
            {
                suma += (int)item;
            }

            return suma;
        }

        //public static int ZliczZnaki(string tekst, char znak)
        //{
        //    int iloscZnakow = 0;
        //    foreach (var elem in tekst)
        //    {
        //        if (elem == znak)
        //        {
        //            iloscZnakow += 1;
        //        }
        //        else
        //        {
        //            continue;
        //        }
        //    }

        //    return iloscZnakow;
        //}
    }



}
