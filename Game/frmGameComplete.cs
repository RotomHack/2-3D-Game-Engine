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
    public partial class frmGameComplete : Form
    {
        public frmGameComplete()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmGameComplete_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
