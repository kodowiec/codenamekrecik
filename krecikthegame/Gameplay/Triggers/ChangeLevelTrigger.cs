using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gameplay.Triggers
{
    internal class ChangeLevelTrigger: Trigger
    {
        string Destination;
        public ChangeLevelTrigger(string levelname, int x, int y, string destination) : base(levelname, x, y)
        {
            this.Destination = destination;
        }

        public override void Effect()
        {
            GameplayStatics.Game.ChangeLevel(Destination);
        }


    }
}
