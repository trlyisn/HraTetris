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

        /*
        TODO
        kontrovat souradnice []
        prazdnota pole []
        pokud ma tetromino misto []
        zapisovani samotnych tetromin []
        kontrola radku []
        vymazani plneho radku []
        posunuti vseho -1 []
        reset cele hry []
         */

    }
}
