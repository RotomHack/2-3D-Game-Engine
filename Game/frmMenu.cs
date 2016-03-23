using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Engine
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            frmTitle Title = new frmTitle();
            Title.ShowDialog();
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void frmMenu_Click(object sender, EventArgs e)
        {
          
        }

        private void bnNewGame_Click(object sender, EventArgs e)
        {
            frmGame Game = new frmGame();
            if (Game.ShowDialog() == System.Windows.Forms.DialogResult.Yes)
            {
                frmGameComplete Complete = new frmGameComplete();
                Complete.ShowDialog();
            }
            else
            {
                frmGameOver Over = new frmGameOver();
                    Over.ShowDialog();
            }
        }

        private void bnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
