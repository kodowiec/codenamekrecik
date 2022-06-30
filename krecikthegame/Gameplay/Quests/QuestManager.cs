namespace Gameplay.Quests
{
    class QuestManager
    {
        public Quest CurrentQuest;
        
        public QuestManager()
        {
            QuestTorches q4 = new QuestTorches(new QuestBoss(null));
            QuestLabyrinth q3 = new QuestLabyrinth(q4);
            QuestPlayOutside q5 = new QuestPlayOutside(q3);
            QuestKeyFragments q2 = new QuestKeyFragments(q3);
            QuestStrawberries q1 = new QuestStrawberries(q5);
            QuestTalkToGrandma q0 = new QuestTalkToGrandma(q1);
            CurrentQuest = q0;
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