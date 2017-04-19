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
using System.Media;


namespace BoxField
{
    public partial class GameScreen : UserControl
    {
        //player1 button control keys - DO NOT CHANGE
        Boolean leftArrowDown, downArrowDown, rightArrowDown, upArrowDown, bDown, nDown, mDown, spaceDown;

        Random randNum = new Random();

        //keep score
        public static int score;
        //Keep track of obstacles destroyed
        public static int destroyed;
        //used to draw boxes on screen
        int time;
        List<Obstacle> obstacles = new List<Obstacle>();
        List<Obstacle> bullets = new List<Obstacle>();
        List<Obstacle> stars = new List<Obstacle>();
        //box values
        int boxSize, boxSpeed, newBoxCounter;

        //heroValues
        Obstacle dino;
        int dinoSpeed;
        int dinoSize;

        //bullet values
        
        int bulletSpeed;
        int bulletSize;

        private void GameScreen_Click(object sender, EventArgs e)
        {
            bulletSpeed = 20;
            bulletSize = 10;
            Obstacle bullet = new Obstacle(dino.x, dino.y, bulletSize, bulletSpeed);
            bullets.Add(bullet);
            SoundPlayer player = new SoundPlayer(Properties.Resources.Shotgun);
            player.Play();
        }

        public GameScreen()
        {
            InitializeComponent();
            OnStart();
        }

        /// <summary>
        /// Set initial game values here
        /// </summary>
        public void OnStart()
        {
            //Set starting values
            boxSpeed = 6;
            newBoxCounter = 0;
            int rand = randNum.Next(1, 50);
            boxSize = rand;
            Obstacle b = new Obstacle(100, 500, boxSize, boxSpeed);
            obstacles.Add(b);
            rand = 0;

            //set hero values
            dinoSpeed = 10;
            dinoSize = 20;
            dino = new Obstacle(10, 400, dinoSize, dinoSpeed);

         }

        private void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            //player 1 button presses
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = true;
                    break;
                case Keys.Down:
                    downArrowDown = true;
                    break;
                case Keys.Right:
                    rightArrowDown = true;
                    break;
                case Keys.Up:
                    upArrowDown = true;
                    break;
                case Keys.B:
                    bDown = true;
                    break;
                case Keys.N:
                    nDown = true;
                    break;
                case Keys.M:
                    mDown = true;
                    break;
                case Keys.Space:
                    spaceDown = true;
                    break;
                default:
                    break;
            }
        }

        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            //player 1 button releases
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = false;
                    break;
                case Keys.Down:
                    downArrowDown = false;
                    break;
                case Keys.Right:
                    rightArrowDown = false;
                    break;
                case Keys.Up:
                    upArrowDown = false;
                    break;
                case Keys.B:
                    bDown = false;
                    break;
                case Keys.N:
                    nDown = false;
                    break;
                case Keys.M:
                    mDown = false;
                    break;
                case Keys.Space:
                    spaceDown = false;
                    break;
                default:
                    break;
            }
        }

        private void gameLoop_Tick(object sender, EventArgs e)
        {
            #region  update location of all boxes 
            foreach (Obstacle b in obstacles)
            {
                b.BoxMove();
            }

            #endregion

            #region add new box if it is time
            newBoxCounter++;
            score++;
            time++;
            timeLabel.Text = Convert.ToString(time) + " " + "Milliseconds";
            gsdestroyedLabel.Text = Convert.ToString(destroyed) + " " + "Objects Destroyed";

            if (newBoxCounter == 5)
            {
                int rand = randNum.Next(1, 500);
                int boxRand = randNum.Next(10, 50);

                Obstacle b = new Obstacle(900, rand, boxRand, boxSpeed);
                obstacles.Add(b);

                newBoxCounter = 0;
            }

            #endregion

            #region Remove boxes off the screen
            if (obstacles[0].y > this.Width)

            {
                obstacles.RemoveAt(0);
            }
            #endregion

            #region move hero
            if (leftArrowDown == true)
            {
                dino.Move("left");
            }
            if (rightArrowDown == true)
            {
                dino.Move("right");
            }
            if (upArrowDown)
            {
                dino.Move("up");
            }
            if (downArrowDown)
            {
                dino.Move("down");
            }

            #endregion

            #region Check for collision between hero and obstacles
            foreach (Obstacle b in obstacles)
            {
                Boolean hasCollided = false;
                hasCollided = dino.Collision(b);

                if (hasCollided == true)
                {
                    SoundPlayer player = new SoundPlayer(Properties.Resources.Bomb);
                    player.Play();
                    Thread.Sleep(1000);
                    gameLoop.Stop();

                    Form f = this.FindForm();
                    f.Controls.Remove(this);
                    OverScreen os = new OverScreen();
                    f.Controls.Add(os);
                }
            

                #endregion
                foreach (Obstacle bullet in bullets)
                {
                    Boolean hasCollided2 = false;
                    hasCollided2 = bullet.Collision2(bullet, b);

                    if (hasCollided2 == true)
                    {
                        
                        obstacles.Remove(b);
                        bullets.Remove(bullet);
                        destroyed++;
                        return;
                    }
                }
            }

        
            #region move bullets

            foreach (Obstacle b in bullets)
            {
                b.bulletMove();
            }

            #endregion
            Refresh();
        }
        

        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            //  draw boxes to screen
            foreach (Obstacle b in obstacles)
            { 
                    SolidBrush boxBrush = new SolidBrush(Color.Red);
                    e.Graphics.FillRectangle(boxBrush, b.x, b.y, b.size, b.size);
                    
            }
            foreach(Obstacle bullet in bullets)
            {
                SolidBrush bulletBrush = new SolidBrush(Color.Gray);
                e.Graphics.FillRectangle(bulletBrush, bullet.x, bullet.y, bullet.size, bullet.size);
            }    
            
            SolidBrush dinoBrush = new SolidBrush(Color.Gold);
            e.Graphics.FillEllipse(dinoBrush, dino.x, dino.y, dino.size, dino.size);

         }
    }
}
