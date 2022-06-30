using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using krecikthegame.UIComponents;
using static KCU.ConsoleToolkit;
namespace krecikthegame
{
    public partial class UI : IUI
    {
        public static void DrawDialogue(string title, string body, ConsoleColor frameColor, ConsoleColor textColor)
        {
            Console.Clear();
            for (int i = 0; i < 31; i++)
            {
                WriteAt("═", Console.WindowWidth / 2 - 15 + i, Console.WindowHeight / 2 - 7);
                WriteAt("═", Console.WindowWidth / 2 - 15 + i, Console.WindowHeight / 2 + 5);
            }
            for (int i = 0; i < 11; i++)
            {
                WriteAt("║", Console.WindowWidth / 2 - 16, Console.WindowHeight / 2 - 6 + i);
                WriteAt("║", Console.WindowWidth / 2 + 16, Console.WindowHeight / 2 - 6 + i);
            }
            WriteAt("╔", Console.WindowWidth / 2 - 16, Console.WindowHeight / 2 - 7);
            WriteAt("╗", Console.WindowWidth / 2 + 16, Console.WindowHeight / 2 - 7);
            WriteAt("╚", Console.WindowWidth / 2 - 16, Console.WindowHeight / 2 + 5);
            WriteAt("╝", Console.WindowWidth / 2 + 16, Console.WindowHeight / 2 + 5);
            Console.ForegroundColor = ConsoleColor.Blue;
            WriteAt("BODY", Console.WindowWidth / 2 - 13, Console.WindowHeight / 2 - 7);
            Console.ForegroundColor = ConsoleColor.White;
            WriteAt("przykladowy tekst...", Console.WindowWidth / 2 - 14, Console.WindowHeight / 2 - 5);
            Console.ForegroundColor = ConsoleColor.DarkGray;
            WriteAt("WCIŚNIJ ENTER ABY KONTYNUOWAĆ", Console.WindowWidth / 2 - 14, Console.WindowHeight / 2 + 5);
        }
    }
}
