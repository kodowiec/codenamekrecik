using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace krecikthegame
{
    internal partial class Game
    {
        private object _player;
        private object _gameboard;
        private object _settings;
 

        public Game() 
        {
            Init();
        }

        private void Init ()
        {
            //throw new NotImplementedException();
        }

        public void Run()
        {
            MainLoop();
            //throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
            // AI
            // other checks
            // then render
        }
    }
}
