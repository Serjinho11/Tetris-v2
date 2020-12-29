using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tetris
{
    public partial class Launcher : Form
    {


        private int highScore = 0;
        public int HighScore { get => highScore; set => highScore = value; }


        #region Metode
        public Launcher()
        {
            InitializeComponent();

            //am facut asta ca background-ul la astea doua sa fie transparent:
            lblHighScore.Parent = pictureBox1; 
            label1.Parent = pictureBox1;
        }



        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnStart1_Click(object sender, EventArgs e)
        {
            Game game = new Game(this);// de fiecare data cand se apasa start, se incepe un joc nou
            this.Hide();//this nu trebuia neaparat folosit
            game.Show();
        }

        private void btnInstructiuni_Click(object sender, EventArgs e)
        {
            Instructions instructions = new Instructions(this);
            Hide();
            instructions.Show();
        }

        private void btnResetHs_Click(object sender, EventArgs e)//pemtru a reseta highscore-ul
        {
            HighScore = 0;
            lblHighScore.Text = 0.ToString();
        }

        #endregion


    }
}
