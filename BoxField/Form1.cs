using System;
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
        int randomCounter;
        Random randNum = new Random();
        public static int lives;
        public static int heroSpeed;
        public static int boxSpeed;
        public static int boxSize;

        public Form1()
        {
            InitializeComponent();
            GameScreen.horizontal = false;

            if (OptionScreen.difficulty ==0)
            {
                Form1.lives = 3;
                Form1.heroSpeed = 10;
                Form1.boxSpeed = 6;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Program goes directly to the GameScreen method on start
            MainMenu ms = new MainMenu();
            this.Controls.Add(ms);
        }

        private void sizeTimer_Tick(object sender, EventArgs e)
        {
            randomCounter++;
        }
    }
}
