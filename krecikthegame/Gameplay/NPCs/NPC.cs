using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gameplay
{
    public class NPC
    {
        public string Name { get; set; }    
        public string DisplayCharacter { get; set; }
        public ConsoleColor DisplayColor { get; set; }

        public string LevelName { get; set; }
        public int x { get; }
        public int y { get; }

        public NPC(string levelname, int x, int y, string name, ConsoleColor displayColor, string displayCharacter = "☻")
        {
            Name = name;
            DisplayCharacter = displayCharacter;
            DisplayColor = displayColor;
            LevelName = levelname;
            this.x = x;
            this.y = y;
        }

        public virtual void Interact() { }
    }
}
