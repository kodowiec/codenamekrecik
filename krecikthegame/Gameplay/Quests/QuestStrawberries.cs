using System;
namespace Gameplay
{
    class QuestStrawberries: Quest
    {
        const int Amount = 10;
        public QuestStrawberries(Quest nextQuest) :base(nextQuest)
        {
            Title = "Wnusiu idź nazbieraj truskawek na kompot";
            Description = String.Format("Zbierz {0} truskawek dla babci", Amount);
        }

        public override global::System.Boolean IsCompleted()
        {
            // TUTAJ POTRZEBNE JEST ODWOŁANIE DO GRACZA (STATYCZNA KLASA GAME???);
            return true;
        }
    }
}