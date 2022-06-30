using Gameplay.Triggers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace krecikthegame
{
    partial class Game
    {
        public List<Trigger> triggers;

        public void InitTriggers()
        {
            triggers = new List<Trigger>();
            triggers.Add(new ChangeLevelTrigger("level2", 55, 10, "level3"));
        }

        public void UpdateTriggers()
        {
            triggers.ForEach(trigger =>
            {
                if(levelname == trigger.levelname && _currentboard.PlayerX == trigger.x && _currentboard.PlayerY == trigger.y)
                {
                    trigger.Effect();
                }
            });
        }

    }
}
