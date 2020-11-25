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

       // Game game;

        public Launcher()
        {
            InitializeComponent();
           // game = new Game(this); //puteam sa fac ca jocul sa ramana acelasi cand apas pe start
           //(nu sa fie unul nou de fiecare data)
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnStart1_Click(object sender, EventArgs e)
        {
            Game game = new Game(this);// de fiecare data cand se apasa start, se incepe un joc nou
            this.Hide();
            game.Show();
        }
    }
}
