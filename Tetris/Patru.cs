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
            x1 = 5; y1 = 1;//prima celula din patru                ex:   1
            x2 = 5; y2 = 2;//a 2a celula din patru                       2 3
            x3 = 6; y3 = 2;//a 3a celula din patru                         4
            x4 = 6; y4 = 3;//a 4a celula din patru  
        }


    }
}
