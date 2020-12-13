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

        public int x1, y1;
        public int x2, y2;
        public int x3, y3;
        public int x4, y4;

        public bool stateOfPiece = true;// true inseamna ca inca se misca

        public void PozInit(Game game)
        {
            /*---------------------------------------------------------------------------
             DESCRIPTION: - va pune in matrice la coordonatelei piesei valoarea 1, iar apoi va cauta
                            in matrice unde este valoarea 1, si o va colora.
                          - pe scurt, va desena piesa in pozitia initiala.
            ---------------------------------------------------------------------------*/


            ColoreazaPiesaCurenta(game);


        }



        public void MutaJos(Game game)
        {
            /*---------------------------------------------------------------------------
                 DESCRIPTION: - va verifica daca urmatoarea pozitie de jos a piesei este libera,
                                iar apoi va sterge piesa din pozitia curenta si o va desena cu 
                                o pozitie mai jos. In caz ca pozitia urmatoare este ocupata, piesa
                                se va opri din coborat, si se va genera urmatoarea piesa
            ---------------------------------------------------------------------------*/

            //punem 0 in matrice unde vrem sa stergem piesa curenta

            game.matrice[x1, y1] = 0;
            game.matrice[x2, y2] = 0;
            game.matrice[x3, y3] = 0;
            game.matrice[x4, y4] = 0;

            stateOfPiece = true;


            if (VerificaUrmPozitieJos(game))
            {


                //cauta in matrice unde e 0 si coloreaza albastru
                StergePiesaCurentaV2(game);

                //mutam cu un rand mai jos
                y1++; y2++; y3++; y4++;

                // si coloram pe urmatoarea pozitie

                ColoreazaPiesaCurenta(game);

                game.scor += 1;

                game.lblScor.Text = game.scor.ToString();

                stateOfPiece = false;




            }
            else
            {

                //game.timer1.Stop();

                game.GenerarePiesaRandom();

                PozInit(game);

                //game.timer1.Start();

                stateOfPiece = true;
            }

        }

        public void MutaDreapta(Game game)
        {
            /*---------------------------------------------------------------------------
                 DESCRIPTION: - va verifica daca pozitia din dreapta piesei este libera,
                                iar apoi va sterge piesa din pozitia curenta si o va desena cu 
                                o pozitie mai in dreapta.
            ---------------------------------------------------------------------------*/

            //stergerea cubului curent(adica il coloram cu albastru)

            game.matrice[x1, y1] = 0;
            game.matrice[x2, y2] = 0;
            game.matrice[x3, y3] = 0;
            game.matrice[x4, y4] = 0;


            if (VerificaUrmPozitieDreapta(game))
            {
                StergePiesaCurentaV2(game);

                //mutam cu un rand mai jos
                x1++; x2++; x3++; x4++;

                // si coloram pe urmatoarea pozitie
                ColoreazaPiesaCurenta(game);
            }
        }

        public void MutaStanga(Game game)
        {
            /*---------------------------------------------------------------------------
                 DESCRIPTION: - va verifica daca pozitia din stanga piesei este libera,
                                iar apoi va sterge piesa din pozitia curenta si o va desena cu 
                                o pozitie mai in stanga.
            ---------------------------------------------------------------------------*/

            game.matrice[x1, y1] = 0;
            game.matrice[x2, y2] = 0;
            game.matrice[x3, y3] = 0;
            game.matrice[x4, y4] = 0;


            if (VerificaUrmPozitieStanga(game))
            {
                StergePiesaCurentaV2(game);

                //mutam cu un rand mai jos
                x1--; x2--; x3--; x4--;

                // si coloram pe urmatoarea pozitie

                ColoreazaPiesaCurenta(game);
            }
        }



        public bool VerificaUrmPozitieJos(Game game)
        {
            /*---------------------------------------------------------------------------
                 DESCRIPTION: - va verifica daca urmatoarea pozitie de jos a piesei este 
                                libera.

                 Return:       - va returna true daca urm. pozitie este libera, iar in caz
                                 contrat false
            ---------------------------------------------------------------------------*/
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

        public bool VerificaUrmPozitieDreapta(Game game)
        {
            /*---------------------------------------------------------------------------
                 DESCRIPTION: - va verifica daca pozitia din dreapta piesei este libera.

                 Return:       - va returna true daca urm. pozitie este libera, iar in caz
                                 contrat false
            ---------------------------------------------------------------------------*/
            bool eLiber = false;

            if (game.matrice[x1 + 1, y1] == 0 &&
                game.matrice[x2 + 1, y2] == 0 &&
                game.matrice[x3 + 1, y3] == 0 &&
                game.matrice[x4 + 1, y4] == 0)
            {
                eLiber = true;
            }
            return eLiber;
        }

        public bool VerificaUrmPozitieStanga(Game game)
        {
            /*---------------------------------------------------------------------------
                 DESCRIPTION: - va verifica daca pozitia din stanga piesei este libera.

                 Return:       - va returna true daca urm. pozitie este libera, iar in caz
                                 contrat false
            ---------------------------------------------------------------------------*/
            bool eLiber = false;

            if (game.matrice[x1 - 1, y1] == 0 &&
                game.matrice[x2 - 1, y2] == 0 &&
                game.matrice[x3 - 1, y3] == 0 &&
                game.matrice[x4 - 1, y4] == 0)
            {
                eLiber = true;
            }
            return eLiber;
        }



        public void StergePiesaCurenta(Game game)
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

        }

        public void ColoreazaPiesaCurenta(Game game)
        {

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

        public void StergePiesaCurentaV2(Game game)
        {

            for (int i = 1; i < game.matrice.GetLength(0) - 1; i++)
            {
                for (int j = 1; j < game.matrice.GetLength(1) - 1; j++)
                {
                    if (game.matrice[i, j] == 0)
                        game.tableLayoutPanel1.GetControlFromPosition(i, j).BackColor = Color.Blue;
                }
            }
        }



        public virtual void RotirePiesaInPoz2(Game game) { }

        public virtual void RotirePiesaInPoz1(Game game) { }

        public virtual void RotirePiesaInPoz3(Game game) { }

        public virtual void RotirePiesaInPoz4(Game game) { }

        public virtual void RotirePiesa(Game game) { }



        public virtual bool VerificaDacaPoz2ELibera(Game game) { return false; }

        public virtual bool VerificaDacaPoz1ELibera(Game game) { return false; }

        public virtual bool VerificaDacaPoz3ELibera(Game game) { return false; }

        public virtual bool VerificaDacaPoz4ELibera(Game game) { return false; }



    }

}

