using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace krecikthegame
{
    enum Direction
    {
        Up,
        Down,
        Left,
        Right
    }
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
    partial class Game
    {
        private void MagicZappingTest()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.CursorVisible = false;
            Console.Clear();
            KCU.ConsoleToolkit.WriteAt("Select a direction to make a zap", 2, Console.WindowHeight - 2);
            int playerx = 38;
            int playery = 22;
            Console.ForegroundColor = ConsoleColor.Yellow;
            KCU.ConsoleToolkit.WriteAt("☻", playerx, playery);
            Console.ForegroundColor = ConsoleColor.Cyan;
            KCU.ConsoleToolkit.WriteAt("↑", playerx, playery - 1);
            KCU.ConsoleToolkit.WriteAt("↓", playerx, playery + 1);
            KCU.ConsoleToolkit.WriteAt("←", playerx - 1, playery);
            KCU.ConsoleToolkit.WriteAt("→", playerx + 1, playery);

            ConsoleKey read = Console.ReadKey().Key;
                switch(read)
                {
                    case ConsoleKey.UpArrow:
                        Zap(Direction.Up, playerx, playery-1);
                        break;
                    case ConsoleKey.DownArrow:
                        Zap(Direction.Down, playerx, playery+1);
                        break;
                    case ConsoleKey.LeftArrow:
                        Zap(Direction.Left, playerx-1, playery);
                        break;
                    case ConsoleKey.RightArrow:
                        Zap(Direction.Right, playerx+1, playery);
                        break;
                    default:
                        break;
                }
            MagicZappingTest();

        }

        private void Zap(Direction dir, int x, int y)
            {
            Bullet? bullet = new Bullet(x, y, dir, 5);
            while (bullet.exists)
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                KCU.ConsoleToolkit.WriteAt(" ", bullet.x, bullet.y);
                bullet.Move();
                if(bullet.exists) KCU.ConsoleToolkit.WriteAt("◊", bullet.x, bullet.y);
                else KCU.ConsoleToolkit.WriteAt(" ", bullet.x, bullet.y);
                System.Threading.Thread.Sleep(50);
            }
            bullet = null;
            }
        public void Render()
        {
            // draw interface
            // 
            //throw new NotImplementedException();

            MapReader mr = new MapReader();
            mr.ReadFile("image.png");
            for (int x = 0; x < mr.lastwidth; x++)
            {
                for (int y = 0; y < mr.lastheight; y++)
                {
                    Console.BackgroundColor = mr.colors[x, y];
                    Console.ForegroundColor = Console.BackgroundColor;
                    //KCU.ConsoleToolkit.WriteAt(" ", x, y);
                }
            }
            Console.ReadKey();
        }
    }
}
