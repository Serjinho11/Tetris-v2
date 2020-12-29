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
            pP_X1 = 5; pP_Y1 = 1;//prima celula din patrat                ex: y 
            pP_X2 = 5; pP_Y2 = 2;//a 2a celula din patrat               x     1 2
            pP_X3 = 6; pP_Y3 = 1;//a 3a celula din patrat                     3 4
            pP_X4 = 6; pP_Y4 = 2;//a 4a celula din patrat
        }



    }
}

