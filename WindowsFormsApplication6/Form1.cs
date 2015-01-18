using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitTest
{
    public partial class frmGitTest : Form
    {
        public frmGitTest()
        {
            InitializeComponent();
        }

        private void btnKlik_Click(object sender, EventArgs e)
        {
            picFiguur.Visible = true;
        }

        private void picFiguur_Click(object sender, EventArgs e)
        {
            picFiguur.Visible = false;
            
        }
    }

}
