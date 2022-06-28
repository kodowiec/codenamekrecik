using System.Text;

namespace krecikthegame.UIComponents
{
    public class TextButton
    {
        private string _text;
        private string _focusedText;
        private bool _isFocused;

        public TextButtonStyle style;

        private Func<int> _clicked;

        public int X;
        public int Y;

        public TextButton(string text, Func<int> clicked, int x, int y, TextButtonStyle style, string focusedText = "!!!!!!!!!!!!!!!!!!!!!!!!")
        {
            X = x;
            Y = y;
            _text = text;
            _clicked = clicked;
            _isFocused = false;
            this.style = style.Copy;
            _focusedText = (focusedText == "!!!!!!!!!!!!!!!!!!!!!!!!") ? text : focusedText;
        }

        public Func<int> Click => _clicked;

        public bool IsFocused
        {
            get => _isFocused;
            set => _isFocused = value;
        }

        public int Width
        {
            get => this._text.Length;
        }

        public void Draw()
        {
            ConsoleColor prevBG = Console.BackgroundColor;
            ConsoleColor prevFG = Console.ForegroundColor;

            StringBuilder sb = new StringBuilder();
            sb.Append(KCU.Characters.whitespace, style.Padding);
            StringBuilder sb2 = new StringBuilder();
            sb2.Append('▁', (sb.ToString() + ((_isFocused) ? _focusedText : _text) + sb.ToString()).Length);

            Console.ForegroundColor = (_isFocused) ? style.BackgroundColorFocused : style.BackgroundColor;
            KCU.ConsoleToolkit.WriteAt(sb2.ToString(), X, Y - 1);

            Console.BackgroundColor = (_isFocused) ? style.BackgroundColorFocused : style.BackgroundColor;
            Console.ForegroundColor = (_isFocused) ? style.TextColorFocused : style.TextColor;
            KCU.ConsoleToolkit.WriteAt(sb.ToString() + ((_isFocused) ? _focusedText : _text) + sb.ToString(), X, Y);

            Console.BackgroundColor = prevBG;
            Console.ForegroundColor = prevFG;
        }
    }
}
