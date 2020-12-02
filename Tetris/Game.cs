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



        public int[,] matrice = new int[10, 20]; // toate elementele sunt initializate cu 0



        Random rd = new Random();

        int nrRand;

        public Game(Launcher launcher)
        {

            InitializeComponent();
            lnc = launcher;

            // sfarsitTabla(); - nu o mai folosesc
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

            
            lblVerifMat.Text = Convert.ToString(matrice[5, 0]);

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

        public void sfarsitTabla()
        {//asta nu ne mai trebuie momentan
            tableLayoutPanel1.GetControlFromPosition(0, 19).BackColor = Color.Red;
            tableLayoutPanel1.GetControlFromPosition(1, 19).BackColor = Color.Red;
            tableLayoutPanel1.GetControlFromPosition(2, 19).BackColor = Color.Red;
            tableLayoutPanel1.GetControlFromPosition(3, 19).BackColor = Color.Red;
            tableLayoutPanel1.GetControlFromPosition(4, 19).BackColor = Color.Red;
            tableLayoutPanel1.GetControlFromPosition(5, 19).BackColor = Color.Red;
            tableLayoutPanel1.GetControlFromPosition(6, 19).BackColor = Color.Red;
            tableLayoutPanel1.GetControlFromPosition(7, 19).BackColor = Color.Red;
            tableLayoutPanel1.GetControlFromPosition(8, 19).BackColor = Color.Red;
            tableLayoutPanel1.GetControlFromPosition(9, 19).BackColor = Color.Red;
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
