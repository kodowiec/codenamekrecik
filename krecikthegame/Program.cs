namespace krecikthegame
{
    public partial class Program
    {
        static void Main(string[] args)
        {
            bool debug = false;
            bool fullscreen = true;
            if (args.Length > 0)
            {
                foreach (var arg in args)
                {
                    switch(arg)
                    {
                        case "--debug" or "-d" or "/d":
                            debug = true;
                            break;
                        case "--fullscreen" or "-f" or "/f":
                            fullscreen = true;
                            break;
                        case "--windowed" or "/w" or "-w":
                            fullscreen = false;
                            break;
                        default:
                            break;
                    }
                }
            }

            // install and swap the font
            {
                Console.OutputEncoding = System.Text.Encoding.Unicode;
                // TO-DO: check if properly installed;
                string fir = KCU.Fonts.InstallFont(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "font.ttf"));
                FontInstall:
                if (fir != "Font installed successfully.")
                {
                    if (debug) Console.WriteLine(fir);
                    System.Threading.Thread.Sleep(500);
                    goto FontInstall;
                }
                KCU.Fonts.ChangeFont("MxPlus IBM BIOS");
            }


            KCU.Size screenSize = KCU.ScreenSize.GetClosestToCurrentScreenSize();
            // this below is for width 75
            // short size = (short)((short)Math.Round((decimal)screenSize.Width / 75, MidpointRounding.ToZero));
            //for testing well stick with forced height isntead
            short size = (short)((short)Math.Round((decimal)screenSize.Height / 44, MidpointRounding.ToZero));

            // fullscreen
            if (fullscreen) System.Windows.Forms.SendKeys.SendWait("{F11}");
            if (fullscreen)
            {
                short? fs = KCU.Fonts.GetFontSize();
                if(fs.HasValue && (screenSize.Width - Console.WindowWidth * fs) > 100)
                {
                    System.Windows.Forms.SendKeys.SendWait("{F11}");
                }
            }

            // scale the screen to our liking
            {
                KCU.Fonts.SetFontSize(size, size);
                KCU.ConsoleMode.Maximize();
            }

            Console.SetBufferSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
            
            MainMenu mainMenu = new MainMenu(debug);
            mainMenu.Run();
        }
    }
}