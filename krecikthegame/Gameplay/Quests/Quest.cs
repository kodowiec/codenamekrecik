namespace Gameplay.Quests
{
    class Quest
    {
        public string Title;
        public string Description;
        public string Hint;
        public string Goal;
        public Quest NextQuest;
        public bool Completed = false;

        public virtual bool IsCompleted() { return Completed; }
        public virtual void SetCompleted() { }
        public Quest(Quest nextQuest)
        {
            NextQuest = nextQuest;
        }

    }
}