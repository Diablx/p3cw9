using System;

namespace lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //int liczba = Convert.ToInt32(Console.ReadLine());
            //int wynik, reszta;

            //string twojCiag = Console.ReadLine();

            //char twojParam = Convert.ToChar(Console.Read());

            //Console.WriteLine(  ); ExtensionMethods.ZliczZnaki(twojCiag,twojParam);

            //(wynik,reszta) = liczba.DzielenieZreszta(3);
            //Console.WriteLine($"{liczba}/3 = {wynik} reszty: {reszta}");

            //var reklama = new Reklama("Kup teraz", Reklama.GrupaWiekowa.Dorośli | Reklama.GrupaWiekowa.Młodzież, Reklama.Zainteresowania.Gaming);

            //for (int i = 0; i < 16; i++)
            //{
            //    Console.WriteLine(Reklama.GrupaWiekowa);
            //}

            for (int i = 0; i <= Reklama.GrupaWiekowa.Brak.SumaGrupWiekowych(); i++)
            {
                Console.WriteLine((Reklama.GrupaWiekowa)i);
            }
                       
            //Console.WriteLine(reklama);
        }
    }
}
