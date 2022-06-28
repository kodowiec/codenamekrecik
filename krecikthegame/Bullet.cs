using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace krecikthegame
{

    class Bullet
    {
        public int startx;
        public int starty;
        public Direction direction;
        public int x;
        public int y;
        public int distance;
        public bool exists;

        public Bullet(int startx, int starty, Direction direction, int distance)
        {
            this.startx = startx;
            this.starty = starty;
            this.x = startx;
            this.y = starty;
            this.direction = direction;
            this.distance = distance;
            this.exists = true;
        }

        public int DistanceDiffer()
        {
            int ret = 0;
            if (direction == Direction.Up) ret = starty - y;
            if (direction == Direction.Down) ret = y - starty;
            if (direction == Direction.Left) ret = startx - x;
            if (direction == Direction.Right) ret = x - startx;
            return ret;
        }

        public bool ShouldExist()
        {
            if (DistanceDiffer() > distance) return false;
            else return true;
        }

        public void Move()
        {
            if (!ShouldExist())
            {
                this.exists = false;
                return;
            }
            switch (direction)
            {
                case Direction.Up:
                    y -= 1;
                    break;
                case Direction.Down:
                    y += 1;
                    break;
                case Direction.Left:
                    x -= 1;
                    break;
                case Direction.Right:
                    x += 1;
                    break;
                default:
                    break;
            }
        }
    }
}
