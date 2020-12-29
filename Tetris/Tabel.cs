using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    class Tabel
    {

        #region Variabile
        private bool vT_gameOver = false;

        private int vT_removed = 0;

        #endregion


        #region Metode
        public void fT_DrawTableBorder(Game game)
        {
            /*---------------------------------------------------------------------------
                 DESCRIPTION: - va desena conturul tablei de joc.Ne trebuie contur pentru ca
                                piesele sa abia de ce sa se opreasca.

            ---------------------------------------------------------------------------*/

            //pt partea de jos si sus:
            for (int i = 0; i < 12; i++)
            {
                game.pG_Matrice[i, 21] = 1;
                game.tableLayoutPanel1.GetControlFromPosition(i, 21).BackColor = Color.FromArgb(20, 20, 20);
                game.pG_Matrice[i, 0] = 1;
                game.tableLayoutPanel1.GetControlFromPosition(i, 0).BackColor = Color.FromArgb(20, 20, 20);

            }


            // pt partea din stanga si dreapta
            for (int i = 0; i < 21; i++)
            {
                game.pG_Matrice[0, i] = 1;
                game.tableLayoutPanel1.GetControlFromPosition(0, i).BackColor = Color.FromArgb(20, 20, 20);

                game.pG_Matrice[11, i] = 1;
                game.tableLayoutPanel1.GetControlFromPosition(11, i).BackColor = Color.FromArgb(20, 20, 20);


            }
        }

        public void fT_StergeLinieDacaECompleta(Game game, Piesa piesa)
        {
            /*---------------------------------------------------------------------------
                 DESCRIPTION: - va parcurge matricea, iar daca gaseste pe o linie intreaga numai
                                valori de 1, atunci va pune 0 pe intreaga linie, si va muta
                                tot ce se afla desupra liniei sterse, cu o pozitie mai jos.

            ---------------------------------------------------------------------------*/
            for (int i = 1; i < game.pG_Matrice.GetLength(0) - 1; i++)
            {
                for (int j = 1; j < game.pG_Matrice.GetLength(1) - 1; j++)
                {

                    if (
                    game.pG_Matrice[1, j] == 1 &&
                    game.pG_Matrice[2, j] == 1 &&
                    game.pG_Matrice[3, j] == 1 &&
                    game.pG_Matrice[4, j] == 1 &&
                    game.pG_Matrice[5, j] == 1 &&
                    game.pG_Matrice[6, j] == 1 &&
                    game.pG_Matrice[7, j] == 1 &&
                    game.pG_Matrice[8, j] == 1 &&
                    game.pG_Matrice[9, j] == 1 &&
                    game.pG_Matrice[10, j] == 1
                    )
                    {
                        game.pG_Matrice[1, j] = 0;
                        game.pG_Matrice[2, j] = 0;
                        game.pG_Matrice[3, j] = 0;
                        game.pG_Matrice[4, j] = 0;
                        game.pG_Matrice[5, j] = 0;
                        game.pG_Matrice[6, j] = 0;
                        game.pG_Matrice[7, j] = 0;
                        game.pG_Matrice[8, j] = 0;
                        game.pG_Matrice[9, j] = 0;
                        game.pG_Matrice[10, j] = 0;

                        fT_MutaPieseleInJoS(j, game);

                        game.fG_GenerarePiesaRandom();

                        vT_removed++;

                        game.pG_Scor += 45;

                    }
                }
            }

        }


        public void fT_MutaPieseleInJoS(int k, Game game)
        {
            /*---------------------------------------------------------------------------
                 DESCRIPTION: - va parcurge matricea pana la linia <k>, si va muta tot cu o 
                                pozitie mai jos.

            ---------------------------------------------------------------------------*/

            for (int i = game.pG_Matrice.GetLength(0) - 1; i >= 1; i--)
            {
                for (int j = k; j > 1; j--)
                {
                    if ((j - 1) < 0)
                    {
                        game.pG_Matrice[i, j] = 0;
                    }
                    else
                    {
                        game.pG_Matrice[i, j] = game.pG_Matrice[i, j - 1];
                    }
                }
            }



        }

        public bool fT_GameOver(Game game)
        {

            for (int i = 1; i < game.pG_Matrice.GetLength(0) - 1; i++)
            {
                for (int j = 1; j < game.pG_Matrice.GetLength(1) - 1; j++)
                {

                    if (
                    game.pG_Matrice[i, 1] == 1 &&
                    game.pG_Matrice[i, 2] == 1 &&
                    game.pG_Matrice[i, 3] == 1 &&
                    game.pG_Matrice[i, 4] == 1
                    /*
                    game.matrice[i, 5] == 1 &&
                    game.matrice[i, 6] == 1 &&
                    game.matrice[i, 7] == 1 &&
                    game.matrice[i, 8] == 1 &&
                    game.matrice[i, 9] == 1 &&
                    game.matrice[i, 10] == 1 &&
                    game.matrice[i, 11] == 1 &&
                    game.matrice[i, 12] == 1 &&
                    game.matrice[i, 13] == 1 &&
                    game.matrice[i, 14] == 1 &&
                    game.matrice[i, 15] == 1 &&
                    game.matrice[i, 16] == 1 &&
                    game.matrice[i, 17] == 1 &&
                    game.matrice[i, 18] == 1 &&
                    game.matrice[i, 19] == 1 &&
                    game.matrice[i, 20] == 1
                    */
                    )
                    {
                        vT_gameOver = true;
                    }
                }
            }

            return vT_gameOver;
        }

        #endregion


    }
}
