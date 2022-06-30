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
        public int x;
        public int y;

        public Trigger(string levelname, int x, int y)
        {
            this.levelname = levelname;
            this.x = x;
            this.y = y;
        }

        public virtual void Effect() { }
    }
}
