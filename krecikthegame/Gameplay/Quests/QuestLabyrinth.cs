using System;
namespace Gameplay
{
    class QuestLabyrinth : Quest
    {
        public QuestLabyrinth(Quest nextQuest) :base(nextQuest)
        {
            Title = "Labirynt";
            Description = "Znajdź drogę do wyjścia.";
        }

        public override bool IsCompleted()
        {
            // tutaj mozna sprawdzić na jakim levelu znajudje się gracz
            // jeśli znajduje się na innym niz labirynt zwracamy true
            return true;
        }
    }
}