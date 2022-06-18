using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static KCU.ConsoleToolkit;
namespace krecikthegame
{
    public partial class UI : IUI
    {
        public static void DrawMainMenu(string title, ConsoleColor frameColor, ConsoleColor backgroundColor, ConsoleColor titleColor, ConsoleColor textColor)
        {
            ConsoleColor prevFG = Console.ForegroundColor;
            ConsoleColor prevBG = Console.BackgroundColor;
            Console.BackgroundColor = backgroundColor;
            Console.Clear();
            DrawFrame(Console.WindowWidth -2 , Console.WindowHeight - 2, frameColor, backgroundColor, 1, 1);
            Console.ForegroundColor = titleColor;
            WriteAt(title, Console.WindowWidth / 2 - title.Length / 2, 10);
            Console.ForegroundColor = prevFG;
            WriteAt("zagraj", Console.WindowWidth / 2 - "zagraj".Length / 2, 13);
            WriteAt("ustawienia", Console.WindowWidth / 2 - "ustawienia".Length / 2, 15);
            WriteAt("koniec", Console.WindowWidth / 2 - "koniec".Length / 2, 17);

        }
    }
}
