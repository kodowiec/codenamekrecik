﻿using KCU;
using System.Windows.Forms;

namespace krecikthegame
{
    partial class Program
    {
        static int prevx = 1;
        static int prevy = 1;
        static int px = 1;
        static int py = 1;
        
        static Size closestScreenSize()
        {
            ConsoleMode.Maximize();
            int closestWidth = (int) Fonts.GetFontSize() * Console.LargestWindowWidth;
            Size ret = new Size();
            Dictionary<int, Screen> abs = new Dictionary<int, Screen>();
            foreach (var screen in Screen.AllScreens)
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
            foreach  (var item in abs)
            {
                if (item.Key < min) min = item.Key;
            }
            ret.Width = abs[min].Bounds.Width;
            ret.Height = abs[min].Bounds.Height;
            return ret;
        }

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
            Console.WriteLine("F - zmien czcionke ");
            Console.WriteLine("I - instaluj i zmien czcionke ");
            Console.WriteLine("X - zmień rozmiar czcionki ");
            Console.WriteLine("\n curr font: " + KCU.Fonts.GetFontName());

            Size screenSize = closestScreenSize();

            Console.WriteLine(String.Format(
                "screen size (X*Y): {00}x{01} | console size: {02}x{03} | max console size: {04}x{05} | curr font size: {06}", screenSize.Width, screenSize.Height, Console.WindowWidth, Console.WindowHeight, Console.LargestWindowWidth, Console.LargestWindowHeight, Fonts.GetFontSize()));


            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.F:
                    Console.Write("Podaj nazwe czcionki: ");
                    string? fontname = Console.ReadLine();
                    //KCU.Fonts.ChangeFont(fontname);
                    KCU.Fonts.ChangeFont(fontname);
                    Console.WriteLine("test nowej czcionki");
                    Console.ReadKey();
                    goto DebugMain;
                    break;
                 case ConsoleKey.Q:
                    ConsoleMode.Maximize();
                    System.Windows.Forms.SendKeys.SendWait("{F11}");
                    short size = (short)((short) screenSize.Width / 75);
                    Fonts.SetFontSize(size, size);
                    goto DebugMain;
                case ConsoleKey.I:
                    Console.WriteLine("assuming Mx437 IBM BIOS");
                    Console.WriteLine(KCU.Fonts.InstallFont(Path.Combine(AppDomain.CurrentDomain.BaseDirectory ,"Resources", "font.ttf")));
                    KCU.Fonts.ChangeFont("Mx437 IBM BIOS");
                    Console.ReadKey();
                    goto DebugMain;
                    break;
                case ConsoleKey.X:
                    Console.Write("Podaj rozmiar: ");
                    short a;
                    try
                    {
                        a = (short) Int32.Parse(Console.ReadLine());
                    }
                    catch (Exception e)
                    {
                        goto DebugMain;
                    }
                    KCU.Fonts.SetFontSize(a, a);
                    Console.WriteLine("test nowej czcionki"); Console.WriteLine(String.Format(
                "screen size (X*Y): {00}x{01} | console size: {02}x{03} | max console size: {04}x{05}", screenSize.Width, screenSize.Height, Console.WindowWidth, Console.WindowHeight, Console.LargestWindowWidth, Console.LargestWindowHeight));

                    Console.ReadKey();
                    goto DebugMain;
                    break;
                case ConsoleKey.W:
                    DBGPseudoMovement(args);
                    break;
                case ConsoleKey.M:
                    UI.DrawMainMenu(ConsoleColor.White, ConsoleColor.Black, ConsoleColor.Red, ConsoleColor.White);
                    Console.ReadKey();
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

        private class Size
        {
            public int Width { get; set; }
            public int Height { get; set; }
        }
    }
}