﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoxField
{
    public partial class Form1 : Form
    {
        //Create integers for to use in the gamescreen
        public static int lives;
        public static int heroSpeed;
        public static int boxSpeed;
        public static int boxSize;
        public static int ammo; 
        public Form1()
        {
            InitializeComponent();
           
            //Boolean for green character power
            GameScreen.horizontal = false;
            //Default difficulty values
            if (OptionScreen.difficulty ==0)
            {
                Form1.lives = 3;
                Form1.heroSpeed = 10;
                Form1.boxSpeed = 6;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Goes to main menu
            MainMenu ms = new MainMenu();
            this.Controls.Add(ms);
        }

        


    }
}
