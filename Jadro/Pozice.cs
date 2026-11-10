using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HraTetris.Jadro
{
    public class Pozice
    {
        public int Radek { get; set; }
        public int Sloupec { get; set; }

        public Pozice(int radek, int sloupec)
        {
            Radek = radek;
            Sloupec = sloupec;
        }
    }
}
