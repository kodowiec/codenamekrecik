namespace krecikthegame.UIComponents
{
    public class TextButtonStyle
    {
        private ConsoleColor _textColor;
        private ConsoleColor _textColorFocused;
        private ConsoleColor _backgroundColor;
        private ConsoleColor _backgroundColorFocused;

        private int _padding;

        public int Padding
        {
            get => _padding;
            set => _padding = value;
        }

        public ConsoleColor TextColor
        {
            get => _textColor;
            set => _textColor = value;
        }

        public ConsoleColor TextColorFocused
        {
            get => _textColorFocused;
            set => _textColorFocused = value;
        }

        public ConsoleColor BackgroundColor
        {
            get => _backgroundColor;
            set => _backgroundColor = value;
        }

        public ConsoleColor BackgroundColorFocused
        {
            get => _backgroundColorFocused;
            set => _backgroundColorFocused = value;
        }

        public TextButtonStyle() { }

        public TextButtonStyle(int padding, ConsoleColor textColor, ConsoleColor textColorFocused, ConsoleColor backgroundColor, ConsoleColor backgroundColorFocused)
        {
            Padding = padding;
            TextColor = textColor;
            TextColorFocused = textColorFocused;
            BackgroundColor = backgroundColor;
            BackgroundColorFocused = backgroundColorFocused;
        }

        public TextButtonStyle Copy => new TextButtonStyle(_padding, _textColor, _textColorFocused, _backgroundColor, _backgroundColorFocused);
        
    }
}
