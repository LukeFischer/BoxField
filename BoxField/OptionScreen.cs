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
    public partial class OptionScreen : UserControl
    {
        //Creates random sizes and speeds of boxes compared to difficulty
        int randomCounter;
        //Variable to track difficulty
        public static int difficulty;
        //Random number generator
        Random randNum = new Random();
        public OptionScreen()
        {
            InitializeComponent();
            //Initail values
            mediumButton.BackColor = Color.Orange;
            difficultyLabel.Text = " - 3 Lives \n\n\n -Moderate hero speed \n\n\n -Moderate box size \n\n\n -Moderate box speed";
            difficultyLabel.ForeColor = Color.Orange;
            acceptLabel.Text = "Click 'Accept' when done!";
        }

        private void easyButton_Click(object sender, EventArgs e)
        {
            //Easy values
            difficulty = 1;
            if (randomCounter == 5)
            {
                int easyRand = randNum.Next(1, 25);
                Form1.boxSize = easyRand;
            }
            Form1.lives = 5;
            Form1.heroSpeed = 15;
          
            Form1.boxSpeed = 3;
            //Displays difficulty attributes 
            difficultyLabel.Text = " -5 Lives \n\n\n -Faster hero speed \n\n\n -Smaller boxes \n\n\n -Slower boxes";
            //When not selected all other boxes will appear white
            difficultyLabel.ForeColor = Color.Yellow;
            easyButton.BackColor = Color.Yellow;
            mediumButton.BackColor = Color.White;
            hardButton.BackColor = Color.White;
            impossibleButton.BackColor = Color.White;
            randomCounter = 0;
        }

        private void mediumButton_Click(object sender, EventArgs e)
        {
            //medium values
            difficulty = 2;
            int mediumRand = randNum.Next(1, 50);
            Form1.lives = 3;
            Form1.heroSpeed = 10;
            Form1.boxSize = mediumRand;
            Form1.boxSpeed = 6;
            difficultyLabel.Text = " - 3 Lives \n\n\n -Moderate hero speed \n\n\n -Moderate box size \n\n\n -Moderate box speed";
            difficultyLabel.ForeColor = Color.Orange;
            easyButton.BackColor = Color.White;
            mediumButton.BackColor = Color.Orange;
            hardButton.BackColor = Color.White;
            impossibleButton.BackColor = Color.White;
        }

        private void hardButton_Click(object sender, EventArgs e)
        {
            //Hard values
            difficulty = 3;
            int hardRand = randNum.Next(1, 75);
            Form1.lives = 2;
            Form1.heroSpeed = 6;
            Form1.boxSize = hardRand;
            Form1.boxSpeed = 9;
            difficultyLabel.Text = " - 2 Lives \n\n\n -Slow hero speed \n\n\n -Fast boxes \n\n\n -Big boxes";
            difficultyLabel.ForeColor = Color.Red;
            easyButton.BackColor = Color.White;
            mediumButton.BackColor = Color.White;
            hardButton.BackColor = Color.Red;
            impossibleButton.BackColor = Color.White;
        }

        private void impossibleButton_Click(object sender, EventArgs e)
        {
            //impossible values
            difficulty = 4;
            int impossibleRand = randNum.Next(1, 100);
            Form1.lives = 1;
            Form1.heroSpeed = 4;
            Form1.boxSize = impossibleRand;
            Form1.boxSpeed = 12;
            difficultyLabel.Text = " -1 Life \n\n\n -Slowest hero speed \n\n\n -Biggest boxes \n\n\n -Fastest boxes";
            difficultyLabel.ForeColor = Color.Purple;
            easyButton.BackColor = Color.White;
            mediumButton.BackColor = Color.White;
            hardButton.BackColor = Color.White;
            impossibleButton.BackColor = Color.Purple;
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            //Go to main menu
            Form f = this.FindForm();
            f.Controls.Remove(this);
            MainMenu ms = new MainMenu();
            f.Controls.Add(ms);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Timer tick for box size and speed
            randomCounter++;
        }
    }
}
