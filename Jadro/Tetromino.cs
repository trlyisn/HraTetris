using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;   

namespace HraTetris.Jadro
{
    public abstract class Tetromino
    {
        // 4 moznosti rotace => kazda varianta zabere 4 "bloky"
        protected abstract Pozice[][] Bloky { get; }

        // zakladni offset pri padu tetromina
        protected abstract Pozice StartovOffset { get; }

        // ciselny identifikátor pro rozliseni tetromin a barev v mrizce (1-7)
        public abstract int id { get; }

        private int stavRotace;
        private Pozice offset;

        protected Tetromino()
        {
            offset = new Pozice(StartovOffset.Radek, StartovOffset.Sloupec);
        }

        // vraci aktualni pozici bloku na hracim poli
        public IEnumerable<Pozice> AktualniPozice()
        {
            foreach (Pozice pos in Bloky[stavRotace])
            {
                yield return new Pozice(pos.Radek + offset.Radek, pos.Sloupec + offset.Sloupec);
            }
        }

        public void RotacePo()
        {
            stavRotace = (stavRotace + 1) % Bloky.Length;
        }

        public void RotaceProti()
        {
            if (stavRotace == 0)
            {
                stavRotace = Bloky.Length - 1;
            }
            else
            {
                stavRotace--;
            }
        }

        public void Move(int radky, int sloupce)
        {
            offset.Radek += radky;
            offset.Sloupec += sloupce;
        }

        public void Reset()
        {
            stavRotace = 0;
            offset.Radek = StartovOffset.Radek;
            offset.Sloupec = StartovOffset.Sloupec;
        }
    }
}
