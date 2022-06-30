using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gameplay.Items;
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
            WriteAt("╔", Console.WindowWidth - 17, Console.WindowHeight - 14);
            WriteAt("═", Console.WindowWidth - 14, Console.WindowHeight - 14);
            WriteAt("═", Console.WindowWidth - 13, Console.WindowHeight - 14);
            WriteAt("═", Console.WindowWidth - 15, Console.WindowHeight - 14);
            WriteAt("═", Console.WindowWidth - 16, Console.WindowHeight - 14);
            for (int i = 0; i < 10; i++)
            {
                WriteAt("═", Console.WindowWidth - 12 + i, Console.WindowHeight - 14);
                WriteAt("║", Console.WindowWidth - 17, Console.WindowHeight - 13 + i);
            }
            WriteAt("║", Console.WindowWidth - 17, Console.WindowHeight - 3);
            WriteAt("╩", Console.WindowWidth - 17, Console.WindowHeight - 2);
            WriteAt("╣", Console.WindowWidth - 2, Console.WindowHeight - 14);
            Console.ForegroundColor = missionText;
            WriteAt("PLECAK", Console.WindowWidth - 12, Console.WindowHeight - 12);
            Console.ForegroundColor = frameColor;
            Gameplay.Equipment EQ = Gameplay.GameplayStatics.GetPlayer().EQ;
            for(int i = 0; i < 7; i++)
            {
                string text = "#";
                if(EQ.Count > i)
                {
                    Item item = EQ.GetAt(i);
                    text = item.Name;
                    if (item.Stackable)
                        text += String.Format(" x{0}", item.Count);
                }
                WriteAt(String.Format("{0}.{1}", i+1, text), Console.WindowWidth - 16, Console.WindowHeight - 10 + i);
            }
            Console.ForegroundColor = missionText;
            WriteAt("AKTUALNY CEL MISJI:", 3, 0);
            WriteAt(Gameplay.GameplayStatics.GetCurrentQuest().Goal, 23, 0);
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
