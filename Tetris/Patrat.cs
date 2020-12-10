using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tetris
{
    class Patrat : Piesa
    {

        public Patrat()
        {
            x1 = 5; y1 = 1;//prima celula din patrat                ex: y 
            x2 = 5; y2 = 2;//a 2a celula din patrat               x     1 2
            x3 = 6; y3 = 1;//a 3a celula din patrat                     3 4
            x4 = 6; y4 = 2;//a 4a celula din patrat
        }



    }
}

