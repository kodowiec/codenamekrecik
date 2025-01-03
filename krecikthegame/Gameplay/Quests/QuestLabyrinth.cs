﻿using System;
namespace Gameplay.Quests
{
    class QuestLabyrinth : Quest
    {
        public QuestLabyrinth(Quest nextQuest) :base(nextQuest)
        {
            Title = "Labirynt";
            Description = "Znajdź drogę do wyjścia.";
            Hint = "Przedostań się przez ciemny labirynt";
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