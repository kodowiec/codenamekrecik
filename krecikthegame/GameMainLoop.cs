using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace krecikthegame
{
    partial class Game
    {
        private void MainLoop()
        {
            while(true)
            {
                ConsoleKey pressed = Console.ReadKey().Key;
                switch (pressed)
                {
                    case ConsoleKey.UpArrow: //replace with settings mapping
                        // player->move
                        break;
                    case ConsoleKey.DownArrow: //replace with settings mapping
                        // player->move
                        break;
                    case ConsoleKey.LeftArrow: //replace with settings mapping
                        // player->move
                        break;
                    case ConsoleKey.RightArrow: //replace with settings mapping
                        // player->move
                        break;
                    case ConsoleKey.M:
                        MagicZappingTest();
                        break;
                    case ConsoleKey.R:
                        Render();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
