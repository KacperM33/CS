using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6zad
{
    public interface IPostac
    {
        String Imie { get; }
        double PunktyZycia { get; set; }
        double MocAtaku();
        string ToString();
    }
}
