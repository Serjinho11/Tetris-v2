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

        public int currentScore = 0;

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
                currentScore = scor;

                if (currentScore >= lnc.HighScore)
                    lnc.HighScore = currentScore;

                lnc.lblHighScore.Text = lnc.HighScore.ToString();
                timer1.Enabled = false;
                MessageBox.Show("GAME OVER \n Scorul dvs. este: " + scor);

                this.Hide();
                lnc.Show();

            }

            DifficultyChanger();

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

        public void DifficultyChanger()
        {

            if (scor > 100)
            {
                timer1.Interval = 275;
                lblLevel.Text = "Basic";
            }
            if (scor > 200)
            {
                timer1.Interval = 250;
                lblLevel.Text = "Intermediate";

            }
            if (scor > 300)
            {
                timer1.Interval = 200;
                lblLevel.Text = "Advanced";

            }
            if (scor > 400)
            {
                timer1.Interval = 175;
                lblLevel.Text = "Expert";
            }
            if (scor > 500)
            {
                timer1.Interval = 150;
                lblLevel.Text = "No Pain, No Gain";
            }
            if (scor > 600)
            {
                timer1.Interval = 135;
                lblLevel.Text = "Damn I'm Good";
            }
            if (scor > 800)
            {
                timer1.Interval = 95;
                lblLevel.Text = "Hardcore";
            }
            if (scor > 1000)
            {
                timer1.Interval = 50;
                lblLevel.Text = "Nightmare!";

            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            GenerarePiesaRandom();

            timer1.Start();

            btnPlay.Enabled = false;
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


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            lnc.Show();
        }
    }
}
