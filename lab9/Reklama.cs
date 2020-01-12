using System;
using System.Collections.Generic;
using System.Text;

namespace lab9
{
    public class Reklama
    {
        public string tekst;
        public GrupaWiekowa grupaWiekowa;
        public Zainteresowania zainteresowania;

        public Reklama(string tekst, GrupaWiekowa grupaWiekowa, Zainteresowania zainteresowania)
        {
            this.tekst = tekst;
            this.grupaWiekowa = grupaWiekowa;
            this.zainteresowania = zainteresowania;
        }
        [Flags]
        public enum GrupaWiekowa
        {
            Brak = 0,     //0000
            Dzieci = 1,   //0001
            Młodzież = 2, //0010
            Dorośli = 4,  //0100
            Starsi = 8    //1000
        }

        public enum Zainteresowania
        {
            Gaming,
            Elektronika,
        }
    }
}
