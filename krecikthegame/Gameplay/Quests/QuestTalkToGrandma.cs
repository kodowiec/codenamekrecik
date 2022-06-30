using System;
namespace Gameplay.Quests
{
    class QuestTalkToGrandma : Quest
    {
        public QuestTalkToGrandma(Quest nextQuest) : base(nextQuest)
        {
            Title = "Rozmowa";
            Description = "Porozmawiaj z babcią";
            Hint = "Jesteś głodny! Znajdź babcię i jej o tym powiedz!";
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