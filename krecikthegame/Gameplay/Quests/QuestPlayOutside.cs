using System;
namespace Gameplay.Quests
{
    class QuestPlayOutside : Quest
    {
        public QuestPlayOutside(Quest nextQuest) : base(nextQuest)
        {
            Title = "Baw się";
            Description = "Zrób coś ciekawego na zewnątrz";
            Goal = Description;
            Hint = "Pobaw się na zewnątrz, może znajdziesz coś ciekawego, co będzie początkiem zupełnie nowej przygody!";
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