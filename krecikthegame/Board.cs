using Gameplay;
using krecikthegame.Models;
using System.Collections.Generic;

namespace krecikthegame
{
    public class Board
    {
        public MapObject[,] BoardObjects;
        public List<GameAction> Actions;
        public List<NPC> NPCs;
        public MapReader reader;
        public string LevelName;

        public bool IsFogHere = false;
        public bool FlashlightTurnedOn = false;

        public int PlayerX = 10;
        public int prevPlayerX;
        public int PlayerY = 40;
        public int prevPlayerY;

        public int Width;
        public int Height;

        public Board(string levelname)
        {
            Console.Clear();
            LevelName = levelname;
            reader = new MapReader();
            reader.ReadFile(levelname + ".png");
            this.BoardObjects = reader.mo;
            this.Width = reader.lastwidth;
            this.Height = reader.lastheight;

            this.NPCs = new List<NPC>();
            if (levelname == "level1") this.NPCs.Add(new Grandma("level1", 41, 15));

            switch(levelname)
            {
                case "level1":
                    PlayerX = 32;
                    PlayerY = 27;
                    break;
                case "level2":
                    PlayerX = 14;
                    PlayerY = 37;
                    break;
                case "level3":
                    PlayerX = 13;
                    PlayerY = 37;
                    break;
                default: 
                    break;
            }
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
