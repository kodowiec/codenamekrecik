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
        public static void DrawDialogue(string title, string body, ConsoleColor frameColor, ConsoleColor textColor, string answer = "KONTYNUUJ")
        {
            Console.Clear();
            //for (int i = 0; i < 31; i++)
            //{
            //    WriteAt("═", Console.WindowWidth / 2 - 15 + i, Console.WindowHeight / 2 - 7);
            //    WriteAt("═", Console.WindowWidth / 2 - 15 + i, Console.WindowHeight / 2 + 5);
            //}
            //for (int i = 0; i < 11; i++)
            //{
            //    WriteAt("║", Console.WindowWidth / 2 - 16, Console.WindowHeight / 2 - 6 + i);
            //    WriteAt("║", Console.WindowWidth / 2 + 16, Console.WindowHeight / 2 - 6 + i);
            //}
            //WriteAt("╔", Console.WindowWidth / 2 - 16, Console.WindowHeight / 2 - 7);
            //WriteAt("╗", Console.WindowWidth / 2 + 16, Console.WindowHeight / 2 - 7);
            //WriteAt("╚", Console.WindowWidth / 2 - 16, Console.WindowHeight / 2 + 5);
            //WriteAt("╝", Console.WindowWidth / 2 + 16, Console.WindowHeight / 2 + 5);
            Console.ForegroundColor = ConsoleColor.Blue;
            WriteAt(title, 3, Console.WindowHeight / 2 - 7);
            Console.ForegroundColor = ConsoleColor.White;
            WriteAt(body, 3, Console.WindowHeight / 2 - 5);
            Console.ForegroundColor = ConsoleColor.DarkGray;
            WriteAt("ODPOWIEDZ:  ", 3, Console.WindowHeight / 2 + 5);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            WriteAt(answer, 15, Console.WindowHeight / 2 + 5);
            Console.ReadKey();
        }
    }
}
