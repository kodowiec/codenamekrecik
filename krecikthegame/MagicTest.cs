using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace krecikthegame
{
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
            switch (read)
            {
                case ConsoleKey.UpArrow:
                    Zap(Direction.Up, playerx, playery - 1);
                    break;
                case ConsoleKey.DownArrow:
                    Zap(Direction.Down, playerx, playery + 1);
                    break;
                case ConsoleKey.LeftArrow:
                    Zap(Direction.Left, playerx - 1, playery);
                    break;
                case ConsoleKey.RightArrow:
                    Zap(Direction.Right, playerx + 1, playery);
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
                if (bullet.exists) KCU.ConsoleToolkit.WriteAt("◊", bullet.x, bullet.y);
                else KCU.ConsoleToolkit.WriteAt(" ", bullet.x, bullet.y);
                System.Threading.Thread.Sleep(50);
            }
            bullet = null;
        }
    }
}
