namespace Gameplay.Quests
{
    class Quest
    {
        public string Title;
        public string Description;
        public string Goal;
        public Quest NextQuest;

        public virtual bool IsCompleted() { return false; }
        public Quest(Quest nextQuest)
        {
            NextQuest = nextQuest;
        }

    }
}