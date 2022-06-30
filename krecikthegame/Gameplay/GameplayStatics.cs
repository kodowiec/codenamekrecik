using krecikthegame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gameplay
{
    internal static class GameplayStatics
    {
        public static Player Player;
        public static Game Game { get;  set; }

        public static void InitPlayer()
        {
            if(Player == null)
                Player = new Player();
        }

        public static Player GetPlayer() => Player;

        public static Quests.Quest GetCurrentQuest()
        {
            if (Player != null)
                return Player.QM.CurrentQuest;
            return null;
        }
    }
}
