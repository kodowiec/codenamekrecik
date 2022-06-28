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

        public UserSettings settings;
        public SettingsManager settingsManager;
 
        public Game() 
        {
            settings = new UserSettings();
            SettingsManager settingsManager = new SettingsManager(ref settings, Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "UserSettings.json"));
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
