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

        int pozitiePiesa = 1;
        public int PozitiePiesa { get => pozitiePiesa; set => pozitiePiesa = value; }


        #region Metode

        public Linie()
        {
            pP_X1 = 4; pP_Y1 = 1;//prima celula din linie                ex: x
            pP_X2 = 5; pP_Y2 = 1;//a 2a celula din linie                  y  1 2 3 4 
            pP_X3 = 6; pP_Y3 = 1;//a 3a celula din linie                     
            pP_X4 = 7; pP_Y4 = 1;//a 4a celula din linie
        }



        public override void fP_RotirePiesaInPoz2(Game game)
        {
            /*
                                     1
                1 2 3 4   --->       2
                                     3
                                     4
            */
            if (fP_VerificaDacaPoz2ELibera(game))
            {
                PozitiePiesa = 2;

                this.fP_StergePiesaCurenta(game);


                //roteste piesa
                pP_X1 = pP_X1 + 2; pP_Y1 = pP_Y1 - 2;
                pP_X2++; pP_Y2--;
                //x3 si y3 raman la fel
                pP_X4--; pP_Y4++;


                this.fP_ColoreazaPiesaCurenta(game);
            }


        }

        public override void fP_RotirePiesaInPoz1(Game game)
        {
            if (fP_VerificaDacaPoz1ELibera(game))
            {
                PozitiePiesa = 1;
                this.fP_StergePiesaCurenta(game);


                //roteste piesa
                pP_X1 = pP_X1 - 2; pP_Y1 = pP_Y1 + 2;
                pP_X2--; pP_Y2++;
                //x3 si y3 raman la fel
                pP_X4++; pP_Y4--;


                this.fP_ColoreazaPiesaCurenta(game);
            }

        }


        public override void fP_RotirePiesa(Game game)
        {
            //trebuie sa fac o functie care sa verifice cumva daca rotirea este posibila



            if (PozitiePiesa == 1)
                fP_RotirePiesaInPoz2(game);
            else
                fP_RotirePiesaInPoz1(game);
        }


        public override bool fP_VerificaDacaPoz2ELibera(Game game)
        {
            bool eLiber = false;

            if (game.pG_Matrice[pP_X2 + 1, pP_Y2 - 1] == 0)// acest if este pt cand se genereaza o linie si ii dam pe rotire
            {                                     // cand e sus de tot, fara asta ne da o exceptie
                if (game.pG_Matrice[pP_X1 + 2, pP_Y1 - 2] == 0 &&
                    game.pG_Matrice[pP_X2 + 1, pP_Y2 - 1] == 0 &&
                    // game.matrice[x3, y3] == 0 &&
                    game.pG_Matrice[pP_X4 - 1, pP_Y4 + 1] == 0)
                {
                    eLiber = true;
                }
            }
            return eLiber;
        }

        public override bool fP_VerificaDacaPoz1ELibera(Game game)
        {
            bool eLiber = false;
            if (game.pG_Matrice[pP_X2 - 1, pP_Y2 + 1] == 0 && game.pG_Matrice[pP_X4 + 1, pP_Y4 - 1] == 0)//prima data verifica daca celula 2 si 4 e libera, altfel mai sunt niste exceptii
            {                                                                          // pt ca ar accesa celule din afara matricei
                if (game.pG_Matrice[pP_X1 - 2, pP_Y1 + 2] == 0 &&
                game.pG_Matrice[pP_X2 - 1, pP_Y2 + 1] == 0 &&
                game.pG_Matrice[pP_X4 + 1, pP_Y4 - 1] == 0)
                    eLiber = true;
            }


            return eLiber;
        }
        #endregion

    }
}
