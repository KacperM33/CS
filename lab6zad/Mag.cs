using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6zad
{
    public class Mag : IPostac
    {
        private int _sila;
        private int _punkty_magii;
        public String Imie { get; private set; }
        public double PunktyZycia { get; set; }

        public Mag(String imie, double punktyZycia, int sila, int punkty_magii) 
        { 
            Imie =  imie;
            PunktyZycia= punktyZycia;
            _sila= sila;
            _punkty_magii= punkty_magii;
        }

        public Mag() 
        {
            Random rand = new Random();
            Imie = "Xardas";
            PunktyZycia = 100;
            _sila = rand.Next(6) + 1;
            //dwa rzuty kostką
            _punkty_magii = rand.Next(6) + 1;
            _punkty_magii += rand.Next(6) + 1;
        }

        public double ZmienZywotnosc(double zmiana)
        {
            PunktyZycia += zmiana;
            if (PunktyZycia < 0)
            {
                PunktyZycia = 0;
                return PunktyZycia;
            }
            else if(PunktyZycia > 100)
            {
                PunktyZycia = 100;
                return PunktyZycia;
            }
            else
                return PunktyZycia;
        }
        public double MocAtaku()
        {
            return (_punkty_magii + _sila) * PunktyZycia;
        }

        override
        public string ToString()
        {
            return "Mag: " + Imie + "\tHP: " + PunktyZycia +"%" + "\tMoc Ataku: " + MocAtaku();
        }
    }
}
