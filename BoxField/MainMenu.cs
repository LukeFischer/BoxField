﻿using System;
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
    public partial class MainMenu : UserControl
    {
        public MainMenu()
        {
            InitializeComponent();
            //Displays current date
             dateLabel.Text = DateTime.Now.ToString("dddd") + " " + DateTime.Now.ToString("dd-MM-yy");
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            //Goes to character screen
            Form f = this.FindForm();
            f.Controls.Remove(this);
            CharacterScreen cs = new CharacterScreen();
            f.Controls.Add(cs);
        }

        private void optionsButton_Click(object sender, EventArgs e)
        {
            //Goes to option screen
            Form f = this.FindForm();
            f.Controls.Remove(this);
            OptionScreen os = new OptionScreen();
            f.Controls.Add(os);
        }

        private void instructionScreen_Click(object sender, EventArgs e)
        {
            //Goes to instruction screen
            Form f = this.FindForm();
            f.Controls.Remove(this);
            InstructionScreen Is = new InstructionScreen();
            f.Controls.Add(Is);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Exits Game
            Application.Exit();
        }

        
    }
}
