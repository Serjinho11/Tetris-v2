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



        public int[,] matrice = new int[12, 22]; // toate elementele sunt initializate cu 0



        Random rd = new Random();

        int nrRand;

        public Game(Launcher launcher)
        {

            InitializeComponent();
            lnc = launcher;

            drawTableBorder();
        }

        public Game() { }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            lnc.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            piesa.mutaJos(this);

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            generarePiesaRandom();
            piesa.pozInit(this);
            timer1.Start();

        }



        public void generarePiesaRandom()
        {

            nrRand = rd.Next(1, 6);//genereaza un nr random intre 1 si 5

            if (nrRand == 1)
            {
                piesa = new Patrat();
                piesa.pozInit(this);
            }
            else if (nrRand == 2)
            {
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
                piesa = new L();
                piesa.pozInit(this);
            }
            else
            {
                piesa = new Patru();
                piesa.pozInit(this);
            }
        }

        public void drawTableBorder()
        {
            //pt partea de jos si sus:
            for (int i = 0; i < 12; i++)
            {
                matrice[i, 21] = 1;
                tableLayoutPanel1.GetControlFromPosition(i, 21).BackColor = Color.DarkGreen;
                matrice[i, 0] = 1;
                tableLayoutPanel1.GetControlFromPosition(i, 0).BackColor = Color.DarkGreen;

            }


            // pt partea din stanga si dreapta
            for (int i = 0; i < 21; i++)
            {
                matrice[0, i] = 1;
                tableLayoutPanel1.GetControlFromPosition(0, i).BackColor = Color.DarkGreen;

                matrice[11, i] = 1;
                tableLayoutPanel1.GetControlFromPosition(11, i).BackColor = Color.DarkGreen;


            }
        }

        private void Game_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Right)
            {
                piesa.mutaDreapta(this);
            }
        }

        private void btnStanga_Click(object sender, EventArgs e)
        {
            piesa.mutaStanga(this);
        }

        private void btnDreapta_Click(object sender, EventArgs e)
        {
            piesa.mutaDreapta(this);
        }
    }
}
