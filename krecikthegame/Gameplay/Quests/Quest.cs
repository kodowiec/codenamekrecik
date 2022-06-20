namespace Gameplay
{
    class Quest
    {
        public string Title;
        public string Description;
        public Quest NextQuest;

        public virtual bool IsCompleted() { }
        public Quest(Quest nextQuest)
        {
            NextQuest = nextQuest;
        }

    }
}