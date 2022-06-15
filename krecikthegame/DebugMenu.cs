using KCU;

namespace krecikthegame
{
    partial class Program
    {
        static int prevx = 1;
        static int prevy = 1;
        static int px = 1;
        static int py = 1;

        static void ShowDebugMenu(string[] args)
        {
        DebugMain:
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            px = 1;
            py = 1;
            Console.WriteLine("krecik debug menu ");
            Console.WriteLine("W - sprawdzanie wspolrzednych");
            Console.WriteLine("S - rysowanie ramek");

            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.W:
                    DBGPseudoMovement(args);
                    break;
                case ConsoleKey.S:
                DebugDrawFrame:
                    Console.WriteLine();
                    Console.WriteLine("podaj ramke w formacie:");
                    Console.WriteLine("width height x y");
                    string readLine = Console.ReadLine();
                    try
                    {
                        string[] readLineS = readLine.Split(" ");
                        Console.Clear();
                        int width = Int32.Parse(readLineS[0]);
                        int height = Int32.Parse(readLineS[1]);
                        int x = 0, y = 0;
                        try
                        {
                            x = Int32.Parse(readLineS[2]);
                            y = Int32.Parse(readLineS[3]);
                        }
                        catch (Exception e)
                        {
                            x = 0;
                            y = 0;
                        }
                        Console.SetCursorPosition(0, 0);
                        UI.DrawFrame(width, height, ConsoleColor.White, ConsoleColor.Black, x, y);
                        goto DebugDrawFrame;
                    }
                    catch (Exception e)
                    {
                        goto DebugMain;
                    }
                    break;
                default:
                    break;
            }
        }

        static void DBGPseudoMovement(string[] args)
        {
            Console.CursorVisible = false;
            Console.Clear();
            DBGDrawScreen();
            while (true)
            {
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.UpArrow:
                        prevy = py;
                        prevx = px;
                        py -= 1;
                        break;
                    case ConsoleKey.DownArrow:
                        prevy = py;
                        prevx = px;
                        py += 1;
                        break;
                    case ConsoleKey.LeftArrow:
                        prevx = px;
                        prevy = py;
                        px -= 1;
                        break;
                    case ConsoleKey.RightArrow:
                        prevx = px;
                        prevy = py;
                        px += 1;
                        break;
                    default:
                        break;
                }
                try
                {
                    DBGDrawScreen();
                }
                catch (Exception e)
                {
                    Main(args);
                }
            }
        }
        static void DBGDrawScreen()
        {
            //Console.Clear();
            ConsoleToolkit.WriteAt(Characters.whitespace.ToString(), prevx, prevy);
            for (int x = 0; x < Console.WindowWidth; x++)
            {
                Console.BackgroundColor = (x == px) ? ConsoleColor.Magenta : ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                ConsoleToolkit.WriteAt(x.ToString()[x.ToString().Length - 1].ToString(), x, 0);
            }
            for (int y = 0; y < Console.WindowHeight; y++)
            {
                Console.BackgroundColor = (y == py) ? ConsoleColor.Magenta : ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                ConsoleToolkit.WriteAt(y.ToString()[y.ToString().Length - 1].ToString(), 0, y);
            }

            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.ForegroundColor = ConsoleColor.Black;
            ConsoleToolkit.WriteAt("x", px, py);

            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.ForegroundColor = ConsoleColor.Black;

            ConsoleToolkit.WriteAt(String.Format(" {0};{1}", px, py), Console.WindowWidth - String.Format(" {0};{1}", px, py).Length, Console.WindowHeight - 1);

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;


        }
    }
}