using System;

namespace krecikthegame
{
    public interface IUI
    {
        public static void DrawFrame(int width, int height, ConsoleColor frameColor, ConsoleColor backgroundColor) => throw new NotImplementedException();
        
        public static void DrawMainMenu(string title, ConsoleColor frameColor, ConsoleColor backgroundColor, ConsoleColor titleColor, ConsoleColor textColor ) => throw new NotImplementedException();
        
    }
}

