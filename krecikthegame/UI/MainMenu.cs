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
        public static void DrawMainMenu(ConsoleColor frameColor, ConsoleColor backgroundColor, ConsoleColor titleColor, ConsoleColor textColor)
        {
            ConsoleColor prevFG = Console.ForegroundColor;
            ConsoleColor prevBG = Console.BackgroundColor;
            Console.BackgroundColor = backgroundColor;
            Console.Clear();
            DrawFrame(Console.WindowWidth -2 , Console.WindowHeight - 2, frameColor, backgroundColor, 1, 1);
            Console.ForegroundColor = titleColor;
            Console.ForegroundColor = prevFG;
            WriteAt("zagraj",5, 17);
            WriteAt("ustawienia",5, 19);
            WriteAt("koniec",5, 21);
            Console.BackgroundColor = prevBG;
            Console.ForegroundColor = prevFG;
            Console.ForegroundColor = titleColor;
            WriteAt(@"     ___/\/\______/\/\___________________",17,14);
            WriteAt(@"    _/\/\/\/\/\__/\/\__________/\/\/\___ ", 17, 15);
            WriteAt(@"   ___/\/\______/\/\/\/\____/\/\/\/\/\_  ", 17, 16);
            WriteAt(@"  ___/\/\______/\/\__/\/\__/\/\_______   ", 17, 17);
            WriteAt(@" ___/\/\/\____/\/\__/\/\____/\/\/\/\_    ", 17, 18);
            WriteAt(@"____________________________________     ", 17, 19);
            WriteAt(@"     ________________________________________________", 17, 20);
            WriteAt(@"    ___/\/\/\/\__/\/\/\______/\/\__/\/\____/\/\/\___ ", 17, 21);
            WriteAt(@"   _/\/\____________/\/\____/\/\__/\/\__/\/\/\/\/\_  ", 17, 22);
            WriteAt(@"  _/\/\________/\/\/\/\______/\/\/\____/\/\_______   ", 17, 23);
            WriteAt(@" ___/\/\/\/\__/\/\/\/\/\______/\________/\/\/\/\_    ", 17, 24);
            WriteAt(@"________________________________________________     ", 17, 25);
            Console.ForegroundColor = ConsoleColor.White;

        }
    }
}
