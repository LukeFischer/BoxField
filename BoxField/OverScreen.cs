using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoxField
{
    public partial class OverScreen : UserControl
    {
        public OverScreen()
        {
            InitializeComponent();
            
            overLabel.Text = " You Lose";
            //scoreLabel.Text = "You last" + score + "seconds";
        }

        private void replayButton_Click(object sender, EventArgs e)
        {
            
            Form f = this.FindForm();
            f.Controls.Remove(this);
            GameScreen gs = new GameScreen();
            f.Controls.Add(gs);
            Refresh();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
