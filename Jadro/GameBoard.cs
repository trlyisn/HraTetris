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

        /*
        TODO
        kontrovat souradnice [x]
        prazdnota pole [x]
        pokud ma tetromino misto []
        zapisovani samotnych tetromin []
        kontrola radku []
        vymazani plneho radku []
        posunuti vseho -1 []
        reset cele hry []
         */

    }
}
