using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gameplay.Triggers
{
    internal class Trigger
    {
        public string levelname;
        public string character = "#";
        public int x;
        public int y;

        
        public Trigger(string levelname,int x,int y, string character = "#")
        {
            this.levelname = levelname;
            this.x = x;
            this.y = y;
            this.character = character;
        }

        public virtual void Effect() { }
    }
}
