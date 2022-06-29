namespace Gameplay
{
    class QuestBoss : Quest
    {
        public QuestBoss(Quest nextQuest) :base(nextQuest)
        {
            Title = "Pan Puszek";
            Description = "Pokonaj Pana Puszka aby zdobyć skarb.";
        }

        public override bool IsCompleted()
        {
            // same
            return true;
        }
    }
}