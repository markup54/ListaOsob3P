using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaOsob3P
{
    public class Osoba : ICloneable
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Telefon { get; set; }

        public Osoba(string imie, string nazwisko, string telefon)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            Telefon = telefon;
        }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
