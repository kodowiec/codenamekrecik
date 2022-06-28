using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace krecikthegame.UIComponents
{
    public class KeyBindingSettingsItem
    {
        // this is specifically for setting with key binding
        // so we'll make this specific lol
        private string _title;
        private ConsoleColor _titleTextColor;
        private ConsoleColor _titleTextColorFocused;
        private ConsoleColor _editBoxColor;
        private ConsoleColor _editBoxColorFocused;
        private ConsoleColor _editBoxTextColor;
        private ConsoleColor _editBoxTextColorFocused;
        private ConsoleKey _key;
        private bool _focused;

        public int X;
        public int Y;
        public int X2;

        public KeyBindingSettingsItem(ConsoleKey key, string title, int x, int y, int x2,
            ConsoleColor titleTextColor = ConsoleColor.White, ConsoleColor titleTextColorFocused = ConsoleColor.Yellow,
            ConsoleColor editBoxColor = ConsoleColor.White, ConsoleColor editBoxColorFocused = ConsoleColor.Cyan,
            ConsoleColor editBoxTextColor = ConsoleColor.Black, ConsoleColor editBoxTextColorFocused = ConsoleColor.Black)
        {
            _title = title;
            _titleTextColor = titleTextColor;
            _titleTextColorFocused = titleTextColorFocused;
            _editBoxColor = editBoxColor;
            _editBoxColorFocused = editBoxColorFocused;
            _editBoxTextColor = editBoxTextColor;
            _editBoxTextColorFocused = editBoxTextColorFocused;
            _focused = false;
            _key = key;
            X = x;
            Y = y;
            X2 = x2;
        }

        public bool IsFocused { get => _focused; set => _focused = value; }

        public int ChangeBinding(out ConsoleKey output)
        {
            DrawEdit();
            ConsoleKey newKey = Console.ReadKey().Key;
            if (newKey == ConsoleKey.Escape)
            {
                output = _key;
                return -1;
            }
            _key = newKey;
            output = newKey;
            return (int)newKey;
        }

        public void Draw(bool refreshField = true)
        {
            ConsoleColor prevBG = Console.BackgroundColor;
            ConsoleColor prevFG = Console.ForegroundColor;

            if (refreshField)
            {
                Console.SetCursorPosition(X2, Y - 1);
                KCU.ConsoleToolkit.ClearCharacters(12);
                Console.SetCursorPosition(X2, Y);
                KCU.ConsoleToolkit.ClearCharacters(12);
            }

            Console.ForegroundColor = (_focused) ? _titleTextColorFocused : _titleTextColor;
            KCU.ConsoleToolkit.WriteAt(_title, X, Y);

            StringBuilder sb = new StringBuilder();

            sb.Append('▁', _key.ToString().Length + 2);
            Console.ForegroundColor = (_focused) ? _editBoxColorFocused : _editBoxColor;
            KCU.ConsoleToolkit.WriteAt(sb.ToString(), X2, Y - 1);

            Console.ForegroundColor = (_focused) ? _editBoxTextColorFocused : _editBoxTextColor;
            Console.BackgroundColor = (_focused) ? _editBoxColorFocused : _editBoxColor;
            KCU.ConsoleToolkit.WriteAt(" " + (_key).ToString() + " ", X2, Y);

            Console.ForegroundColor = prevFG;
            Console.BackgroundColor = prevBG;
        }

        public void DrawEdit(bool refreshField = true)
        {
            ConsoleColor prevBG = Console.BackgroundColor;
            ConsoleColor prevFG = Console.ForegroundColor;

            if (refreshField)
            {
                Console.SetCursorPosition(X2, Y - 1);
                KCU.ConsoleToolkit.ClearCharacters(12);
                Console.SetCursorPosition(X2, Y);
                KCU.ConsoleToolkit.ClearCharacters(12);
            }

            Console.ForegroundColor = (_focused) ? _titleTextColorFocused : _titleTextColor;
            KCU.ConsoleToolkit.WriteAt(_title, X, Y);

            StringBuilder sb = new StringBuilder();

            sb.Append('▁', 5);
            Console.ForegroundColor = (_focused) ? _editBoxColorFocused : _editBoxColor;
            KCU.ConsoleToolkit.WriteAt(sb.ToString(), X2, Y - 1);

            Console.ForegroundColor = (_focused) ? _editBoxTextColorFocused : _editBoxTextColor;
            Console.BackgroundColor = (_focused) ? _editBoxColorFocused : _editBoxColor;
            KCU.ConsoleToolkit.WriteAt("  *  ", X2, Y);
            Console.CursorVisible = true;
            Console.CursorLeft -= 3;
            Console.ForegroundColor = prevFG;
            Console.BackgroundColor = prevBG;
        }
    }
}
