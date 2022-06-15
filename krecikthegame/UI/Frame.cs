using System;
namespace krecikthegame
{
    public partial class UI : IUI
    {
        public static void DrawFrame(int width, int height, ConsoleColor frameColor, ConsoleColor backgroundColor, int x = 0, int y = 0)
        {
            // we could probably optimize it quite a bit more

            //╔═══╗
            //║   ║
            //╠═══╣
            //╚═══╝
            ConsoleColor prevfg = Console.ForegroundColor;
            ConsoleColor prevbg = Console.BackgroundColor;
            Console.ForegroundColor = frameColor;
            Console.BackgroundColor = backgroundColor;
            //corners
            Console.SetCursorPosition(x, y);
            KCU.ConsoleToolkit.WriteAt(KCU.Characters.BoxDrawing.Corners.TopLeft.ToString(), x, y);
            KCU.ConsoleToolkit.WriteAt(KCU.Characters.BoxDrawing.Corners.TopRight.ToString(), x + width - 1, y);
            KCU.ConsoleToolkit.WriteAt(KCU.Characters.BoxDrawing.Corners.BottomLeft.ToString(), x, y + height - 1);
            KCU.ConsoleToolkit.WriteAt(KCU.Characters.BoxDrawing.Corners.BottomRight.ToString(), x + width - 1, y + height - 1);

            for (int i = x+1; i < x + width - 1; i++)
            {
                KCU.ConsoleToolkit.WriteAt(KCU.Characters.BoxDrawing.Walls.Horizontal.ToString(), i, y);
                KCU.ConsoleToolkit.WriteAt(KCU.Characters.BoxDrawing.Walls.Horizontal.ToString(), i, y + height - 1);
            }

            for (int i = y+1; i < y + height - 1; i++)
            {
                KCU.ConsoleToolkit.WriteAt(KCU.Characters.BoxDrawing.Walls.Vertical.ToString(), x, i);
                KCU.ConsoleToolkit.WriteAt(KCU.Characters.BoxDrawing.Walls.Vertical.ToString(), x + width - 1, i);
            }
            Console.CursorTop += 2;
            Console.ForegroundColor = prevfg;
            Console.BackgroundColor = prevbg;
        }
    }
}

