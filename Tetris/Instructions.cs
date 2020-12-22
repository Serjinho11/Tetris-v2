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
    public partial class Instructions : Form
    {
        Launcher lnc;
        public Instructions(Launcher launcher)
        {


            InitializeComponent();
            lnc = launcher;
        }

        private void instrBtnBack_Click(object sender, EventArgs e)
        {
            Hide();
            lnc.Show();
        }
    }
}
