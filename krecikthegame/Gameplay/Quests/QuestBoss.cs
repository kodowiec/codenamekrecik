namespace Gameplay.Quests
{
    class QuestBoss : Quest
    {
        public QuestBoss(Quest nextQuest) :base(nextQuest)
        {
            Title = "Pan Puszek";
            Description = "Pokonaj Pana Puszka aby zdobyć skarb.";
            Goal = "Pokonaj Pana Puszka";
        }

        public override bool IsCompleted()
        {
            // same
            return true;
        }
    }
}