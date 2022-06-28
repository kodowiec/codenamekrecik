using System;
using System.Drawing;

namespace krecikthegame
{
    internal class MapReader
    {
        public ConsoleColor[,] colors;
        public int lastwidth;
        public int lastheight;
        
        public MapReader() { }

        public void ReadFile(string filename)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", filename);
            Bitmap img = new Bitmap(path);
            colors = new ConsoleColor[img.Width, img.Height];
            lastwidth = img.Width;
            lastheight = img.Height;
            for (int x = 0; x < img.Width; x++)
            {
                for (int y = 0; y < img.Height; y++)
                {
                    Color pixel = img.GetPixel(x, y);
                    switch (pixel)
                    {
                        case var value when value == Color.FromArgb(163, 73, 164):
                            colors[x, y] = ConsoleColor.Magenta;
                            break;
                        case var value when value == Color.White:
                            colors[x, y] = ConsoleColor.White;
                            break;
                        case var value when value == Color.Black:
                            colors[x, y] = ConsoleColor.Black;
                            break;
                        default:
                           Console.WriteLine(x + "  " + y + ":" + pixel.ToString());
                            colors[x, y] = ConsoleColor.Red;
                            break;
                    }
                }
            }
            //Console.WriteLine("width: " + img.Width + " height: " + img.Height);
        }

    }
}
