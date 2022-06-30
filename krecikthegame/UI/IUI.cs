using System;
using krecikthegame.UIComponents;
namespace krecikthegame
{
    public interface IUI
    {
        public static void DrawFrame(int width, int height, ConsoleColor frameColor, ConsoleColor backgroundColor) => throw new NotImplementedException();
        
        public static void DrawMainMenu(ConsoleColor frameColor, ConsoleColor backgroundColor, ConsoleColor titleColor, ConsoleColor textColor ) => throw new NotImplementedException();

        public static void DrawInterface(ConsoleColor frameColor, ConsoleColor backgroundColor, ConsoleColor plotTextColor, ConsoleColor missionText, ConsoleColor textColor) => throw new NotImplementedException();

        public static void DrawDialogue(string title, string body, List<TextButton> answers, ConsoleColor frameColor, ConsoleColor textColor) => throw new NotImplementedException();
    }
}

