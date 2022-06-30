namespace krecikthegame
{
    internal class HowToPlayScreen
    {
        public static void Show(ref UserSettings settings)
        {

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            KCU.ConsoleToolkit.WriteAt(">> JAK GRAĆ <<", Console.WindowWidth / 2 - (">> JAK GRAĆ <<".Length / 2), 4);

            KCU.ConsoleToolkit.WriteAt("Idź w górę: " + (ConsoleKey)settings.keymappings.MoveUp, 30, 10);
            KCU.ConsoleToolkit.WriteAt("Idź w dół: " + ((ConsoleKey)settings.keymappings.MoveDown), 30, 12);
            KCU.ConsoleToolkit.WriteAt("Idź w lewo: " + ((ConsoleKey)settings.keymappings.MoveLeft), 30, 14);
            KCU.ConsoleToolkit.WriteAt("Idź w prawo: " + ((ConsoleKey)settings.keymappings.MoveRight), 30, 16);
            KCU.ConsoleToolkit.WriteAt("Interfejs: " + ((ConsoleKey)settings.keymappings.HideHUD), 30, 20);
            KCU.ConsoleToolkit.WriteAt("Interakcja: " + ((ConsoleKey)settings.keymappings.Interact), 30, 22);
            KCU.ConsoleToolkit.WriteAt("Ekwipunek: " + ((ConsoleKey)settings.keymappings.Inventory), 30, 24);

            KCU.ConsoleToolkit.WriteAt("naciśnij enter aby rozpocząć grę", Console.WindowWidth / 2 - ("naciśnij enter aby rozpocząć grę".Length / 2), Console.WindowHeight - 2);
            while (true)
            {
                if (Console.ReadKey().Key == ConsoleKey.Enter)
                {
                    return;
                }
            }
        }
    }
}