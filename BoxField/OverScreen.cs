using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace BoxField
{
    public partial class OverScreen : UserControl
    {
        public OverScreen()
        {
            InitializeComponent();

            //Creates text on screen
            overLabel.Text = " You Lose";
            GameScreen.score = GameScreen.score / 60;
            scoreLabel.Text = "You lasted" + " " + GameScreen.score + " " + "seconds";
            destroyedLabel.Text = "You destroyed" + " " + GameScreen.destroyed + " " + "objects";
            totalScore.Text = "Your total score is" + " " + GameScreen.score + " " + " X " + GameScreen.destroyed + "=" + " " + GameScreen.score * GameScreen.destroyed;
        }

        private void replayButton_Click(object sender, EventArgs e)
        {
            //Reset destroyed value
            GameScreen.destroyed = 0;
            //Go to Gamescreen
            Form f = this.FindForm();
            f.Controls.Remove(this);
            GameScreen gs = new GameScreen();
            f.Controls.Add(gs);
            Refresh();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Exit game
            Application.Exit();
        }
    }
}

        
    

