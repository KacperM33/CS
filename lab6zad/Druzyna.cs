using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6zad
{
    public class Druzyna
    {
        private string nazwa;
        private List<IPostac> _lista;
        public Druzyna(string _nazwa)
        {
            nazwa= _nazwa;
            _lista= new List<IPostac>();
        }
        public Druzyna(string _nazwa, IEnumerable<IPostac> postacie)
        {
            nazwa = _nazwa;
            _lista = new List<IPostac>(postacie);
        }

        public void DodajPostac(IPostac postac)
        {
            if(postac == null)
                throw new ArgumentNullException("Brak postaci!!");
            _lista.Add(postac);
        }
        public IPostac this[int index]
        {
            get 
            {
                if (index < 0 || index >= _lista.Count)
                    throw new IndexOutOfRangeException();
                return _lista[index];
            }
        }

        public double SumaAtaku()
        {
            double moc = 0;
            foreach(var postac in _lista)
            {
                moc += postac.MocAtaku();
            }
            return moc;
        }
        override
        public string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Drużyna: " + nazwa);
            sb.AppendLine("Suma Ataku: "+SumaAtaku());
            foreach(IPostac postac in _lista)
            {
                sb.AppendLine(postac.ToString());
            }
            return sb.ToString();
        }

    }
}
