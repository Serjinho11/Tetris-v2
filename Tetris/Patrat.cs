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
        //coordonatele fiecarei celule



        public Patrat()
        {
            x1 = 4; y1 = 0;//prima celula din patrat                ex: y 
            x2 = 4; y2 = 1;//a 2a celula din patrat               x     1 2
            x3 = 5; y3 = 0;//a 3a celula din patrat                     3 4
            x4 = 5; y4 = 1;//a 4a celula din patrat
        }

    }
}

