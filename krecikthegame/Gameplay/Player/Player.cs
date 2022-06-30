using Gameplay.Quests;
namespace Gameplay
{
    class Player
    {
        float MaxHP = 100;
        float CurrentHP = 100;
        public Equipment EQ = new Equipment();
        public QuestManager QM = new QuestManager();
    }

}