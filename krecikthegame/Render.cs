using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace krecikthegame
{
    partial class Game 
    {
        private void FullRender()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            for (int x = 0; x < _currentboard.Width; x++)
            {
                for (int y = 0; y < _currentboard.Height; y++)
                {
                    if (_currentboard.PlayerX == x && _currentboard.PlayerY == y)
                    {
                        RenderPlayer();

                    }
                    else if (_currentboard.BoardObjects[x,y] != null)
                    {
                        Console.ForegroundColor = _currentboard.BoardObjects[x,y].DrawColor;
                        KCU.ConsoleToolkit.WriteAt(_currentboard.BoardObjects[x, y].Display, x, y);
                    }
                    
                }
            }
        }
        public void Render(bool partial = true)
        {
            // draw interface
            if (!partial)
            {
                Console.Clear();
                if(!_currentboard.IsFogHere) FullRender();
                RenderWithFog();
                return;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Black;
                KCU.ConsoleToolkit.WriteAt(KCU.Characters.whitespace.ToString(), _currentboard.prevPlayerX, _currentboard.prevPlayerY);
                RenderWithFog();
            }
            if (this.showHUD) UI.DrawInterface(ConsoleColor.White, ConsoleColor.Black, ConsoleColor.Green, ConsoleColor.Yellow, ConsoleColor.Gray);
        }

        public void RenderWithFog()
        {
            for (int cx = -1; cx < 2; cx++)
            {
                for (int cy = -1; cy < 2 ; cy++)
                {
                    int x = _currentboard.PlayerX + cx;
                    int y = _currentboard.PlayerY + cy;
                    if (_currentboard.PlayerX == x && _currentboard.PlayerY == y)
                    {
                        RenderPlayer();
                    }

                    else if (x < _currentboard.Width && y < _currentboard.Height && x >= 0 && y>= 0)
                    {
                        if (_currentboard.BoardObjects[x, y] != null)
                        {
                            Console.ForegroundColor = _currentboard.BoardObjects[x, y].DrawColor;
                            KCU.ConsoleToolkit.WriteAt(_currentboard.BoardObjects[x, y].Display, x, y);
                        }
                        else
                        {
                            //if player has torch
                            if(_currentboard.FlashlightTurnedOn)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                KCU.ConsoleToolkit.WriteAt("∙", x, y);
                            }
                            // 
                            // 

                        }
                    }

                }
            }
        }

        public void RenderPlayer()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            KCU.ConsoleToolkit.WriteAt(KCU.Characters.player.ToString(), _currentboard.PlayerX, _currentboard.PlayerY);
        }
    }
}
