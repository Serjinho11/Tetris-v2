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

        public Linie()
        {
            x1 = 4; y1 = 1;//prima celula din patrat                ex: x
            x2 = 5; y2 = 1;//a 2a celula din patrat                  y  1 2 3 4 
            x3 = 6; y3 = 1;//a 3a celula din patrat                     
            x4 = 7; y4 = 1;//a 4a celula din patrat
        }



        public override void rotirePiesaInPoz2(Game game)
        {
            /*
                                     1
                1 2 3 4   --->       2
                                     3
                                     4
            */
            if (VerificaDacaPoz2ELibera(game))
            {
                pozitiePiesa = 2;

                this.StergePiesaCurenta(game);


                //roteste piesa
                x1 = x1 + 2; y1 = y1 - 2;
                x2++; y2--;
                //x3 si y3 raman la fel
                x4--; y4++;


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
                x1 = x1 - 2; y1 = y1 + 2;
                x2--; y2++;
                //x3 si y3 raman la fel
                x4++; y4--;


                this.ColoreazaPiesaCurenta(game);
            }

        }


        public override void RotirePiesa(Game game)
        {
            //trebuie sa fac o functie care sa verifice cumva daca rotirea este posibila



            if (pozitiePiesa == 1)
                rotirePiesaInPoz2(game);
            else
                rotirePiesaInPoz1(game);
        }


        public override bool VerificaDacaPoz2ELibera(Game game)
        {
            bool eLiber = false;

            if (game.matrice[x2 + 1, y2 - 1] == 0)// acest if este pt cand se genereaza o linie si ii dam pe rotire
            {                                     // cand e sus de tot, fara asta ne da o exceptie
                if (game.matrice[x1 + 2, y1 - 2] == 0 &&
                    game.matrice[x2 + 1, y2 - 1] == 0 &&
                    // game.matrice[x3, y3] == 0 &&
                    game.matrice[x4 - 1, y4 + 1] == 0)
                {
                    eLiber = true;
                }
            }
            return eLiber;
        }

        public override bool VerificaDacaPoz1ELibera(Game game)
        {
            bool eLiber = false;
            if (game.matrice[x2 - 1, y2 + 1] == 0 && game.matrice[x4 + 1, y4 - 1] == 0)//prima data verifica daca celula 2 si 4 e libera, altfel mai sunt niste exceptii
            {                                                                          // pt ca ar accesa celule din afara matricei
                if (game.matrice[x1 - 2, y1 + 2] == 0 &&
                game.matrice[x2 - 1, y2 + 1] == 0 &&
                game.matrice[x4 + 1, y4 - 1] == 0)
                    eLiber = true;
            }


            return eLiber;
        }

    }
}
