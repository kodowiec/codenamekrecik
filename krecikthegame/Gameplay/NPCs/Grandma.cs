using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gameplay
{
    public class Grandma : NPC
    {
        public Grandma(string levelname, int x, int y, string name = "Babcia", ConsoleColor displayColor = ConsoleColor.Magenta, string displayCharacter = "☻") : base(levelname, x, y, name, displayColor, displayCharacter)
        { }

        public override void Interact()
        {
            if(GameplayStatics.Player.QM.CurrentQuest.Title == "Rozmowa")
            {
                // dialog przed truskawkami
                krecikthegame.UI.DrawDialogue("Babcia", "Dzień dobry wnusiu widzę, że już wstałeś więc  czas na śniadanie.", ConsoleColor.Red, ConsoleColor.White, "Jaki dziś ładny dzień");
                krecikthegame.UI.DrawDialogue("Babcia", "Zgadza się. Co byś chciał zjeść?.", ConsoleColor.Red, ConsoleColor.White, "Naleśniki z truskawkami");
                krecikthegame.UI.DrawDialogue("Babcia", "Dobrze się składa , bo zostało jeszcze kilka truskawek na naleśniki.", ConsoleColor.Red, ConsoleColor.White, "Mamy jeszcze kompot z truskawek?");
                krecikthegame.UI.DrawDialogue("Babcia", "Niestety nie. I zabraknie nam truskawek  abym zrobiła  kompot.\n   Więc jeżeli chcesz się go napić,\n   musisz iść nazbierać truskawek przed śniadaniem", ConsoleColor.Red, ConsoleColor.White, "Ile trzeba ich uzbierać?");
                krecikthegame.UI.DrawDialogue("Babcia", "Aby zrobić kompot. Musisz uzbierać 10 truskawek", ConsoleColor.Red, ConsoleColor.White, "A więc idę.");
            
                GameplayStatics.Player.QM.CurrentQuest.SetCompleted();
                GameplayStatics.Player.QM.UpdateState();
            }
            else if (GameplayStatics.Player.QM.CurrentQuest.Title == "Truskawki")
            {
                if (GameplayStatics.Player.EQ.HasItem(Items.ItemType.STRAWBERRY) && GameplayStatics.Player.EQ.CountOfType(Items.ItemType.STRAWBERRY) >= 10)
                {
                    krecikthegame.UI.DrawDialogue("Babcia", "O wnusiu nie sądziłam, że tak szybko nazbierasz naszych ulubionych owoców\n   Opowiedz jak tam pogoda na dworze?", ConsoleColor.Red, ConsoleColor.White, "Najlepsza pogoda na dojrzewanie naszych ukochanych truskawek");
                    krecikthegame.UI.DrawDialogue("Babcia", "Cieszę się bardzo.\n   Jak zrobię Ci śniadanko wyjdę podlać nasze truskawki.", ConsoleColor.Red, ConsoleColor.White, "Jeżeli chcesz babciu , mogę to zrobić.");
                    krecikthegame.UI.DrawDialogue("Babcia", "Dziękuję za pomoc, ale zrobię to sama.\n   Bardzo lubię tę czynność, bardzo mnie odpręża i przy takiej pogodzie,\n   aż nie chce się siedzieć w domu. A teraz wnusiu idź się pobaw.\n   A ja przygotuje nam śniadanie. Tylko pamiętaj gdy wrócisz umyj ręce", ConsoleColor.Red, ConsoleColor.White, "Dobrze babciu!");

                    GameplayStatics.Player.EQ.RemoveItem(Items.ItemType.STRAWBERRY, 10);
                    GameplayStatics.Player.QM.CurrentQuest.SetCompleted();
                    GameplayStatics.Player.QM.UpdateState();

                }
                else
                {
                    krecikthegame.UI.DrawDialogue("Babcia", "Nie uzbierałeś 10 truskawek", ConsoleColor.Red, ConsoleColor.White, "Zaraz wracam!");

                }
            }
            else
            {
                krecikthegame.UI.DrawDialogue("Babcia", "Piękny dziś mamy dzień, nieprawdaż?", ConsoleColor.Red, ConsoleColor.White, "Prawda, Babciu!");

            }
        }
    }
}
