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
        private static void DrawAscii(bool animate=false, int animationdelay = 150)
        {
            WriteAt(@"         /\/       /\/", 17, 13);
            if (animate) System.Threading.Thread.Sleep(animationdelay);
            WriteAt(@"        /\/       /\/         /\/\/\", 17, 14);
            if (animate) System.Threading.Thread.Sleep(animationdelay);
            WriteAt(@"     /\/\/\/\/\  /\/\        /\    /\ ", 17, 15);
            if (animate) System.Threading.Thread.Sleep(animationdelay);
            WriteAt(@"      /\/\      /\/\/\/\    /\/\/\/\/  ", 17, 16);
            if (animate) System.Threading.Thread.Sleep(animationdelay);
            WriteAt(@"     /\/\      /\/\  /\/\   /\/\   ", 17, 17);
            if (animate) System.Threading.Thread.Sleep(animationdelay);
            WriteAt(@"    /\/\/\    /\/\  /\/\     /\/\/\/\     ", 17, 18);
            //WriteAt(@"____________________________________     ", 17, 19);
            if (animate) System.Threading.Thread.Sleep(1000 + animationdelay);
            //WriteAt(@"     ________________________________________________", 17, 20);
            WriteAt(@"      /\/\/\/\  /\/\/\     /\/\   /\/\    /\/\/\    ", 17, 21);
            if (animate) System.Threading.Thread.Sleep(animationdelay);
            WriteAt(@"    /\/\           /\/\     /\/\  /\/    /\    /\  ", 17, 22);
            if (animate) System.Threading.Thread.Sleep(animationdelay);
            WriteAt(@"   /\/\        /\/\/\/\     /\/\ /\     /\/\/\/\/   ", 17, 23);
            if (animate) System.Threading.Thread.Sleep(animationdelay);
            WriteAt(@"   /\/\        /\    /\      /\/\/\     /\/\   ", 17, 24);
            if (animate) System.Threading.Thread.Sleep(animationdelay);
            WriteAt(@"    /\/\/\/\   \/\/\/\/        /\        /\/\/\/\    ", 17, 25);
            // WriteAt(@"________________________________________________     ", 17, 25);
            if (animate) System.Threading.Thread.Sleep(animationdelay + 1000);
        }
        private static void DrawAscii2(bool animate = true, int animationdelay = 150)
        {
            
            WriteAt(@"         /\/       /\/", 17, 13, ConsoleColor.Gray);
            if (animate) System.Threading.Thread.Sleep(animationdelay);
            WriteAt(@"         /\/       /\/", 17, 13, ConsoleColor.Red);
            WriteAt(@"        /\/       /\/       /\/\/\", 17, 14, ConsoleColor.Gray);
            if (animate) System.Threading.Thread.Sleep(animationdelay);
            WriteAt(@"        /\/       /\/       /\/\/\", 17, 14, ConsoleColor.Red);
            WriteAt(@"     /\/\/\/\/\  /\/\      /\    /\ ", 17, 15, ConsoleColor.Gray);
            if (animate) System.Threading.Thread.Sleep(animationdelay);
            WriteAt(@"     /\/\/\/\/\  /\/\      /\    /\ ", 17, 15, ConsoleColor.Red);
            WriteAt(@"      /\/\      /\/\/\/\  /\/\/\/\/  ", 17, 16, ConsoleColor.Gray);
            if (animate) System.Threading.Thread.Sleep(animationdelay);
            WriteAt(@"      /\/\      /\/\/\/\  /\/\/\/\/  ", 17, 16, ConsoleColor.Red);
            WriteAt(@"     /\/\      /\/\  /\/\ /\/\   ", 17, 17, ConsoleColor.Gray);
            if (animate) System.Threading.Thread.Sleep(animationdelay);
            WriteAt(@"     /\/\      /\/\  /\/\ /\/\   ", 17, 17, ConsoleColor.Red);
            WriteAt(@"    /\/\/\    /\/\  /\/\   /\/\/\/\     ", 17, 18, ConsoleColor.Gray);
            if (animate) System.Threading.Thread.Sleep(animationdelay);
            WriteAt(@"    /\/\/\    /\/\  /\/\   /\/\/\/\     ", 17, 18, ConsoleColor.Red);
            //WriteAt(@"____________________________________     ", 17, 19);
            if (animate) System.Threading.Thread.Sleep(500 + animationdelay);
            //WriteAt(@"     ________________________________________________", 17, 20);
            WriteAt(@"    /\/\/\    /\/\  /\/\   /\/\/\/\     ", 17, 18, ConsoleColor.Red);
            WriteAt(@"      /\/\/\/\  /\/\/\  /\/\   /\/\  /\/\/\    ", 17, 21, ConsoleColor.Gray);
            if (animate) System.Threading.Thread.Sleep(animationdelay);
            WriteAt(@"      /\/\/\/\  /\/\/\  /\/\   /\/\  /\/\/\    ", 17, 21, ConsoleColor.Red);
            WriteAt(@"    /\/\           /\/\  /\/\  /\/  /\    /\  ", 17, 22, ConsoleColor.Gray);
            if (animate) System.Threading.Thread.Sleep(animationdelay);
            WriteAt(@"    /\/\           /\/\  /\/\  /\/  /\    /\  ", 17, 22, ConsoleColor.Red);
            WriteAt(@"   /\/\        /\/\/\/\  /\/\ /\   /\/\/\/\/   ", 17, 23, ConsoleColor.Gray);
            if (animate) System.Threading.Thread.Sleep(animationdelay);
            WriteAt(@"   /\/\        /\/\/\/\  /\/\ /\   /\/\/\/\/   ", 17, 23, ConsoleColor.Red);
            WriteAt(@"   /\/\        /\    /\   /\/\/\   /\/\   ", 17, 24, ConsoleColor.Gray);
            if (animate) System.Threading.Thread.Sleep(animationdelay);
            WriteAt(@"   /\/\        /\    /\   /\/\/\   /\/\   ", 17, 24, ConsoleColor.Red);
            WriteAt(@"    /\/\/\/\   \/\/\/\/     /\      /\/\/\/\    ", 17, 25, ConsoleColor.Gray);
            if (animate) System.Threading.Thread.Sleep(animationdelay);
            WriteAt(@"    /\/\/\/\   \/\/\/\/     /\      /\/\/\/\    ", 17, 25, ConsoleColor.Red);
            // WriteAt(@"________________________________________________     ", 17, 25);
            if (animate) System.Threading.Thread.Sleep(animationdelay + 1000);
        }
        public static void DrawMainMenu(ConsoleColor frameColor, ConsoleColor backgroundColor, ConsoleColor titleColor, ConsoleColor textColor)
        {
            ConsoleColor prevFG = Console.ForegroundColor;
            ConsoleColor prevBG = Console.BackgroundColor;
            Console.BackgroundColor = backgroundColor;
            Console.Clear();
            DrawFrame(Console.WindowWidth -2 , Console.WindowHeight - 2, frameColor, backgroundColor, 1, 1);
            Console.ForegroundColor = titleColor;
            Console.ForegroundColor = prevFG;
            //WriteAt("zagraj",5, 17);
            //WriteAt("ustawienia",5, 19);
            //WriteAt("koniec",5, 21);
            Console.ForegroundColor = titleColor;
            if(false)
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                DrawAscii(false);
                System.Threading.Thread.Sleep(350);
                Console.ForegroundColor = ConsoleColor.Gray;
                DrawAscii(false);
                System.Threading.Thread.Sleep(350);
                Console.ForegroundColor = ConsoleColor.White;
                DrawAscii(false);
                System.Threading.Thread.Sleep(350);
                Console.ForegroundColor = titleColor;
                DrawAscii(false);
                System.Threading.Thread.Sleep(350);
            }
            else DrawAscii2(true, 100);
            //Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = prevBG;
            Console.ForegroundColor = prevFG;

        }

    }
}
