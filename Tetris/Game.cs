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

        #region Variabile si Proprietati

        Launcher lnc;//obiect de tip launcher
        Piesa piesa;
        Tabel tabel;

        Random vG_Rnd = new Random();
        private int vG_nrRand;
        private int vG_scor = 0;
        private int vG_currentScore = 0;
        private int[,] vG_matrice = new int[12, 22]; // toate elementele sunt initializate cu 0


        public int pG_Scor { get => vG_scor; set => vG_scor = value; }
        public int pG_CurrentScore { get => vG_currentScore; set => vG_currentScore = value; }
        public int[,] pG_Matrice { get => vG_matrice; set => vG_matrice = value; }

        #endregion


        #region Metode
        public Game(Launcher launcher)
        {

            InitializeComponent();
            lnc = launcher;
            tabel = new Tabel();
            tabel.fT_DrawTableBorder(this);

        }

        private void fG_btnPlay_Click(object sender, EventArgs e)
        {
            fG_GenerarePiesaRandom();

            timer1.Start();

            btnPlay.Enabled = false;
        }

        public void fG_GenerarePiesaRandom()
        {
            /*---------------------------------------------------------------------------
                 DESCRIPTION: - va genera la intamplare o piesa din cele 7.
            ---------------------------------------------------------------------------*/

            vG_nrRand = vG_Rnd.Next(1, 8);//genereaza un nr random intre 1 si 7

            if (vG_nrRand == 1)
            {
                piesa = new Patrat();
                piesa.fP_PozInit(this);
            }
            else if (vG_nrRand == 2)
            {
                piesa = new Linie();
                piesa.fP_PozInit(this);
            }
            else if (vG_nrRand == 3)
            {
                piesa = new T();
                piesa.fP_PozInit(this);
            }
            else if (vG_nrRand == 4)
            {
                piesa = new L();
                piesa.fP_PozInit(this);
            }
            else if (vG_nrRand == 5)
            {
                piesa = new Patru();
                piesa.fP_PozInit(this);
            }
            else if (vG_nrRand == 6)
            {
                piesa = new J();
                piesa.fP_PozInit(this);
            }
            else
            {
                piesa = new PatruIntors();
                piesa.fP_PozInit(this);
            }
        }

        private void fG_timer1_Tick(object sender, EventArgs e)
        {

            piesa.fP_MutaJos(this);

            fG_DifficultyChanger();

            if (piesa.pP_StateOfPiece == false)//daca piesa a coborat 
            {
                tabel.fT_StergeLinieDacaECompleta(this, piesa);
            }

            fG_GameOver();

        }


        public void fG_DifficultyChanger()
        {
            /*---------------------------------------------------------------------------
                 DESCRIPTION: - in functie de scor, va creste viteza cu care vin piesele;
                                mai mult, va schimba si textul label-ului pentru nivelul
                                de dificultate
            ---------------------------------------------------------------------------*/

            if (vG_scor > 100)
            {
                timer1.Interval = 275;
                lblLevel.Text = "Basic";
            }
            if (vG_scor > 200)
            {
                timer1.Interval = 250;
                lblLevel.Text = "Intermediate";

            }
            if (vG_scor > 300)
            {
                timer1.Interval = 200;
                lblLevel.Text = "Advanced";

            }
            if (vG_scor > 400)
            {
                timer1.Interval = 175;
                lblLevel.Text = "Expert";
            }
            if (vG_scor > 500)
            {
                timer1.Interval = 150;
                lblLevel.Text = "No Pain, No Gain";
            }
            if (vG_scor > 600)
            {
                timer1.Interval = 135;
                lblLevel.Text = "Damn I'm Good";
            }
            if (vG_scor > 800)
            {
                timer1.Interval = 95;
                lblLevel.Text = "Hardcore";
            }
            if (vG_scor > 1000)
            {
                timer1.Interval = 50;
                lblLevel.Text = "Nightmare!";

            }
        }

        public void fG_GameOver()
        {
            if (tabel.fT_GameOver(this))
            {
                pG_CurrentScore = vG_scor;

                if (pG_CurrentScore >= lnc.HighScore)
                    lnc.HighScore = pG_CurrentScore;

                lnc.lblHighScore.Text = lnc.HighScore.ToString();


                timer1.Enabled = false;
                MessageBox.Show("GAME OVER \n Scorul dvs. este: " + vG_scor);
                this.Hide();
                lnc.Show();

            }
        }

        private void fG_game_KeyDown(object sender, KeyEventArgs e)
        {


            if (e.KeyCode == Keys.Right)
            {
                piesa.fP_MutaDreapta(this);
            }
            if (e.KeyCode == Keys.Left)
            {
                piesa.fP_MutaStanga(this);
            }
            if (e.KeyCode == Keys.Up)
            {
                piesa.fP_RotirePiesa(this);
            }
            if (e.KeyCode == Keys.Down)
            {
                piesa.fP_MutaJos(this);
            }
            if (e.KeyCode == Keys.Escape)
            {
                Hide();
                lnc.Show();
            }
        }


        private void fG_btnBack_Click(object sender, EventArgs e)
        {
            Hide();
            lnc.Show();
        }
        #endregion


    }
}
