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
            x1 = 5; y1 = 0;//prima celula din patrat                ex: 1
            x2 = 5; y2 = 1;//a 2a celula din patrat                     2
            x3 = 5; y3 = 2;//a 3a celula din patrat                     3 4
            x4 = 6; y4 = 2;//a 4a celula din patrat
        }
    }
}
