using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    class Patru : Piesa
    {

        public Patru()
        {
            x1 = 4; y1 = 0;//prima celula din patru                ex:   1
            x2 = 4; y2 = 1;//a 2a celula din patru                       2 3
            x3 = 5; y3 = 1;//a 3a celula din patru                         4
            x4 = 5; y4 = 2;//a 4a celula din patru  
        }


    }
}
