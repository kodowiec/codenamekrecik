﻿using Gameplay.Triggers;
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
            triggers.Add(new ChangeLevelTrigger("level1", 54, 2, "level2"));
            triggers[0].character = "▲";
            triggers.Add(new ChangeLevelTrigger("level2", 55, 10, "level3"));
            triggers[1].character = "◙";
            triggers.Add(new ChangeLevelTrigger("level2", 15, 38, "level1"));
            triggers[2].character = "▼";
            triggers.Add(new EndScreenTrigger("level3", 44, 7));
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
