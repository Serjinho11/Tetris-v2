using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tetris
{
    public partial class Game : Form
    {
        Launcher lnc;

        Patrat patrat;
        Linie linie;
        T t;
        L l;

        Piesa piesa;

        int nrRand;

        public Game(Launcher launcher)
        {
            InitializeComponent();
            lnc = launcher;
        }

        public Game() { }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            lnc.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            // patrat = new Patrat();
            // patrat.mutaJos(this);


            //linie = new Linie();
            //linie.mutaJos(this);

            piesa.mutaJos(this);
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {

            Random rd = new Random();
            nrRand = rd.Next(1, 5);

            if (nrRand == 1)
            {
                piesa = new Patrat();
                piesa.pozInit(this);
            }
            else if(nrRand==2){
                piesa = new Linie();
                piesa.pozInit(this);
            }
            else if (nrRand == 3)
            {
                piesa = new T();
                piesa.pozInit(this);
            }
            else if (nrRand == 4)
            {
                piesa= new L();
                piesa.pozInit(this);
            }


            timer1.Start();

            //timer1.Stop();

        }
    }
}
