using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    class Linie : Piesa
    {
        //coordonatele fiecarei celule
        /*
        
        */
        public Linie()
        {
            x1 = 3; y1 = 0;//prima celula din patrat                ex:
            x2 = 4; y2 = 0;//a 2a celula din patrat                     1 2 3 4 
            x3 = 5; y3 = 0;//a 3a celula din patrat                     
            x4 = 6; y4 = 0;//a 4a celula din patrat
        }
    }
}
