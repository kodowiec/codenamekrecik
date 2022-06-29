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
    public static void DrawInterface(ConsoleColor frameColor, ConsoleColor backgroundColor, ConsoleColor plotTextColor, ConsoleColor missionText, ConsoleColor textColo)
        {
            //ConsoleColor prevFG = Console.ForegroundColor;
            //ConsoleColor prevBG = Console.BackgroundColor;
            Console.BackgroundColor = backgroundColor;
            //Console.Clear();
            DrawFrame(Console.WindowWidth - 2, Console.WindowHeight - 2, frameColor, backgroundColor, 1, 1);
            Console.ForegroundColor = frameColor;
            //Console.BackgroundColor = prevBG;
            WriteAt("╔", Console.WindowWidth - 13, Console.WindowHeight - 14);
            for (int i = 0; i < 10; i++)
            {
                WriteAt("═", Console.WindowWidth - 12 + i, Console.WindowHeight - 14);
                WriteAt("║", Console.WindowWidth - 13, Console.WindowHeight - 13 + i);
            }
            WriteAt("║", Console.WindowWidth - 13, Console.WindowHeight - 3);
            WriteAt("╩", Console.WindowWidth - 13, Console.WindowHeight - 2);
            WriteAt("╣", Console.WindowWidth - 2, Console.WindowHeight - 14);
            Console.ForegroundColor = missionText;
            WriteAt("PLECAK", Console.WindowWidth - 10, Console.WindowHeight - 12);
            Console.ForegroundColor = frameColor;
            WriteAt("1.#", Console.WindowWidth - 12, Console.WindowHeight - 10);
            WriteAt("2.#", Console.WindowWidth - 12, Console.WindowHeight - 9);
            WriteAt("3.#", Console.WindowWidth - 12, Console.WindowHeight - 8);
            WriteAt("4.#", Console.WindowWidth - 12, Console.WindowHeight - 7);
            WriteAt("5.#", Console.WindowWidth - 12, Console.WindowHeight - 6);
            WriteAt("6.#", Console.WindowWidth - 12, Console.WindowHeight - 5);
            WriteAt("7.#", Console.WindowWidth - 12, Console.WindowHeight - 4);
            Console.ForegroundColor = missionText;
            WriteAt("AKTUALNY CEL MISJI:", 3, 0);
            WriteAt("#", 23, 0);
            Console.ForegroundColor = frameColor;
            WriteAt("ZDROWIE:", Console.WindowWidth - 17, 3);
            Console.ForegroundColor = ConsoleColor.Red;
            WriteAt("♥ ♥ ♥", Console.WindowWidth - 8, 3);
            Console.ForegroundColor = frameColor;
            WriteAt("zebrales cos", 3, Console.WindowHeight - 4);
            Console.ForegroundColor = plotTextColor;
            WriteAt("Babcia: (...)", 3, Console.WindowHeight - 5);
        }
    }
}
