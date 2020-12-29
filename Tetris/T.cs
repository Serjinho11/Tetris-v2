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

        private int pozitiePiesa = 1;
        public int PozitiePiesa { get => pozitiePiesa; set => pozitiePiesa = value; }


        #region Metode
        public T()
        {
            pP_X1 = 5; pP_Y1 = 2;//prima celula din T                ex:   4
            pP_X2 = 6; pP_Y2 = 2;//a 2a celula din T                     1 2 3 
            pP_X3 = 7; pP_Y3 = 2;//a 3a celula din T                     
            pP_X4 = 6; pP_Y4 = 1;//a 4a celula din T
        }

        public override void fP_RotirePiesaInPoz2(Game game)
        {
            /*---------------------------------------------------------------------------
            DESCRIPTION: - va verifica daca pozitia 2 a piesei este libera, apoi sterge piesa
                           din pozitia curenta, roteste piesa in pozitia 2 modificand coordonatele
                           fiecarui patratel al piesei, apoi o coloreaza in pozitia 2; in plus, 
                           pune in variabila PozitiePiesa(ce reprezita pozitia curenta a piesei)
                           valoarea 2.


                4           1
              1 2 3   ->    2 4
                            3

            ---------------------------------------------------------------------------*/
            if (fP_VerificaDacaPoz2ELibera(game))
            {
                PozitiePiesa = 2;

                fP_StergePiesaCurenta(game);


                //roteste piesa
                pP_X1++; pP_Y1--;
                pP_X3--; pP_Y3++;
                pP_X4++; pP_Y4++;

                fP_ColoreazaPiesaCurenta(game);
            }
        }

        public override void fP_RotirePiesaInPoz3(Game game)
        {
            /*---------------------------------------------------------------------------
            DESCRIPTION: - va verifica daca pozitia 3 a piesei este libera, apoi sterge piesa
                           din pozitia curenta, roteste piesa in pozitia 3 modificand coordonatele
                           fiecarui patratel al piesei, apoi o coloreaza in pozitia 3; in plus, 
                           pune in variabila PozitiePiesa(ce reprezita pozitia curenta a piesei)
                           valoarea 3.
                  1
                  2 4     ->   3 2 1
                  3              4

            ---------------------------------------------------------------------------*/
            if (fP_VerificaDacaPoz3ELibera(game))
            {
                PozitiePiesa = 3;

                this.fP_StergePiesaCurenta(game);


                //roteste piesa
                pP_X1++; pP_Y1++;
                pP_X3--; pP_Y3--;
                pP_X4--; pP_Y4++;

                this.fP_ColoreazaPiesaCurenta(game);
            }
        }

        public override void fP_RotirePiesaInPoz4(Game game)
        {
            /*---------------------------------------------------------------------------
            DESCRIPTION: - va verifica daca pozitia 4 a piesei este libera, apoi sterge piesa
                           din pozitia curenta, roteste piesa in pozitia 4 modificand coordonatele
                           fiecarui patratel al piesei, apoi o coloreaza in pozitia 4; in plus, 
                           pune in variabila PozitiePiesa(ce reprezita pozitia curenta a piesei)
                           valoarea 4.

                                  3   
                     3 2 1  ->  4 2
                       4          1
            ---------------------------------------------------------------------------*/
            if (fP_VerificaDacaPoz4ELibera(game))
            {
                PozitiePiesa = 4;

                this.fP_StergePiesaCurenta(game);


                //roteste piesa
                pP_X1--; pP_Y1++;
                pP_X3++; pP_Y3--;
                pP_X4--; pP_Y4--;


                this.fP_ColoreazaPiesaCurenta(game);
            }
        }

        public override void fP_RotirePiesaInPoz1(Game game)
        {
            /*---------------------------------------------------------------------------
            DESCRIPTION: - va verifica daca pozitia 1 a piesei este libera, apoi sterge piesa
                           din pozitia curenta, roteste piesa in pozitia 1 modificand coordonatele
                           fiecarui patratel al piesei, apoi o coloreaza in pozitia 1; in plus, 
                           pune in variabila PozitiePiesa(ce reprezita pozitia curenta a piesei)
                           valoarea 1.
                        3         4
                      4 2   ->  1 2 3
                        1

            ---------------------------------------------------------------------------*/
            if (fP_VerificaDacaPoz1ELibera(game))
            {
                PozitiePiesa = 1;

                this.fP_StergePiesaCurenta(game);


                //roteste piesa
                pP_X1--; pP_Y1--;
                pP_X3++; pP_Y3++;
                pP_X4++; pP_Y4--;


                this.fP_ColoreazaPiesaCurenta(game);
            }


        }

        public override void fP_RotirePiesa(Game game)
        {
            /*---------------------------------------------------------------------------
            DESCRIPTION: - in functie de valoarea variabilei PozitiePiesa, va roti piesa in
                           pozitia urmatoare; ex. daca piesa este in pozitia 2, atunci o va 
                           roti in urmatoarea pozitie, adica 3

            ---------------------------------------------------------------------------*/
            if (PozitiePiesa == 1)
                fP_RotirePiesaInPoz2(game);
            else if (PozitiePiesa == 2)
                fP_RotirePiesaInPoz3(game);
            else if (PozitiePiesa == 3)
                fP_RotirePiesaInPoz4(game);
            else
                fP_RotirePiesaInPoz1(game);
        }


        // verificarile daca se poate roti piesa

        public override bool fP_VerificaDacaPoz2ELibera(Game game)
        {
            /*---------------------------------------------------------------------------
            DESCRIPTION: - va verifica daca urmatoarea pozitie in care trebuie rotita piesa(adica 2)
                           este libera.

            ---------------------------------------------------------------------------*/
            bool eLiber = false;
            if (
                game.pG_Matrice[pP_X3 - 1, pP_Y3 + 1] == 0
                )
            {
                eLiber = true;
            }

            return eLiber;
        }

        public override bool fP_VerificaDacaPoz3ELibera(Game game)
        {
            /*---------------------------------------------------------------------------
            DESCRIPTION: - va verifica daca urmatoarea pozitie in care trebuie rotita piesa(adica 3)
                           este libera.

            ---------------------------------------------------------------------------*/
            bool eLiber = false;
            if (
                game.pG_Matrice[pP_X3 - 1, pP_Y3 - 1] == 0
                )
            {
                eLiber = true;
            }

            return eLiber;

        }

        public override bool fP_VerificaDacaPoz4ELibera(Game game)
        {
            /*---------------------------------------------------------------------------
            DESCRIPTION: - va verifica daca urmatoarea pozitie in care trebuie rotita piesa(adica 4)
                           este libera.

            ---------------------------------------------------------------------------*/
            bool eLiber = false;
            if (
                game.pG_Matrice[pP_X3 + 1, pP_Y3 - 1] == 0
                )
            {
                eLiber = true;
            }

            return eLiber;
        }

        public override bool fP_VerificaDacaPoz1ELibera(Game game)
        {
            /*---------------------------------------------------------------------------
            DESCRIPTION: - va verifica daca urmatoarea pozitie in care trebuie rotita piesa(adica 1)
                           este libera.

            ---------------------------------------------------------------------------*/
            bool eLiber = false;
            if (
                game.pG_Matrice[pP_X3 + 1, pP_Y3 + 1] == 0
                )
            {
                eLiber = true;
            }

            return eLiber;
        }

        #endregion


    }
}
