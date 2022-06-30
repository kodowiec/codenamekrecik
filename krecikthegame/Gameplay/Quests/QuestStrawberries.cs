using System;
namespace Gameplay.Quests
{
    class QuestStrawberries: Quest
    {
        const int Amount = 10;
        public QuestStrawberries(Quest nextQuest) :base(nextQuest)
        {
            Title = "Truskawki";
            Description = String.Format("Zbierz {0} truskawek dla babci", Amount);
            Hint = "Wnusiu idź nazbieraj truskawek na kompot";
            Goal = Description;
        }

        public override void SetCompleted()
        {
            this.Completed = true;
        }

        public override bool IsCompleted()
        {
            return this.Completed;
        }
    }
}