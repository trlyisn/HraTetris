using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HraTetris.Jadro
{
    public class GameBoard
    {
        // herni pole 20 x 10; TODO: pokud vse pujde mooozna 16 radku
        public const int Radky = 20;
        public const int Sloupce = 10;

        private readonly int[,] grid;

        // r = rows/radky c = columns/sloupce; TODO: kdyztak renamenout
        public int this[int r, int c]
        {
            get => grid[r, c];
            set => grid[r, c] = value;
        }

        public GameBoard()
        {
            grid = new int[Radky, Sloupce];
        }

        // jsou dane souradnice na gameboarde ci mimo
        public bool JeNaDesce(int radek, int sloupec)
        {
            return radek >= 0 && radek < Radky && sloupec >= 0 && sloupec < Sloupce;
        }

        // je dane pole prazdne?
        public bool JePrazdne(int radek, int sloupec)
        {
            return JeNaDesce(radek, sloupec) && grid[radek, sloupec] == 0;
        }

        // vleze se?
        public bool Fits(Tetromino blok)
        {
            foreach (Pozice p in blok.AktualniPozice())
            {
                // pokud cast bloku narazi do jineho bloku ci mimo playfield
                if (!JePrazdne(p.Radek, p.Sloupec))
                {
                    return false;
                }
            }
            return true;
        }

        // polozit blok na desku
        public void PolozBlok(Tetromino blok)
        {
            foreach (Pozice p in blok.AktualniPozice())
            {
                if (JeNaDesce(p.Radek, p.Sloupec))
                {
                    grid[p.Radek, p.Sloupec] = blok.id;
                }
            }
        }

        // nuke everything into oblivion 
        public void Reset()
        {
            for (int r = 0; r < Radky; r++)
            {
                for (int c = 0; c < Sloupce; c++)
                {
                    grid[r, c] = 0;
                }
            }
        }

        // kontroluje zda li je radek plny
        private bool JeRadekPlny(int radek)
        {
            for (int sloupec = 0; sloupec < Sloupce; sloupec++)
            {
                if (grid[radek, sloupec] == 0)
                {
                    return false;
                }
            }
            return true;
        }

        // vymazani radku
        private void VymazatRadek(int radek)
        {
            for (int sloupec = 0; sloupec < Sloupce; sloupec++)
            {
                grid[radek, sloupec] = 0;
            }
        }

        // vse nad prazdnym radkem -1 dolu
        private void PosunoutRadek(int prazdnyRadek)
        {
            for (int r = prazdnyRadek; r > 0; r--)
            {
                for (int c = 0; c < Sloupce; c++)
                {
                    grid[r, c] = grid[r - 1, c];
                }
            }

            for (int c = 0; c < Sloupce; c++)
            {
                grid[0, c] = 0;
            }
        }

        // zkompletovani fuknce na mazani plnych radku
        public int VymazatRadky()
        {
            int pocet = 0;
            for (int r = Radky - 1; r >= 0; r--)
            {
                if (JeRadekPlny(r))
                {
                    VymazatRadek(r);
                    PosunoutRadek(r);
                    pocet++;
                    r++;
                }
            }

            return pocet;
        }

        /*
        TODO
        kontrovat souradnice [x]
        prazdnota pole [x]
        pokud ma tetromino misto [x]
        zapisovani samotnych tetromin [x]
        kontrola radku [x]
        vymazani plneho radku [x]
        posunuti vseho -1 [x]
        reset cele hry [x]
         */

    }
}
