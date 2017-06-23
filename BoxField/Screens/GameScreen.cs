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
       
        //Create a random number generator
        Random randNum = new Random();
        
        //Booleans to launch and stop functions
        public static bool active;
        public static bool invincible;
        public static bool horizontal;
        public static bool cluster;
        public static bool pause;
        
        //keep score
        public static int score;
        
        //Keep track of obstacles destroyed
        public static int destroyed;
        
        //keep track of how much ammo the player has
        int ammo;
        
        //Various variables for timer use and tracking
        int time;
        int ammoTime;
        int pfastTime;
        
        //Lists to track obstacles and bullets
        List<Obstacle> obstacles = new List<Obstacle>();
        List<Obstacle> bullets = new List<Obstacle>();
        
        //Set size of hero
        int heroSize;
        int pause1;
      
        //box values
        int newBoxCounter, topBoundary, bottomBoundary;
        //Track boundary time
        int countdown = 3;
        
        //heroValues
        Obstacle dino;

        //bullet values
        
        public static int bulletSpeed;
        int bulletSize;

        private void GameScreen_Click(object sender, EventArgs e)
        {
           //Hide pause label and stop pause function
            pauseLabel.Visible = false;
            pause = false;
            
            //Start game
            gameLoop.Start();

            //Subtract one from ammo if clicked
            if (ammo > 0)
            {
                ammo--;
            }
            
            //Set bullet values
            bulletSpeed = 20;
            bulletSize = 10;

            //Only create a new bullet if bullets are more than 0
            if (ammo > 0)
            {
                Obstacle bullet = new Obstacle(dino.x, dino.y, bulletSize, bulletSpeed);
                bullets.Add(bullet);
            }

            //Bullet audio
            SoundPlayer player = new SoundPlayer(Properties.Resources.Shotgun);
            player.Play();
            
        }

        public GameScreen()
        {
            //Setting booleans to false
            InitializeComponent();
            OnStart();
            active = false;
            invincible = false;
            cluster = false;
            pfastLabel.Visible = false;
            penentratingLabel.Visible = false;
            clusterLabel.Visible = false;
            pauseLabel.Visible = false;
        }

        /// <summary>
        /// Set initial game values here
        /// </summary>
        public void OnStart()
        {
            //Set starting values
            ammo = 10;
            
            newBoxCounter = 0;
            int rand = randNum.Next(1, 50);
         
            Obstacle b = new Obstacle(100, 500, rand, Form1.boxSize);
            obstacles.Add(b);
            rand = 0;

            //set hero values
           
            heroSize = 20;
            dino = new Obstacle(10, 400, heroSize, Form1.heroSpeed);

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
                    pause = true;
                    
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
                if (time > 1000)
                {
                    //if time is greater than 1000 activate cluster and its label
                    cluster = true;
                    penentratingLabel.Text = "";
                    clusterLabel.Visible = true;
                }
                //Move box function
                b.BoxMove();

                //Activate fast boxes
                b.smallBoxes();
            }
            //Making the pause function by pressing space bar
            if (pause==true)
            {
                gameLoop.Stop();
                pauseLabel.Visible = true;
            }
            if (pause1==2)
            {
                pause = false;
                
            }
            #endregion

            #region add new box if it is time
            //Setting boundary
            if (dino.y > 500 || dino.y == 500)
            {
                
                boundaryLabel.Text = "RETURN IN " + countdown+ " SECONDS OR DIE";
                bottomBoundary++;
               

                if (bottomBoundary == 60)
                {

                    countdown = 2;
                }
                if (bottomBoundary== 120)
                {
                    countdown = 1;
                }
                if (bottomBoundary == 180)
                {
                    countdown = 3;
                }

            }
            if (dino.y < 0 || dino.y == 0)
            {
                boundaryLabel.Text = "RETURN IN " + countdown+ " SECONDS OR DIE";
                topBoundary++;
                

                if (topBoundary == 60)
                {
                    countdown = 2;
                }
                if (topBoundary == 120)
                {
                    countdown = 1;
                }
                if (topBoundary == 180)
                {
                    countdown = 3;
                   
                }

            }
            //reset boundary time values if you return back to the screen
            if (dino.y > 0 && dino.y < 500)
            {

                boundaryLabel.Text = "";
                topBoundary = 0;
                bottomBoundary = 0;
                countdown = 3;
            }

            //if player destroys more than 10 obstacles launch fast bullet function
            if (destroyed >10)
            {
                pfastTime++;
            }

            //Start timers
            newBoxCounter++;
            score++;
            time++;
            ammoTime++;
            
            //Display score, objects destroyed and bullets left
            timeLabel.Text = Convert.ToString(time) + " " + "score";
            gsdestroyedLabel.Text = Convert.ToString(destroyed) + " " + "Objects Destroyed";
            ammoLabel.Text = Convert.ToString(ammo) + " " + "bullets left";

            //After every 200 score add 10 bullets 
            if (ammoTime==200)
            {
                ammo = ammo + 10;
                ammoTime = 0;
                SoundPlayer player = new SoundPlayer(Properties.Resources.Reload1);
                player.Play();
            }
            //If timer =5 add 1 box
            if (newBoxCounter == 5)
            {
                 
                int rand = randNum.Next(1, 500);
                int boxRand = randNum.Next(10, 50);
                

                Obstacle b = new Obstacle(900, rand, boxRand, Form1.boxSpeed);
                obstacles.Add(b);

                //reset timer
                newBoxCounter = 0;
            }

            #endregion

            #region Remove boxes off the screen
            //Remove boxes once off the screen
            if (obstacles[0].y > this.Width)

            {
                obstacles.RemoveAt(0);
            }

            //If player has been out of bound for 3 seconds stop gameLoop and proceed to game over screen
            if (bottomBoundary == 180)
            {
                countdown = 3;
                Form f = this.FindForm();
                f.Controls.Remove(this);
                OverScreen os = new OverScreen();
                f.Controls.Add(os);
                gameLoop.Stop();
                
            }
            if (topBoundary==180)
            {
                countdown = 3;

                Form f = this.FindForm();
                f.Controls.Remove(this);
                OverScreen os = new OverScreen();
                f.Controls.Add(os);
                gameLoop.Stop();

            }
            
            #endregion

            #region move hero
            //Hero movement values
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
            //Colision functions
            foreach (Obstacle b in obstacles)
            {
                Boolean hasCollided = false;
                hasCollided = dino.Collision(b);

                //If player collides with object go to game over screen
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
                    //if bullet hits object, remove  object
                    Boolean hasCollided2 = false;
                    hasCollided2 = bullet.Collision2(bullet, b);

                    if (hasCollided2 == true)
                    {
                        //Add a bullet everytime you destroy an obstacle
                        ammo++;
                        obstacles.Remove(b);
                        
                        //Remove bullet as well if the penetrating bullets function is false
                        if (invincible == false)
                        {
                            bullets.Remove(bullet);
                        }
                        //Add one to destroyed integer
                        destroyed++;
                        return;
                    }
                    
                }
            }

        
            #region move bullets

            foreach (Obstacle b in bullets)
            {
                //Bullet moves
                b.bulletMove();

                //If destroyed is greater than  10 launch fast bullets method for 100 ticks
                if (destroyed >= 10)
                {
                    if (pfastTime < 100)
                    {
                        active = true;
                        b.fastBullets();
                        pfastLabel.Visible = true;
                    }
                   
                    
                    //After 100 ticks launch penetrating bullets function
                    if (pfastTime>=100)
                    {

                        pfastLabel.Visible = false; 
                        pfastLabel.Text = "";
                        penentratingLabel.Visible = true;
                        active = false;
                        invincible = true;
                    }

                    
                    
                    
                    
                }
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
            foreach (Obstacle bullet in bullets)
            {
                SolidBrush bulletBrush = new SolidBrush(Color.Gray);
                e.Graphics.FillRectangle(bulletBrush, bullet.x, bullet.y, bullet.size, bullet.size);
            }



            //Draw hero on the screen
            if (CharacterScreen.hero == 1)
            {
                SolidBrush dinoBrush = new SolidBrush(Color.Green);
                e.Graphics.FillEllipse(dinoBrush, dino.x, dino.y, dino.size, dino.size);
            }
            if (CharacterScreen.hero == 2)
            {
                SolidBrush dinoBrush = new SolidBrush(Color.Red);
                e.Graphics.FillEllipse(dinoBrush, dino.x, dino.y, dino.size, dino.size);
            }
            if (CharacterScreen.hero == 3)
            {
                SolidBrush dinoBrush = new SolidBrush(Color.Yellow);
                e.Graphics.FillEllipse(dinoBrush, dino.x, dino.y, dino.size, dino.size);
            }

            
        }
    }
}
