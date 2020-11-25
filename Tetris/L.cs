using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    class L:Piesa
    {
        //coordonatele fiecarei celule
        public int x1 = 5, y1 = 0;//prima celula din patrat                ex:   1
        public int x2 = 5, y2 = 1;//a 2a celula din patrat                       2
        public int x3 = 5, y3 = 2;//a 3a celula din patrat                       3 4
        public int x4 = 6, y4 = 2;//a 4a celula din patrat                       

        public L()
        {
            this.NumePiesa = "L";
            this.Culoare = "Rosu";
        }


        public override void pozInit(Game game)
        {
            /*---------------------------------------------------------------------------
             DESCRIPTION: - va desena linia in pozitia initiala
            ---------------------------------------------------------------------------*/
            game.tableLayoutPanel1.GetControlFromPosition(x1, y1).BackColor = Color.Red;
            game.tableLayoutPanel1.GetControlFromPosition(x2, y2).BackColor = Color.Red;
            game.tableLayoutPanel1.GetControlFromPosition(x3, y3).BackColor = Color.Red;
            game.tableLayoutPanel1.GetControlFromPosition(x4, y4).BackColor = Color.Red;

        }

        public override void mutaJos(Game game)
        {

            //stergerea patratului din cercul curent
            game.tableLayoutPanel1.GetControlFromPosition(x1, y1).BackColor = Color.Blue;
            game.tableLayoutPanel1.GetControlFromPosition(x2, y2).BackColor = Color.Blue;
            game.tableLayoutPanel1.GetControlFromPosition(x3, y3).BackColor = Color.Blue;
            game.tableLayoutPanel1.GetControlFromPosition(x4, y4).BackColor = Color.Blue;

            //mutam cu un rand mai jos
            y1++; y2++; y3++; y4++;

            //redesenarea cu un rand mai jos
            game.tableLayoutPanel1.GetControlFromPosition(x1, y1).BackColor = Color.Red;
            game.tableLayoutPanel1.GetControlFromPosition(x2, y2).BackColor = Color.Red;
            game.tableLayoutPanel1.GetControlFromPosition(x3, y3).BackColor = Color.Red;
            game.tableLayoutPanel1.GetControlFromPosition(x4, y4).BackColor = Color.Red;
        }
    }
}
