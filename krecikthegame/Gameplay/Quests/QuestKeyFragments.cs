using System;
namespace Gameplay.Quests
{
    class QuestKeyFragments: Quest
    {
        public QuestKeyFragments(Quest nextQuest) :base(nextQuest)
        {
            Title = "Zaginione fragmenty klucza";
            Description = "Klucz do skrzyni niestety pękł na 3 części aby otworzyć skrzynię poświeć latarką i przyjrzyj się zakamarkom,a odnajdziesz odłamki zaginionego klucza. Znajdź je wszystkie i otwórz skrzynie, aby przejść do dalszego etapu gry.";
            Goal = "Znajdź wszystkie fragmenty klucza";
        }

        public override bool IsCompleted()
        {
            // same
            return true;
        }
    }
}