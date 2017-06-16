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
    public partial class CharacterScreen : UserControl
    {
        public static int hero;
        public CharacterScreen()
        {
            InitializeComponent();
        }
      
        private void heroGreen_Click(object sender, EventArgs e)
        {
            hero = 1;
            acceptbutton.BackColor = Color.Green;
            characterLabel.ForeColor = Color.Green;
            characterLabel.Text = "Hero can move horizonatally \n\n aswell as vertically";
            errorLabel.Text = "";
        }

        private void heroRed_Click(object sender, EventArgs e)
        {
            hero = 2;
            acceptbutton.BackColor = Color.Green;
            characterLabel.ForeColor = Color.Red;
            characterLabel.Text = "Super Speed";
            errorLabel.Text = "";

        }

        private void heroYellow_Click(object sender, EventArgs e)
        {
            hero = 3;
            acceptbutton.BackColor = Color.Green;
            characterLabel.ForeColor = Color.Yellow;
            characterLabel.Text = "Slower Obstacles";
            errorLabel.Text = "";
        }
       

        private void acceptbutton_Click(object sender, EventArgs e)
        {
            if (hero == 0)
            {
                errorLabel.Text = "Error please choose a character";
            }
            if (hero == 1)
            {
                GameScreen.horizontal = true;
                Form f = this.FindForm();
                f.Controls.Remove(this);
                GameScreen gs = new GameScreen();
                f.Controls.Add(gs);
            }
            if (hero==2)
            {
                Form1.heroSpeed = Form1.heroSpeed + 5;
                Form f = this.FindForm();
                f.Controls.Remove(this);
                GameScreen gs = new GameScreen();
                f.Controls.Add(gs);
            }
            if (hero==3)
            {
                Form1.boxSpeed = Form1.boxSpeed - 2;
                Form f = this.FindForm();
                f.Controls.Remove(this);
                GameScreen gs = new GameScreen();
                f.Controls.Add(gs);
            }
            
        }
    }
}
