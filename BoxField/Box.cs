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
        public void HeroMove()
        {
            y = y + speed;
        }
        public void Move(string direction)
        {
            if (direction == "left")
            {
                x = x - speed;
            }
            if (direction == "right")
            {
                x = x + speed;
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
        public Boolean Collision2(Obstacle bullets)
        {
            int boxSize, boxSpeed;

            boxSize = 1; 
            boxSpeed = 1;
            List<Obstacle> obstacles = new List<Obstacle>();
            Obstacle b = new Obstacle(100, 100, boxSize, boxSpeed);
            Rectangle boxRec = new Rectangle(b.x, b.y, b.size, b.size);
            Rectangle bulletRec = new Rectangle(bullets.x, bullets.y, bullets.size, bullets.size);

            return bulletRec.IntersectsWith(boxRec);
        }


    }
}
             
            
               
            
             