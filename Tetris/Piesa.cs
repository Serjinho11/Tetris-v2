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


        #region Variabile si Proprietati

        private int vP_x1, vP_y1;
        private int vP_x2, vP_y2;
        private int vP_x3, vP_y3;
        private int vP_x4, vP_y4;

        public int pP_X1 { get => vP_x1; set => vP_x1 = value; }
        public int pP_Y1 { get => vP_y1; set => vP_y1 = value; }
        public int pP_X2 { get => vP_x2; set => vP_x2 = value; }
        public int pP_Y2 { get => vP_y2; set => vP_y2 = value; }
        public int pP_X3 { get => vP_x3; set => vP_x3 = value; }
        public int pP_Y3 { get => vP_y3; set => vP_y3 = value; }
        public int pP_X4 { get => vP_x4; set => vP_x4 = value; }
        public int pP_Y4 { get => vP_y4; set => vP_y4 = value; }


        private bool vP_stateOfPiece = true;// true inseamna ca inca se misca
        public bool pP_StateOfPiece { get => vP_stateOfPiece; set => vP_stateOfPiece = value; }



        #endregion


        #region Metode
        public void fP_PozInit(Game game)
        {
            /*---------------------------------------------------------------------------
            DESCRIPTION: - va pune in matrice la coordonatelei piesei valoarea 1, iar apoi va cauta
                            in matrice unde este valoarea 1, si o va colora cu rosu.
                          - pe scurt, va desena piesa in pozitia initiala.

            ---------------------------------------------------------------------------*/


            fP_ColoreazaPiesaCurenta(game);


        }



        public void fP_MutaJos(Game game)
        {
            /*---------------------------------------------------------------------------
                 DESCRIPTION: - va verifica daca urmatoarea pozitie de jos a piesei este libera,
                                iar apoi va sterge piesa din pozitia curenta si o va desena cu 
                                o pozitie mai jos. In caz ca pozitia urmatoare este ocupata, piesa
                                se va opri din coborat, si se va genera urmatoarea piesa
            ---------------------------------------------------------------------------*/


            //punem 0 in matrice unde vrem sa stergem piesa curenta
            game.pG_Matrice[pP_X1, pP_Y1] = 0;
            game.pG_Matrice[pP_X2, pP_Y2] = 0;
            game.pG_Matrice[pP_X3, pP_Y3] = 0;
            game.pG_Matrice[pP_X4, pP_Y4] = 0;

            pP_StateOfPiece = true;


            if (fP_VerificaUrmPozitieJos(game))
            {


                //cauta in matrice unde e 0 si coloreaza albastru
                fP_StergePiesaCurentaV2(game);

                //mutam cu un rand mai jos
                pP_Y1++; pP_Y2++; pP_Y3++; pP_Y4++;

                //si coloram pe urmatoarea pozitie
                fP_ColoreazaPiesaCurenta(game);

                game.pG_Scor += 1;

                game.lblScor.Text = game.pG_Scor.ToString();

                pP_StateOfPiece = false;
                

            }
            else
            {

                //game.timer1.Stop();

                game.fG_GenerarePiesaRandom();

                fP_PozInit(game);

                //game.timer1.Start();

                pP_StateOfPiece = true;
            }

        }

        public void fP_MutaDreapta(Game game)
        {
            /*---------------------------------------------------------------------------
                 DESCRIPTION: - va verifica daca pozitia din dreapta piesei este libera,
                                iar apoi va sterge piesa din pozitia curenta si o va desena cu 
                                o pozitie mai in dreapta.
            ---------------------------------------------------------------------------*/

            //stergerea cubului curent(adica il coloram cu negru)
            game.pG_Matrice[pP_X1, pP_Y1] = 0;
            game.pG_Matrice[pP_X2, pP_Y2] = 0;
            game.pG_Matrice[pP_X3, pP_Y3] = 0;
            game.pG_Matrice[pP_X4, pP_Y4] = 0;


            if (fP_VerificaUrmPozitieDreapta(game))
            {
                fP_StergePiesaCurentaV2(game);

                //mutam cu un rand mai in dreapta
                pP_X1++; pP_X2++; pP_X3++; pP_X4++;

                // si coloram pe urmatoarea pozitie
                fP_ColoreazaPiesaCurenta(game);
            }
        }

        public void fP_MutaStanga(Game game)
        {
            /*---------------------------------------------------------------------------
                 DESCRIPTION: - va verifica daca pozitia din stanga piesei este libera,
                                iar apoi va sterge piesa din pozitia curenta si o va desena cu 
                                o pozitie mai in stanga.
            ---------------------------------------------------------------------------*/

            game.pG_Matrice[pP_X1, pP_Y1] = 0;
            game.pG_Matrice[pP_X2, pP_Y2] = 0;
            game.pG_Matrice[pP_X3, pP_Y3] = 0;
            game.pG_Matrice[pP_X4, pP_Y4] = 0;


            if (fP_VerificaUrmPozitieStanga(game))
            {
                fP_StergePiesaCurentaV2(game);

                //mutam cu un rand mai in stanga
                pP_X1--; pP_X2--; pP_X3--; pP_X4--;

                // si coloram pe urmatoarea pozitie

                fP_ColoreazaPiesaCurenta(game);
            }
        }



        public bool fP_VerificaUrmPozitieJos(Game game)
        {
            /*---------------------------------------------------------------------------
                 DESCRIPTION: - va verifica daca urmatoarea pozitie de jos a piesei este 
                                libera.

                 Return:      - va returna true daca urmatoarea pozitie este libera, iar in caz
                                contrar, false
            ---------------------------------------------------------------------------*/

            bool eLiber = false;

            if (game.pG_Matrice[pP_X1, pP_Y1 + 1] == 0 &&
                game.pG_Matrice[pP_X2, pP_Y2 + 1] == 0 &&
                game.pG_Matrice[pP_X3, pP_Y3 + 1] == 0 &&
                game.pG_Matrice[pP_X4, pP_Y4 + 1] == 0)
            {
                eLiber = true;
            }


            return eLiber;
        }

        public bool fP_VerificaUrmPozitieDreapta(Game game)
        {
            /*---------------------------------------------------------------------------
                 DESCRIPTION: - va verifica daca pozitia din dreapta piesei este libera.

                 Return:      - va returna true daca urm. pozitie din dreapta este libera, 
                                iar in caz contrar false
            ---------------------------------------------------------------------------*/

            bool eLiber = false;

            if (game.pG_Matrice[pP_X1 + 1, pP_Y1] == 0 &&
                game.pG_Matrice[pP_X2 + 1, pP_Y2] == 0 &&
                game.pG_Matrice[pP_X3 + 1, pP_Y3] == 0 &&
                game.pG_Matrice[pP_X4 + 1, pP_Y4] == 0)
            {
                eLiber = true;
            }
            return eLiber;
        }

        public bool fP_VerificaUrmPozitieStanga(Game game)
        {
            /*---------------------------------------------------------------------------
                 DESCRIPTION: - va verifica daca pozitia din stanga piesei este libera.

                 Return:      - va returna true daca urm. pozitie din stanga este libera, 
                               iar in caz contrar false
            ---------------------------------------------------------------------------*/

            bool eLiber = false;

            if (game.pG_Matrice[pP_X1 - 1, pP_Y1] == 0 &&
                game.pG_Matrice[pP_X2 - 1, pP_Y2] == 0 &&
                game.pG_Matrice[pP_X3 - 1, pP_Y3] == 0 &&
                game.pG_Matrice[pP_X4 - 1, pP_Y4] == 0)
            {
                eLiber = true;
            }
            return eLiber;
        }



        public void fP_StergePiesaCurenta(Game game)
        {
            /*---------------------------------------------------------------------------
                 DESCRIPTION: - va pune 0 pe pozitia curenta a piesei, apoi va cauta in matrice 
                                unde este 0 si va colora cu nuanta de culoare a backgroundului.
                              - pe scurt, va sterge piesa din pozitia curenta
            ---------------------------------------------------------------------------*/

            game.pG_Matrice[pP_X1, pP_Y1] = 0;
            game.pG_Matrice[pP_X2, pP_Y2] = 0;
            game.pG_Matrice[pP_X3, pP_Y3] = 0;
            game.pG_Matrice[pP_X4, pP_Y4] = 0;

            for (int i = 1; i < game.pG_Matrice.GetLength(0) - 1; i++)
            {
                for (int j = 1; j < game.pG_Matrice.GetLength(1) - 1; j++)
                {
                    if (game.pG_Matrice[i, j] == 0)
                        game.tableLayoutPanel1.GetControlFromPosition(i, j).BackColor = Color.FromArgb(38, 38, 38);
                }
            }

        }

        public void fP_ColoreazaPiesaCurenta(Game game)
        {
            /*---------------------------------------------------------------------------
                 DESCRIPTION: - va pune 1 pe pozitia curenta a piesei, apoi va cauta in matrice 
                                unde este 1 si va colora cu rosu.
                              - pe scurt, va coloro piesa in pozitia curenta
            ---------------------------------------------------------------------------*/
            game.pG_Matrice[pP_X1, pP_Y1] = 1;
            game.pG_Matrice[pP_X2, pP_Y2] = 1;
            game.pG_Matrice[pP_X3, pP_Y3] = 1;
            game.pG_Matrice[pP_X4, pP_Y4] = 1;

            for (int i = 1; i < game.pG_Matrice.GetLength(0) - 1; i++)
            {
                for (int j = 1; j < game.pG_Matrice.GetLength(1) - 1; j++)
                {
                    if (game.pG_Matrice[i, j] == 1)
                        game.tableLayoutPanel1.GetControlFromPosition(i, j).BackColor = Color.FromArgb(170, 5, 5);
                }
            }

        }

        public void fP_StergePiesaCurentaV2(Game game)
        {
            /*---------------------------------------------------------------------------
                 DESCRIPTION: - va cauta in matrice unde este 0 si va colora cu nuanta de 
                                culoare a backgroundului.
            ---------------------------------------------------------------------------*/
            for (int i = 1; i < game.pG_Matrice.GetLength(0) - 1; i++)
            {
                for (int j = 1; j < game.pG_Matrice.GetLength(1) - 1; j++)
                {
                    if (game.pG_Matrice[i, j] == 0)
                        game.tableLayoutPanel1.GetControlFromPosition(i, j).BackColor = Color.FromArgb(38, 38, 38);
                }
            }
        }

        #endregion


        #region Metode virtuale
        public virtual void fP_RotirePiesaInPoz2(Game game) { }

        public virtual void fP_RotirePiesaInPoz1(Game game) { }

        public virtual void fP_RotirePiesaInPoz3(Game game) { }

        public virtual void fP_RotirePiesaInPoz4(Game game) { }

        public virtual void fP_RotirePiesa(Game game) { }



        public virtual bool fP_VerificaDacaPoz2ELibera(Game game) { return false; }

        public virtual bool fP_VerificaDacaPoz1ELibera(Game game) { return false; }

        public virtual bool fP_VerificaDacaPoz3ELibera(Game game) { return false; }

        public virtual bool fP_VerificaDacaPoz4ELibera(Game game) { return false; }

        #endregion


    }

}

