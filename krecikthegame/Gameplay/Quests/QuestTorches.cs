using System;
namespace Gameplay.Quests
{
    class QuestTorches : Quest
    {
        public QuestTorches(Quest nextQuest) :base(nextQuest)
        {
            Title = "Zagadka";
            Description = "By otworzyć duże drzwi wędrowniku nagłów się 2 latarnie po prawej i 3 po lewej  nie każda  zaświecić się  chce . Aby zdać test porusz się raz strona prawa , raz strona lewa . Do przodu skocz do tył skocz włącz tę po prawej i raz dwa trzy drzwi otworzysz ty.”";
            Goal = "Rozwiąż zagadkę";
        }

        public override bool IsCompleted()
        {
            // same
            return true;
        }
    }
}