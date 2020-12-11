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

        public J()
        {
            x1 = 6; y1 = 1;//prima celula din patrat                ex:  1
            x2 = 6; y2 = 2;//a 2a celula din patrat                      2
            x3 = 6; y3 = 3;//a 3a celula din patrat                    4 3 
            x4 = 5; y4 = 3;//a 4a celula din patrat
        }





        public override void rotirePiesaInPoz2(Game game)
        {
            if (VerificaDacaPoz2ELibera(game))
            {
                pozitiePiesa = 2;

                this.StergePiesaCurenta(game);


                //roteste piesa
                x1++; y1++;
                x3--; y3--;
                y4 = y4 - 2;



                this.ColoreazaPiesaCurenta(game);
            }
        }

        public override void rotirePiesaInPoz3(Game game)
        {
            if (VerificaDacaPoz3ELibera(game))
            {
                pozitiePiesa = 3;

                this.StergePiesaCurenta(game);


                //roteste piesa
                x1--; y1++;
                x3++; y3--;
                x4 = x4 + 2;

                this.ColoreazaPiesaCurenta(game);
            }
        }

        public override void rotirePiesaInPoz4(Game game)
        {
            if (VerificaDacaPoz4ELibera(game))
            {
                pozitiePiesa = 4;

                this.StergePiesaCurenta(game);


                //roteste piesa
                x1--; y1--;
                x3++; y3++;
                y4 = y4 + 2;


                this.ColoreazaPiesaCurenta(game);
            }
        }

        public override void rotirePiesaInPoz1(Game game)
        {
            if (VerificaDacaPoz1ELibera(game))
            {
                pozitiePiesa = 1;

                this.StergePiesaCurenta(game);


                //roteste piesa
                x1++; y1--;
                x3--; y3++;
                x4 = x4 - 2;


                this.ColoreazaPiesaCurenta(game);
            }


        }

        public override void RotirePiesa(Game game)
        {
            if (pozitiePiesa == 1)
                rotirePiesaInPoz2(game);
            else if (pozitiePiesa == 2)
                rotirePiesaInPoz3(game);
            else if (pozitiePiesa == 3)
                rotirePiesaInPoz4(game);
            else
                rotirePiesaInPoz1(game);
        }


        //verificarile daca se poate roti piesa

        public override bool VerificaDacaPoz2ELibera(Game game)
        {
            bool eLiber = false;

            if (game.matrice[x1 + 1, y1 + 1] == 0
                )
            {
                eLiber = true;
            }

            return eLiber;
        }

        public override bool VerificaDacaPoz3ELibera(Game game)
        {
            bool eLiber = false;

            if (game.matrice[x4 + 2, y4] == 0 &&
                game.matrice[x1 - 1, y1 + 1] == 0 &&
                game.matrice[x3 + 1, y3 - 1] == 0
               )
            {
                eLiber = true;
            }

            return eLiber;


        }

        public override bool VerificaDacaPoz4ELibera(Game game)
        {
            bool eLiber = false;

            if (game.matrice[x4, y4 + 2] == 0 &&
                game.matrice[x1 - 1, y1 - 1] == 0 &&
                game.matrice[x3 + 1, y3 + 1] == 0
                )
            {
                eLiber = true;
            }

            return eLiber;

        }

        public override bool VerificaDacaPoz1ELibera(Game game)
        {
            bool eLiber = false;

            if (game.matrice[x4 - 2, y4] == 0 &&
                game.matrice[x3 - 1, y3 + 1] == 0 &&
                game.matrice[x1 + 1, y1 - 1] == 0
                )
            {
                eLiber = true;
            }

            return eLiber;

        }

    }
}
