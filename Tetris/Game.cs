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
        Piesa piesa;
        Tabel tabel;

        public int scor = 0;

        Random rd = new Random();
        int nrRand;
        public int[,] matrice = new int[12, 22]; // toate elementele sunt initializate cu 0



        public Game(Launcher launcher)
        {

            InitializeComponent();
            lnc = launcher;
            tabel = new Tabel();
            tabel.DrawTableBorder(this);


        }

        public Game() { }

        private void timer1_Tick(object sender, EventArgs e)
        {

            piesa.MutaJos(this);

            if (piesa.stateOfPiece == false)
            {
                tabel.StergeLinieDacaECompleta(this, piesa);
            }

            if (tabel.GameOver(this))
            {
                //timer1.Interval = 100000000;
                timer1.Enabled = false;
                MessageBox.Show("GAME OVER \n Scorul dvs. este: " + scor);

                this.Hide();
                lnc.Show();

            }

            if (scor > 100)
                timer1.Interval = 275;
            if (scor > 200)
                timer1.Interval = 250;
            if (scor > 300)
                timer1.Interval = 200;
            if (scor > 400)
                timer1.Interval = 175;
            if (scor > 500)
                timer1.Interval = 150;
            if (scor > 600)
                timer1.Interval = 135;
            if (scor > 800)
                timer1.Interval = 95;
            if (scor > 1000)
                timer1.Interval = 50;


        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            GenerarePiesaRandom();

            timer1.Start();

            btnPlay.Enabled = false;
        }



        public void GenerarePiesaRandom()
        {
            /*---------------------------------------------------------------------------
                 DESCRIPTION: - va genera la intamplare o piesa din cele 5.
            ---------------------------------------------------------------------------*/

            nrRand = rd.Next(1, 8);//genereaza un nr random intre 1 si 7

            if (nrRand == 1)
            {
                piesa = new Patrat();
                piesa.PozInit(this);
            }
            else if (nrRand == 2)
            {
                piesa = new Linie();
                piesa.PozInit(this);
            }
            else if (nrRand == 3)
            {
                piesa = new T();
                piesa.PozInit(this);
            }
            else if (nrRand == 4)
            {
                piesa = new L();
                piesa.PozInit(this);
            }
            else if (nrRand == 5)
            {
                piesa = new Patru();
                piesa.PozInit(this);
            }
            else if (nrRand == 6)
            {
                piesa = new J();
                piesa.PozInit(this);
            }
            else
            {
                piesa = new PatruIntors();
                piesa.PozInit(this);
            }
        }


        private void Game_KeyDown(object sender, KeyEventArgs e)
        {


            if (e.KeyCode == Keys.Right)
            {
                piesa.MutaDreapta(this);
            }
            if (e.KeyCode == Keys.Left)
            {
                piesa.MutaStanga(this);
            }
            if (e.KeyCode == Keys.Up)
            {
                piesa.RotirePiesa(this);
            }
            if (e.KeyCode == Keys.Down)
            {
                piesa.MutaJos(this);
            }
            if (e.KeyCode == Keys.Escape)
            {
                this.Hide();
                lnc.Show();
            }
        }



        private void label267_Click(object sender, EventArgs e)
        {
            this.Hide();
            lnc.Show();
        }

    }
}
