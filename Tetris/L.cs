using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    class L : Piesa
    {
        public L()
        {
            x1 = 6; y1 = 1;//prima celula din patrat                ex: 1
            x2 = 6; y2 = 2;//a 2a celula din patrat                     2
            x3 = 6; y3 = 3;//a 3a celula din patrat                     3 4
            x4 = 7; y4 = 3;//a 4a celula din patrat
        }
    }
}
