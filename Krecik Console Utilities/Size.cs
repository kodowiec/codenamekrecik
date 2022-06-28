namespace KCU
{
    public class Size
    {
        public int Width { get; set; }
        public int Height { get; set; }
    }

    public class ScreenSize
    {
        public static Size GetClosestToCurrentScreenSize()
        {
            ConsoleMode.Maximize();
            int closestWidth = (int)Fonts.GetFontSize() * Console.LargestWindowWidth;
            Size ret = new Size();
            Dictionary<int, System.Windows.Forms.Screen> abs = new Dictionary<int, System.Windows.Forms.Screen>();
            foreach (var screen in System.Windows.Forms.Screen.AllScreens)
            {
                int a = Math.Abs(screen.Bounds.Width - closestWidth);
                if (abs.ContainsKey(a))
                {
                    int closestHeight = (int)Fonts.GetFontSize(false) * Console.LargestWindowHeight;
                    if (Math.Abs(screen.Bounds.Height - closestHeight) < Math.Abs(abs[a].Bounds.Height - closestHeight)) abs[a] = screen;
                }
                else abs.Add(a, screen);
            }
            int min = 2000;
            foreach (var item in abs)
            {
                if (item.Key < min) min = item.Key;
            }
            ret.Width = abs[min].Bounds.Width;
            ret.Height = abs[min].Bounds.Height;
            return ret;
        }
    }
}
