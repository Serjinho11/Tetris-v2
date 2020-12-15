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
        bool gameOver = false;

        int removed = 0;
        int[] x = new int[20];
        int[] y = new int[20];
        public void DrawTableBorder(Game game)
        {
            /*---------------------------------------------------------------------------
                 DESCRIPTION: - va desena conturul tabei de joc.
            ---------------------------------------------------------------------------*/
            //pt partea de jos si sus:
            for (int i = 0; i < 12; i++)
            {
                game.matrice[i, 21] = 1;
                game.tableLayoutPanel1.GetControlFromPosition(i, 21).BackColor = Color.FromArgb(20, 20, 20);
                game.matrice[i, 0] = 1;
                game.tableLayoutPanel1.GetControlFromPosition(i, 0).BackColor = Color.FromArgb(20, 20, 20);

            }


            // pt partea din stanga si dreapta
            for (int i = 0; i < 21; i++)
            {
                game.matrice[0, i] = 1;
                game.tableLayoutPanel1.GetControlFromPosition(0, i).BackColor = Color.FromArgb(20, 20, 20);

                game.matrice[11, i] = 1;
                game.tableLayoutPanel1.GetControlFromPosition(11, i).BackColor = Color.FromArgb(20, 20, 20);


            }
        }

        public void StergeLinieDacaECompleta(Game game, Piesa piesa)
        {

            for (int i = 1; i < game.matrice.GetLength(0) - 1; i++)
            {
                for (int j = 1; j < game.matrice.GetLength(1) - 1; j++)
                {

                    if (
                    game.matrice[1, j] == 1 &&
                    game.matrice[2, j] == 1 &&
                    game.matrice[3, j] == 1 &&
                    game.matrice[4, j] == 1 &&
                    game.matrice[5, j] == 1 &&
                    game.matrice[6, j] == 1 &&
                    game.matrice[7, j] == 1 &&
                    game.matrice[8, j] == 1 &&
                    game.matrice[9, j] == 1 &&
                    game.matrice[10, j] == 1
                    )
                    {
                        game.matrice[1, j] = 0;
                        game.matrice[2, j] = 0;
                        game.matrice[3, j] = 0;
                        game.matrice[4, j] = 0;
                        game.matrice[5, j] = 0;
                        game.matrice[6, j] = 0;
                        game.matrice[7, j] = 0;
                        game.matrice[8, j] = 0;
                        game.matrice[9, j] = 0;
                        game.matrice[10, j] = 0;

                        MutaPieseleInJoS(j, game);

                        game.GenerarePiesaRandom();

                        removed++;

                        game.scor += 45;

                    }
                }
            }

        }


        public void MutaPieseleInJoS(int k, Game game)
        {
            /*
            for (int i = 1; i < game.matrice.GetLength(0) - 1; i++)
            {
                for (int j = 1; j < k; j++)
                {
                    if (game.matrice[i, j] == 1)
                    {
                        game.matrice[i, j] = 0;
                        game.matrice[i, j+1] = game.matrice[i, j];
                        //game.matrice[i, j++] = 1;

                    }

                }
            }
            */

            for (int i = game.matrice.GetLength(0) - 1; i >= 1; i--)
            {
                for (int j = k; j > 1; j--)
                {
                    if ((j - 1) < 0)
                    {
                        game.matrice[i, j] = 0;
                    }
                    else
                    {
                        game.matrice[i, j] = game.matrice[i, j - 1];
                    }
                }
            }

            /*
                        for(int j= game.matrice.GetLength(1) - 1; j >=k; j--)
                        {
                            for(int i = 1; i < game.matrice.GetLength(0)-1; i++)
                            {
                                game.matrice[i, j] = game.matrice[i, j - 1];
                            }
                        }

                        for (int i = 1; i < game.matrice.GetLength(0) - 1; i++)
                        {
                            game.matrice[i, 0] = 0;

                        }
            */


        }

        public bool GameOver(Game game)
        {

            for (int i = 1; i < game.matrice.GetLength(0) - 1; i++)
            {
                for (int j = 1; j < game.matrice.GetLength(1) - 1; j++)
                {

                    if (
                    game.matrice[i, 1] == 1 &&
                    game.matrice[i, 2] == 1 &&
                    game.matrice[i, 3] == 1 &&
                    game.matrice[i, 4] == 1
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
                        gameOver = true;
                    }
                }
            }

            return gameOver;
        }



    }
}
