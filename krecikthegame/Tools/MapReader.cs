using System;
using System.Drawing;
using krecikthegame.Models;

namespace krecikthegame
{
    public class MapReader
    {
        public ConsoleColor[,] colors;
        public string[,] chars;
        public int lastwidth;
        public int lastheight;
        public MapObject[,] mo;

        public MapReader() { }

        public void ReadFile(string filename)
        {
            List<MapObject> objects = ObjectLoader.mapObjects("mapobjects.json");
            Console.ForegroundColor = ConsoleColor.Green;
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", filename);
            Bitmap img = new Bitmap(path);
            chars = new string[img.Width, img.Height];
            colors = new ConsoleColor[img.Width, img.Height];
            mo = new MapObject[img.Width, img.Height];
            lastwidth = img.Width;
            lastheight = img.Height;
            for (int x = 0; x < img.Width; x++)
            {
                for (int y = 0; y < img.Height; y++)
                {
                    Color pixel = img.GetPixel(x, y);

                    ConsoleColor colorTD = ConsoleColor.White;
                    MapObject? obj = objects.Find(x => x.ColorID == System.Drawing.ColorTranslator.ToHtml(pixel));
                    //if (objects.Find(x => x.ColorID == System.Drawing.ColorTranslator.ToHtml(pixel)) != null) colorTD = objects.Find(x => x.ColorID == System.Drawing.ColorTranslator.ToHtml(pixel)).DrawColor;
                    //if (obj != null && pixel.IsNamedColor) colorTD = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), pixel.Name);
                    if (obj != null)
                    {
                        chars[x, y] = obj.Display;
                        colorTD = obj.DrawColor;
                        mo[x, y] = obj;
                    }
                    colors[x, y] = colorTD;
                }
            }
            //Console.WriteLine("width: " + img.Width + " height: " + img.Height);
        }

    }
}
