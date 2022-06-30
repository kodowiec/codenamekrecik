using static KCU.ConsoleToolkit;

namespace krecikthegame
{
    class EndScreen
    {
        public static void Show()
        {
            Console.Clear();
            WriteAt("Wow,", 3, 3);
            Sleep(1500);
            WriteAt("Udało Ci się wyjść z labiryntu!", 3, 5);
            Sleep(1000);
            WriteAt("Uznajemy to za niesamowite osiągnięcie, ", 3, 6);
            Sleep(750);
            WriteAt("tak w ciemności i w ogóle...  ", 3, 7);
            Sleep(1500);
            WriteAt("super!", Console.CursorLeft, 7);

            Sleep(2000);
            WriteAt("Szczególnie, że nas porwały truskawki, mniam!", 3, 10);
            Sleep(1000);
            WriteAt("yummy", 3, 11);
            Sleep(1000);
            WriteAt("Dzięki za przejście wersji demo!", 3, 14);
            Sleep(2000);
            WriteAt("Mamy nadzieję, że przechodziło się równie smacznie", 3, 15);
            Sleep(2000);
            WriteAt("do zobaczenia! :)", 3, 17);
            Sleep(4000);

            Console.ForegroundColor = ConsoleColor.DarkGray;
            WriteAt("naciśnij dowolny klawisz aby opuścić grę", 3, Console.WindowHeight - 2);
            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}