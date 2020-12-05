using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tetris
{
    class Piesa
    {

        protected int x1, y1;
        protected int x2, y2;
        protected int x3, y3;
        protected int x4, y4;


        public void pozInit(Game game)
        {
            /*---------------------------------------------------------------------------
             DESCRIPTION: - va pune in matrice la coordonatelei piesei valoarea 1, iar apoi va cauta
                            in matrice unde este valoarea 1, si o va colora
                          - pe scurt, va desena piesa in pozitia initiala
            ---------------------------------------------------------------------------*/


            game.matrice[x1, y1] = 1;
            game.matrice[x2, y2] = 1;
            game.matrice[x3, y3] = 1;
            game.matrice[x4, y4] = 1;

            for (int i = 1; i < game.matrice.GetLength(0) - 1; i++)
            {
                for (int j = 1; j < game.matrice.GetLength(1) - 1; j++)
                {
                    if (game.matrice[i, j] == 1)
                        game.tableLayoutPanel1.GetControlFromPosition(i, j).BackColor = Color.Red;
                }
            }

        }


        public void mutaJos(Game game)
        {

            //stergerea cubului curent(adica il coloram cu albastru)

            game.matrice[x1, y1] = 0;
            game.matrice[x2, y2] = 0;
            game.matrice[x3, y3] = 0;
            game.matrice[x4, y4] = 0;

            if (verificaUrmPozitieJos(game))
            {
                //cauta in matrice unde e 0 si coloreaza albastru
                for (int i = 1; i < game.matrice.GetLength(0) - 1; i++)
                {
                    for (int j = 1; j < game.matrice.GetLength(1) - 1; j++)
                    {
                        if (game.matrice[i, j] == 0)
                            game.tableLayoutPanel1.GetControlFromPosition(i, j).BackColor = Color.Blue;
                    }
                }

                //mutam cu un rand mai jos
                y1++; y2++; y3++; y4++;

                // si coloram pe urmatoarea pozitie
                game.matrice[x1, y1] = 1;
                game.matrice[x2, y2] = 1;
                game.matrice[x3, y3] = 1;
                game.matrice[x4, y4] = 1;

                for (int i = 1; i < game.matrice.GetLength(0) - 1; i++)
                {
                    for (int j = 1; j < game.matrice.GetLength(1) - 1; j++)
                    {
                        if (game.matrice[i, j] == 1)
                            game.tableLayoutPanel1.GetControlFromPosition(i, j).BackColor = Color.Red;
                    }
                }



            }
            else
            {
                game.timer1.Stop();

                game.generarePiesaRandom();

                pozInit(game);

                game.timer1.Start();

            }
        }


        public void mutaDreapta(Game game)
        {

            //stergerea cubului curent(adica il coloram cu albastru)
            game.matrice[x1, y1] = 0;
            game.matrice[x2, y2] = 0;
            game.matrice[x3, y3] = 0;
            game.matrice[x4, y4] = 0;

            for (int i = 1; i < game.matrice.GetLength(0) - 1; i++)
            {
                for (int j = 1; j < game.matrice.GetLength(1) - 1; j++)
                {
                    if (game.matrice[i, j] == 0)
                        game.tableLayoutPanel1.GetControlFromPosition(i, j).BackColor = Color.Blue;
                }
            }

            //mutam cu un rand mai jos
            x1++; x2++; x3++; x4++;

            // si coloram pe urmatoarea pozitie
            game.matrice[x1, y1] = 1;
            game.matrice[x2, y2] = 1;
            game.matrice[x3, y3] = 1;
            game.matrice[x4, y4] = 1;

            for (int i = 1; i < game.matrice.GetLength(0) - 1; i++)
            {
                for (int j = 1; j < game.matrice.GetLength(1) - 1; j++)
                {
                    if (game.matrice[i, j] == 1)
                        game.tableLayoutPanel1.GetControlFromPosition(i, j).BackColor = Color.Red;
                }
            }
        }


        public void mutaStanga(Game game)
        {
            game.matrice[x1, y1] = 0;
            game.matrice[x2, y2] = 0;
            game.matrice[x3, y3] = 0;
            game.matrice[x4, y4] = 0;

            for (int i = 1; i < game.matrice.GetLength(0) - 1; i++)
            {
                for (int j = 1; j < game.matrice.GetLength(1) - 1; j++)
                {
                    if (game.matrice[i, j] == 0)
                        game.tableLayoutPanel1.GetControlFromPosition(i, j).BackColor = Color.Blue;
                }
            }

            //mutam cu un rand mai jos
            x1--; x2--; x3--; x4--;

            // si coloram pe urmatoarea pozitie
            game.matrice[x1, y1] = 1;
            game.matrice[x2, y2] = 1;
            game.matrice[x3, y3] = 1;
            game.matrice[x4, y4] = 1;

            for (int i = 1; i < game.matrice.GetLength(0) - 1; i++)
            {
                for (int j = 1; j < game.matrice.GetLength(1) - 1; j++)
                {
                    if (game.matrice[i, j] == 1)
                        game.tableLayoutPanel1.GetControlFromPosition(i, j).BackColor = Color.Red;
                }
            }
        }


        public bool verificaUrmPozitieJos(Game game)
        {
            bool eLiber = false;

            if (game.matrice[x1, y1 + 1] == 0 &&
                game.matrice[x2, y2 + 1] == 0 &&
                game.matrice[x3, y3 + 1] == 0 &&
                game.matrice[x4, y4 + 1] == 0)
            {
                eLiber = true;
            }


            return eLiber;
        }

        public void urmPiesa(Game game) { }

    }

}

