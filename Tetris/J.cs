using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    class J : Piesa
    {

        int pozitiePiesa = 1;
        public int PozitiePiesa { get => pozitiePiesa; set => pozitiePiesa = value; }


        #region Metode

        public J()
        {
            pP_X1 = 6; pP_Y1 = 1;//prima celula din J                ex:  1
            pP_X2 = 6; pP_Y2 = 2;//a 2a celula din J                      2
            pP_X3 = 6; pP_Y3 = 3;//a 3a celula din J                    4 3 
            pP_X4 = 5; pP_Y4 = 3;//a 4a celula din J
        }





        public override void fP_RotirePiesaInPoz2(Game game)
        {
            if (fP_VerificaDacaPoz2ELibera(game))
            {
                PozitiePiesa = 2;

                this.fP_StergePiesaCurenta(game);


                //roteste piesa
                pP_X1++; pP_Y1++;
                pP_X3--; pP_Y3--;
                pP_Y4 = pP_Y4 - 2;



                this.fP_ColoreazaPiesaCurenta(game);
            }
        }

        public override void fP_RotirePiesaInPoz3(Game game)
        {
            if (fP_VerificaDacaPoz3ELibera(game))
            {
                PozitiePiesa = 3;

                this.fP_StergePiesaCurenta(game);


                //roteste piesa
                pP_X1--; pP_Y1++;
                pP_X3++; pP_Y3--;
                pP_X4 = pP_X4 + 2;

                this.fP_ColoreazaPiesaCurenta(game);
            }
        }

        public override void fP_RotirePiesaInPoz4(Game game)
        {
            if (fP_VerificaDacaPoz4ELibera(game))
            {
                PozitiePiesa = 4;

                this.fP_StergePiesaCurenta(game);


                //roteste piesa
                pP_X1--; pP_Y1--;
                pP_X3++; pP_Y3++;
                pP_Y4 = pP_Y4 + 2;


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
                pP_X1++; pP_Y1--;
                pP_X3--; pP_Y3++;
                pP_X4 = pP_X4 - 2;


                this.fP_ColoreazaPiesaCurenta(game);
            }


        }

        public override void fP_RotirePiesa(Game game)
        {
            if (PozitiePiesa == 1)
                fP_RotirePiesaInPoz2(game);
            else if (PozitiePiesa == 2)
                fP_RotirePiesaInPoz3(game);
            else if (PozitiePiesa == 3)
                fP_RotirePiesaInPoz4(game);
            else
                fP_RotirePiesaInPoz1(game);
        }


        //verificarile daca se poate roti piesa

        public override bool fP_VerificaDacaPoz2ELibera(Game game)
        {
            bool eLiber = false;

            if (game.pG_Matrice[pP_X1 + 1, pP_Y1 + 1] == 0
                )
            {
                eLiber = true;
            }

            return eLiber;
        }

        public override bool fP_VerificaDacaPoz3ELibera(Game game)
        {
            bool eLiber = false;

            if (game.pG_Matrice[pP_X4 + 2, pP_Y4] == 0 &&
                game.pG_Matrice[pP_X1 - 1, pP_Y1 + 1] == 0 &&
                game.pG_Matrice[pP_X3 + 1, pP_Y3 - 1] == 0
               )
            {
                eLiber = true;
            }

            return eLiber;


        }

        public override bool fP_VerificaDacaPoz4ELibera(Game game)
        {
            bool eLiber = false;

            if (game.pG_Matrice[pP_X4, pP_Y4 + 2] == 0 &&
                game.pG_Matrice[pP_X1 - 1, pP_Y1 - 1] == 0 &&
                game.pG_Matrice[pP_X3 + 1, pP_Y3 + 1] == 0
                )
            {
                eLiber = true;
            }

            return eLiber;

        }

        public override bool fP_VerificaDacaPoz1ELibera(Game game)
        {
            bool eLiber = false;

            if (game.pG_Matrice[pP_X4 - 2, pP_Y4] == 0 &&
                game.pG_Matrice[pP_X3 - 1, pP_Y3 + 1] == 0 &&
                game.pG_Matrice[pP_X1 + 1, pP_Y1 - 1] == 0
                )
            {
                eLiber = true;
            }

            return eLiber;

        }
        #endregion


    }
}
