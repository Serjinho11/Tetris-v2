using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    class L : Piesa
    {
        int pozitiePiesa = 1;

        public L()
        {
            x1 = 6; y1 = 1;//prima celula din patrat                ex: 1
            x2 = 6; y2 = 2;//a 2a celula din patrat                     2
            x3 = 6; y3 = 3;//a 3a celula din patrat                     3 4
            x4 = 7; y4 = 3;//a 4a celula din patrat
        }





        public override void RotirePiesaInPoz2(Game game)
        {
            /*
                   1                  
                   2           --->    3 2 1 
                   3 4                 4 
                                     
            */
            if (VerificaDacaPoz2ELibera(game))
            {
                pozitiePiesa = 2;

                this.StergePiesaCurenta(game);


                //roteste piesa
                x1 = x1 + 2; y1 = y1 + 1;
                x2++; // y2 ramane la fel
                y3--; // x3 ramane la fel
                x4--; // y4 ramane la fel


                this.ColoreazaPiesaCurenta(game);
            }
        }

        public override void RotirePiesaInPoz3(Game game)
        {
            /*
                 3 2 1  --->    4 3
                 4                2
                                  1
                                     
            */
            if (VerificaDacaPoz3ELibera(game))
            {
                pozitiePiesa = 3;

                this.StergePiesaCurenta(game);


                //roteste piesa
                x1--; y1 = y1 + 2;
                y2++; // y2 ramane la fel
                x3++; // y3 ramane la fel
                y4--; // x4 ramane la fel

                this.ColoreazaPiesaCurenta(game);
            }
        }

        public override void RotirePiesaInPoz4(Game game)
        {
            /*
                   4 3            4
                     2  --->  1 2 3
                     1

           */
            if (VerificaDacaPoz4ELibera(game))
            {
                pozitiePiesa = 4;

                this.StergePiesaCurenta(game);


                //roteste piesa
                x1 = x1 - 2; y1--;
                x2--; // y2 ramane la fel
                y3++; // x3 ramane la fel
                x4++; // y4 ramane la fel


                this.ColoreazaPiesaCurenta(game);
            }
        }

        public override void RotirePiesaInPoz1(Game game)
        {
            /*                   1
                    4     --->   2
                1 2 3            3 4


          */
            if (VerificaDacaPoz1ELibera(game))
            {
                pozitiePiesa = 1;

                this.StergePiesaCurenta(game);


                //roteste piesa
                x1++; y1 = y1 - 2;
                y2--; // x2 ramane la fel
                x3--; // y3 ramane la fel
                y4++; // x4 ramane la fel


                this.ColoreazaPiesaCurenta(game);
            }


        }

        public override void RotirePiesa(Game game)
        {
            if (pozitiePiesa == 1)
                RotirePiesaInPoz2(game);
            else if (pozitiePiesa == 2)
                RotirePiesaInPoz3(game);
            else if (pozitiePiesa == 3)
                RotirePiesaInPoz4(game);
            else
                RotirePiesaInPoz1(game);
        }


        //verificarile daca se poate roti piesa

        public override bool VerificaDacaPoz2ELibera(Game game)
        {
            bool eLiber = false;

            if (game.matrice[x1 + 2, y1 + 1] == 0 &&
                game.matrice[x2 + 1, y2] == 0
                )
            {
                eLiber = true;
            }

            return eLiber;
        }

        public override bool VerificaDacaPoz3ELibera(Game game)
        {
            bool eLiber = false;

            if (game.matrice[x1 - 1, y1 + 2] == 0 &&
                game.matrice[x2, y2 + 1] == 0
                )
            {
                eLiber = true;
            }

            return eLiber;


        }

        public override bool VerificaDacaPoz4ELibera(Game game)
        {
            bool eLiber = false;

            if (game.matrice[x1 - 2, y1 - 1] == 0 &&
                game.matrice[x2 - 1, y2] == 0
                )
            {
                eLiber = true;
            }

            return eLiber;

        }

        public override bool VerificaDacaPoz1ELibera(Game game)
        {
            bool eLiber = false;

            if (game.matrice[x1 + 1, y1 - 2] == 0 &&
                game.matrice[x2, y2 - 1] == 0
                )
            {
                eLiber = true;
            }

            return eLiber;

        }
    }
}
