namespace Gameplay
{
    class QuestManager
    {
        public Quest CurrentQuest;
        
        public QuestManager()
        {
            QuestTorches q4 = new QuestTorches(new QuestBoss());
            QuestLabyrinth q3 = new QuestLabyrinth(q4);
            QuestKeyFragments q2 = new QuestKeyFragments(q3);
            CurrentQuest = new QuestStrawberries(q2);
        }

        public void UpdateState()
        {
            if(CurrentQuest && CurrentQuest.IsCompleted())
            {
                if (CurrentQuest.NextQuest)
                    CurrentQuest = CurrentQuest.NextQuest;
            }
        }
    }
}