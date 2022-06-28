using krecikthegame.Models;
using System.Collections.Generic;

namespace krecikthegame
{
    public class Board
    {
        public MapObject[,] BoardObjects;
        public List<GameAction> Actions;
        public MapReader reader;

        public bool IsFogHere = false;

        public int PlayerX = 10;
        public int prevPlayerX;
        public int PlayerY = 40;
        public int prevPlayerY;

        public int Width;
        public int Height;

        public Board(string levelname)
        {
            reader = new MapReader();
            reader.ReadFile("maps/" + levelname);
            this.BoardObjects = reader.mo;
            this.Width = reader.lastwidth;
            this.Height = reader.lastheight;
        }

        public MapObject GetObject(int x, int y) => BoardObjects[x, y];

        public bool IsCollidable(int x, int y)
        {
            if (BoardObjects[x,y] != null)
            {
                return BoardObjects[x, y].IsColliding;
            }
            else
            {
                return false;
            }
        }

    }
}
