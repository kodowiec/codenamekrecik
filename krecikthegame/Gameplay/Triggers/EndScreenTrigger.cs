namespace Gameplay.Triggers
{
    internal class EndScreenTrigger : Trigger
    {
        public EndScreenTrigger(string levelname, int x, int y) : base(levelname, x, y, "X")
        { }

        public override void Effect()
        {
            krecikthegame.EndScreen.Show();
        }


    }
}