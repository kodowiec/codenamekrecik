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
                switch ((int) pressed)
                {
                    case var value when value == settings.keymappings.MoveUp:
                        // player->move up
                        break;
                    case var value when value == settings.keymappings.MoveDown:
                        // player->move down
                        break;
                    case var value when value == settings.keymappings.MoveLeft:
                        // player->move left
                        break;
                    case var value when value == settings.keymappings.MoveRight:
                        // player->move right
                        break;
                    case (int)ConsoleKey.M:
                        MagicZappingTest();
                        break;
                    case (int)ConsoleKey.R:
                        Render();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
