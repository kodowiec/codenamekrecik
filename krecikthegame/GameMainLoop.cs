using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace krecikthegame
{
    partial class Game
    {

        private void MovePlayer(Direction direction)
        {
            int newx, newy;
            switch (direction)
            {
                case Direction.Up:
                    newx = _currentboard.PlayerX;
                    newy = _currentboard.PlayerY - 1;
                    if (newx >= 0 && newy >= 0 && newx < _currentboard.Width && newy < _currentboard.Height && !_currentboard.IsCollidable(newx, newy))
                    {
                        _currentboard.prevPlayerX = _currentboard.PlayerX;
                        _currentboard.prevPlayerY = _currentboard.PlayerY;
                        _currentboard.PlayerY -= 1;
                    }
                    break;
                case Direction.Down:
                    newx = _currentboard.PlayerX;
                    newy = _currentboard.PlayerY + 1;
                    if (newx >= 0 && newy >= 0 && newx < _currentboard.Width && newy < _currentboard.Height && !_currentboard.IsCollidable(newx, newy))
                    {

                        _currentboard.prevPlayerX = _currentboard.PlayerX;
                        _currentboard.prevPlayerY = _currentboard.PlayerY;
                        _currentboard.PlayerY += 1;
                    }
                    break;
                case Direction.Left:
                    newx = _currentboard.PlayerX - 1;
                    newy = _currentboard.PlayerY;
                    if (newx >= 0 && newy >= 0 && newx < _currentboard.Width && newy < _currentboard.Height && !_currentboard.IsCollidable(newx, newy))
                    {

                        _currentboard.prevPlayerX = _currentboard.PlayerX;
                        _currentboard.prevPlayerY = _currentboard.PlayerY;
                        _currentboard.PlayerX -= 1;
                    }
                    break;
                case Direction.Right:
                    newx = _currentboard.PlayerX + 1;
                    newy = _currentboard.PlayerY;
                    if (newx >= 0 && newy >= 0 && newx < _currentboard.Width && newy < _currentboard.Height && !_currentboard.IsCollidable(newx, newy))
                    {
                        _currentboard.prevPlayerX = _currentboard.PlayerX;
                        _currentboard.prevPlayerY = _currentboard.PlayerY;
                        _currentboard.PlayerX += 1;
                    }
                    break;
                default:
                    break;
            }
            if (_currentboard.prevPlayerX != _currentboard.PlayerX || _currentboard.prevPlayerY != _currentboard.PlayerY) Update();
        }

        private void MainLoop()
        {
            while (true)
            {
                Console.CursorVisible = false;
                Console.ForegroundColor = Console.BackgroundColor;
                ConsoleKey pressed = Console.ReadKey().Key;
                switch ((int)pressed)
                {
                    case var value when value == settings.keymappings.MoveUp:
                        // player->move up
                        MovePlayer(Direction.Up);
                        break;
                    case var value when value == settings.keymappings.MoveDown:
                        // player->move down
                        MovePlayer(Direction.Down);
                        break;
                    case var value when value == settings.keymappings.MoveLeft:
                        // player->move left
                        MovePlayer(Direction.Left);
                        break;
                    case var value when value == settings.keymappings.MoveRight:
                        // player->move right
                        MovePlayer(Direction.Right);
                        break;
                    case var value when value == settings.keymappings.HideHUD:
                        // player->move right
                        this.showHUD =! this.showHUD;
                        Render(false);
                        break;
                    case var value when value == settings.keymappings.Inventory:
                        // player->move right
                        this.showInventory = !this.showInventory;
                        Render(false);
                        break;

                    case (int)ConsoleKey.M:
                        MagicZappingTest();
                        break;
                    case (int)ConsoleKey.F:
                        _currentboard.IsFogHere = !_currentboard.IsFogHere;
                        Render(false);
                        break;
                    case (int)ConsoleKey.L:
                        _currentboard.FlashlightTurnedOn = !_currentboard.FlashlightTurnedOn;
                        Render(false);
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
