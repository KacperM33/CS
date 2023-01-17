using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6zad
{
    public class Wojownik : IPostac
    {
        private int _sila;
        public String Imie { get; private set; }
        public double PunktyZycia { get; set; }
        public Wojownik(String imie, double punktyZycia, int sila)
        {
            Imie= imie;
            PunktyZycia= punktyZycia;
            _sila= sila;
        }
        public Wojownik()
        {
            Random rand = new Random();
            Imie = "Geralt";
            PunktyZycia = 100;
            //trzy rzuty kostką
            _sila = rand.Next(6) + 1;
            _sila += rand.Next(6) + 1;
            _sila += rand.Next(6) + 1;
        }

        public double ZmienZywotnosc(double zmiana)
        {
            PunktyZycia += zmiana;
            if (PunktyZycia > 100)
            {
                PunktyZycia = 100;
                return PunktyZycia;
            }
            else if (PunktyZycia < 0)
            {
                PunktyZycia = 0;
                return PunktyZycia;
            }
            else
                return PunktyZycia;
        }

        public double MocAtaku()
        {
            if (PunktyZycia < 5)
                return _sila*100;
            else
                return _sila * PunktyZycia;
        }
        override
        public string ToString()
        {
            return "Imie: " + Imie + "\tHP: " + PunktyZycia + "%\tMoc Ataku: " + MocAtaku();
        }
    }
}
