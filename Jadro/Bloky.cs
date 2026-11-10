using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HraTetris.Jadro
{
    // ID 1 - Blok Line Piece - svetle modra
    public class BlokI : Tetromino
    {
        public override int id => 1;
        protected override Pozice StartovOffset => new Pozice(-1, 3);

        protected override Pozice[][] Bloky => new Pozice[][]
        {
            new Pozice[] { new Pozice(1, 0), new Pozice(1, 1), new Pozice(1, 2), new Pozice(1, 3) },
            new Pozice[] { new Pozice(0, 1), new Pozice(1, 1), new Pozice(1, 2), new Pozice(2, 3) },
            new Pozice[] { new Pozice(1, 1), new Pozice(1, 2), new Pozice(2, 0), new Pozice(2, 1) },
            new Pozice[] { new Pozice(0, 0), new Pozice(1, 0), new Pozice(1, 1), new Pozice(2, 1) }
        };
    }

    // ID 2 - Blok Square Piece - svetle zluta
    public class Blok0 : Tetromino
    {
        public override int id => 2;
        protected override Pozice StartovOffset => new Pozice(0, 4);

        protected override Pozice[][] Bloky => new Pozice[][]
        {
            new Pozice[] { new Pozice(0, 0), new Pozice(0, 1), new Pozice(1, 0), new Pozice(1, 1) }
        };
    }

    // ID 3 - Blok T - fialova
    public class BlokT : Tetromino
    {
        public override int id => 3;
        protected override Pozice StartovOffset => new Pozice(0, 3);

        protected override Pozice[][] Bloky => new Pozice[][]
        {
            new Pozice[] { new Pozice(0, 1), new Pozice(1, 0), new Pozice(1, 1), new Pozice(1, 2) },
            new Pozice[] { new Pozice(0, 1), new Pozice(1, 1), new Pozice(1, 2), new Pozice(2, 1) },
            new Pozice[] { new Pozice(1, 0), new Pozice(1, 1), new Pozice(1, 2), new Pozice(2, 1) },
            new Pozice[] { new Pozice(0, 1), new Pozice(1, 0), new Pozice(1, 1), new Pozice(2, 1) }
        };
    }

    // ID 4 - Blok J - modra
    public class BlokJ : Tetromino
    {
        public override int id => 4;
        protected override Pozice StartovOffset => new Pozice(0, 3);

        protected override Pozice[][] Bloky => new Pozice[][]
        {
            new Pozice[] { new Pozice(0, 0), new Pozice(1, 0), new Pozice(1, 1), new Pozice(1, 2) },
            new Pozice[] { new Pozice(0, 1), new Pozice(0, 2), new Pozice(1, 1), new Pozice(2, 1) },
            new Pozice[] { new Pozice(1, 0), new Pozice(1, 1), new Pozice(1, 2), new Pozice(2, 2) },
            new Pozice[] { new Pozice(0, 1), new Pozice(1, 1), new Pozice(2, 0), new Pozice(2, 1) }
        };
    }

    // ID 5 - Blok L - oranzova
    public class BlokL : Tetromino
    {
        public override int id => 5;
        protected override Pozice StartovOffset => new Pozice(0, 3);

        protected override Pozice[][] Bloky => new Pozice[][]
        {
            new Pozice[] { new Pozice(0, 2), new Pozice(1, 0), new Pozice(1, 1), new Pozice(1, 2) },
            new Pozice[] { new Pozice(0, 1), new Pozice(1, 1), new Pozice(2, 1), new Pozice(2, 2) },
            new Pozice[] { new Pozice(1, 0), new Pozice(1, 1), new Pozice(1, 2), new Pozice(2, 0) },
            new Pozice[] { new Pozice(0, 0), new Pozice(0, 1), new Pozice(1, 1), new Pozice(2, 1) }
        };
    }

    // ID 6 - Blok S - zelena
    public class BlokS : Tetromino
    {
        public override int id => 6;
        protected override Pozice StartovOffset => new Pozice(0, 3);

        protected override Pozice[][] Bloky => new Pozice[][]
        {
            new Pozice[] { new Pozice(0, 1), new Pozice(0, 2), new Pozice(1, 0), new Pozice(1, 1) },
            new Pozice[] { new Pozice(0, 1), new Pozice(1, 1), new Pozice(1, 2), new Pozice(2, 2) },
            new Pozice[] { new Pozice(1, 1), new Pozice(1, 2), new Pozice(2, 0), new Pozice(2, 1) },
            new Pozice[] { new Pozice(0, 0), new Pozice(1, 0), new Pozice(1, 1), new Pozice(2, 1) }
        };
    }

    // ID 7 - Blok Z - cervena
    public class BlokZ : Tetromino
    {
        public override int id => 7;
        protected override Pozice StartovOffset => new Pozice(0, 3);

        protected override Pozice[][] Bloky => new Pozice[][]
        {
            new Pozice[] { new Pozice(0, 0), new Pozice(0, 1), new Pozice(1, 1), new Pozice(1, 2) },
            new Pozice[] { new Pozice(0, 2), new Pozice(1, 1), new Pozice(1, 2), new Pozice(2, 1) },
            new Pozice[] { new Pozice(1, 0), new Pozice(1, 1), new Pozice(2, 1), new Pozice(2, 2) },
            new Pozice[] { new Pozice(0, 1), new Pozice(1, 0), new Pozice(1, 1), new Pozice(2, 0) }
        };
    }
}
