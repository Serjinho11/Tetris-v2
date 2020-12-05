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
            x1 = 5; y1 = 2;//prima celula din patrat                ex:   4
            x2 = 6; y2 = 2;//a 2a celula din patrat                     1 2 3 
            x3 = 7; y3 = 2;//a 3a celula din patrat                     
            x4 = 6; y4 = 1;//a 4a celula din patrat
        }
    }
}
