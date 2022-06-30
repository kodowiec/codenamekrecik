using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using krecikthegame.UIComponents;

namespace krecikthegame
{
    internal class SettingsScreen
    {
        private static int focusedOption = 0;
        private static bool buttonfocus = false;
        private static int focusedbutton = 0;
        static List<TextButton> buttons = new List<TextButton>();
        static TextButtonStyle buttonStyle = new TextButtonStyle()
        {
            BackgroundColor = ConsoleColor.White,
            TextColor = ConsoleColor.Black,
            BackgroundColorFocused = ConsoleColor.DarkRed,
            TextColorFocused = ConsoleColor.White,
            Padding = 1
        };

        static List<KeyBindingSettingsItem> keybindings = new List<KeyBindingSettingsItem>();

        List<TextButton> tbs =
            new List<TextButton>() {
                new TextButton("przykladowy button", () => 1, 10, 10, new TextButtonStyle()
                {
                    BackgroundColor = ConsoleColor.Black,
                    BackgroundColorFocused = ConsoleColor.DarkRed,
                    TextColor = ConsoleColor.White,
                    TextColorFocused = ConsoleColor.White,
                    Padding = 1
                }
                )
       };

        public static int InitSettings(ref UserSettings settings)
        {
            buttons.Clear();
            buttons.Add(new TextButton("wróć", () => { return 0; }, Console.WindowWidth / 2 - 7 , Console.WindowHeight - 3  , buttonStyle));
            buttons.Add(new TextButton("zapisz", () => { return 1; }, buttons[0].Width + buttons[0].X + 4, Console.WindowHeight - 3, buttonStyle));


            keybindings.Clear();
            foreach (KeyboardSettings i in Enum.GetValues(typeof(KeyboardSettings)))
            {
                if (i == KeyboardSettings.Attack) continue;
                KeyBindingSettingsItem setting = new KeyBindingSettingsItem((ConsoleKey)settings.keymappings[i], settings.keymappings.GetDescription(i), 27, 10 + (keybindings.Count * 2), 39);
                keybindings.Add(setting);
            }

            int result = -1;
            Console.Clear();
            DrawSettingsScreen(ref settings, out result);
            return result;
        }

        public static void DrawSettingsScreen(ref UserSettings settings, out int result)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            KCU.ConsoleToolkit.WriteAt(">> USTAWIENIA <<", Console.WindowWidth/2 - (">> USTAWIENIA <<".Length / 2), 4);
            Console.CursorVisible = false;

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

            buttons.ForEach(button => button.Draw());

            keybindings.ForEach(setting => setting.Draw());

            ConsoleKey readKey = Console.ReadKey().Key;
            if (readKey == ConsoleKey.Tab)
            {
                buttonfocus = !buttonfocus;
                buttons[focusedbutton].IsFocused = buttonfocus;
                keybindings[focusedOption].IsFocused = !buttonfocus;
            }
            else if (readKey == ConsoleKey.Escape)
            {
                result = -1;
                return;
            }
            else if (readKey == ConsoleKey.Enter && buttonfocus)
            {
                result = buttons[focusedbutton].Click.Invoke();
                return;
            }
            else if (readKey == ConsoleKey.Enter && !buttonfocus)
            {
                ConsoleKey output;
                keybindings[focusedOption].ChangeBinding(out output);
                settings.keymappings[(KeyboardSettings)focusedOption] = (int)output;
            }
            else
            {
                if (!buttonfocus)
                {
                    if (readKey == ConsoleKey.UpArrow && !buttonfocus)
                    {
                        if (focusedOption > 0)
                        {
                            keybindings[focusedOption--].IsFocused = false;
                            keybindings[focusedOption].IsFocused = true;
                        }
                    }
                    else if (readKey == ConsoleKey.DownArrow && !buttonfocus)
                    {
                        if (focusedOption < keybindings.Count - 1)
                        {
                            keybindings[focusedOption++].IsFocused = false;
                            keybindings[focusedOption].IsFocused = true;
                        }
                    }
                }
                else
                {

                    if (readKey == ConsoleKey.LeftArrow && buttonfocus)
                    {

                        if (focusedbutton > 0)
                        {
                            buttons[focusedbutton--].IsFocused = false;
                            buttons[focusedbutton].IsFocused = true;
                        }

                    }
                    else if (readKey == ConsoleKey.RightArrow && buttonfocus)
                    {
                        if (focusedbutton < buttons.Count - 1)
                        {
                            buttons[focusedbutton++].IsFocused = false;
                            buttons[focusedbutton].IsFocused = true;
                        }
                    }
                }
            }

            DrawSettingsScreen(ref settings, out result);

            return;
        }
    }
}
