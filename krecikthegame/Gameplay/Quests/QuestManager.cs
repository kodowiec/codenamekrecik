namespace Gameplay.Quests
{
    class QuestManager
    {
        public Quest CurrentQuest;
        
        public QuestManager()
        {
            QuestTorches q4 = new QuestTorches(new QuestBoss(null));
            QuestLabyrinth q3 = new QuestLabyrinth(q4);
            QuestKeyFragments q2 = new QuestKeyFragments(q3);
            CurrentQuest = new QuestStrawberries(q2);
        }

        public void UpdateState()
        {
            if(CurrentQuest != null && CurrentQuest.IsCompleted())
            {
                if (CurrentQuest.NextQuest != null)
                    CurrentQuest = CurrentQuest.NextQuest;
            }
        }
    }
}