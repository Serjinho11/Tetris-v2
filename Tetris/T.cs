using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    class T : Piesa
    {
        public T()
        {
            x1 = 4; y1 = 1;//prima celula din patrat                ex:   4
            x2 = 5; y2 = 1;//a 2a celula din patrat                     1 2 3 
            x3 = 6; y3 = 1;//a 3a celula din patrat                     
            x4 = 5; y4 = 0;//a 4a celula din patrat
        }
    }
}
