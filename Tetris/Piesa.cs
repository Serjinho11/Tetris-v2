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

        string numePiesa;
        string culoare;
        public string NumePiesa { get => numePiesa; set => numePiesa = value; }
        public string Culoare { get => culoare; set => culoare = value; }

        Game game1 = new Game();


        public Piesa()
        {
            this.NumePiesa = "Piesa default";
            this.Culoare = "Alb";
        }

        public Piesa(string numePiesa, string culoare)
        {
            this.numePiesa = numePiesa;
            this.culoare = culoare;
        }
        public virtual void pozInit(Game game) { }
        public virtual void mutaJos(Game game) { }

    }
}
