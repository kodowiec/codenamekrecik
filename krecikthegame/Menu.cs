using krecikthegame.UIComponents;

namespace krecikthegame
{
    internal class MainMenu
    {
        public ConsoleColor FrameColor = ConsoleColor.White;
        public ConsoleColor TitleColor = ConsoleColor.Red;
        public ConsoleColor TextColor = ConsoleColor.White;
        public ConsoleColor BackgroundColor = ConsoleColor.Black;

        public Game game;

        private List<TextButton> menuButtons = new List<TextButton>();

        private int focusedButton = 0;

        private TextButtonStyle buttonStyle = new TextButtonStyle()
        {
            Padding = 1,
            TextColor = ConsoleColor.White,
            TextColorFocused = ConsoleColor.White,
            BackgroundColor = ConsoleColor.Black,
            BackgroundColorFocused = ConsoleColor.DarkRed,
        };

        public MainMenu(bool debug = false)
        {
            this.game = new Game();

            menuButtons.Add(new TextButton("zagraj", () => { StartGame(); return 1; }, 5, 18, buttonStyle));
            menuButtons[0].IsFocused = true;
            menuButtons.Add(new TextButton("opcje", () => { GoToOptions(); this.Run(); return 2; }, 5, 20, buttonStyle));
            menuButtons.Add(new TextButton("wyjdź", () => { Environment.Exit(0); return 0; }, 5, 22, buttonStyle));


            if (debug)
            {
                TextButton debugmbtn = new TextButton("debug menu", () => { ShowDebug(); return 69; }, 5, Console.WindowHeight - 3, @buttonStyle);
                debugmbtn.style.BackgroundColorFocused = ConsoleColor.DarkYellow;   
                menuButtons.Add(debugmbtn);
            }
        }

        public void ShowDebug() => Program.ShowDebugMenu();

        public void Run()
        {
            Console.CursorVisible = false;
            UI.DrawMainMenu(FrameColor, BackgroundColor, TitleColor, TextColor);
            MainMenuLoop();
        }

        private void StartGame() => game.Run();

        private void GoToOptions()
        {
            if (SettingsScreen.InitSettings(ref this.game.settings) == 1) this.game.settingsManager.WriteSettings(ref this.game.settings);
        }

        private void MainMenuLoop()
        {
            while (true)
            {
                // we'll redraw only buttons cause the rest of the main menu is static
                menuButtons.ForEach(button => button.Draw());
                Console.ForegroundColor = Console.BackgroundColor;
                ConsoleKey pressed = Console.ReadKey().Key;
                switch (pressed)
                {
                    case ConsoleKey.UpArrow:
                        SelectedButtonChange(false);
                        break;
                    case ConsoleKey.DownArrow:
                        SelectedButtonChange(true);
                        break;
                    case ConsoleKey.Enter:
                        menuButtons[focusedButton].Click.Invoke();
                        break;
                    default:
                        break;
                }

            }
            this.Run();

        }

        private void SelectedButtonChange(bool increment)
        {
            int prevfocus = focusedButton;
            if (increment)
            {
                if (focusedButton < menuButtons.Count - 1) focusedButton++;
            }
            else
            {
                if (focusedButton > 0) focusedButton--;
            }

            menuButtons[prevfocus].IsFocused = false;
            menuButtons[focusedButton].IsFocused = true;
        }
    }
}
