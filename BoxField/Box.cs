using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BoxField
{
    class Obstacle
    {
      
        public int x, y, size, speed;
        
        public Obstacle(int _x, int _y, int _size, int _speed)
        {
            x = _x;
            y = _y;
            size = _size;
            speed = _speed;
            

        }

        
        public void BoxMove()
        {
            x = x - speed;
        }
        public void bulletMove()
        {
            
                x = x + speed;
            
        }
        public void powerMove()
        {
            y = y + speed;
        }
        public void fastBullets()
        {
            if (GameScreen.active == true)
            {
                x = x + speed * 2;
            }
        }
        public void smallBoxes()
        {
            if (GameScreen.cluster == true)
            {
                x = x - speed * 2;
            }
        }

        public void HeroMove()
        {
            y = y + speed;
        }
        public void Move(string direction)
        {
            if (GameScreen.horizontal == true)
            {
                if (direction == "left")
                {
                    x = x - speed;
                }
                if (direction == "right")
                {
                    x = x + speed;
                }
            }
            if (direction == "up")
            {
                y = y - speed;
            }
            if (direction == "down")
            {
                y = y + speed;
            }
        }

        public Boolean Collision(Obstacle b)
        {
            Rectangle boxRec = new Rectangle(b.x, b.y, b.size, b.size);
            Rectangle heroRec = new Rectangle(x, y, size, size);

            return boxRec.IntersectsWith(heroRec);
        }
        public Boolean Collision2(Obstacle bullet, Obstacle b)
        {
            
            Rectangle boxRec = new Rectangle(b.x, b.y, b.size, b.size);
            Rectangle bulletRec = new Rectangle(bullet.x, bullet.y, bullet.size, bullet.size);

            return bulletRec.IntersectsWith(boxRec);
        }


    }
}
             
            
               
            
             