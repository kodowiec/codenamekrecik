using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using krecikthegame.Models;

namespace krecikthegame
{
    internal partial class Game
    {
        private object _player;
        private Board _currentboard;
        private string levelname = "level2";

        public UserSettings settings;
        public SettingsManager settingsManager;
        public List<MapObject> mapObjects;

        private bool showHUD = true;
 
        public Game() => Init();
        

        private void Init ()
        {
            settings = new UserSettings();
            SettingsManager settingsManager = new SettingsManager(ref settings, Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "UserSettings.json"));
            mapObjects = ObjectLoader.mapObjects("mapobjects.json");

            _currentboard = new Board(this.levelname + ".png");
        }

        public void Run()
        {
            Render(false);
            MainLoop();
        }

        public void Update()
        {
            // AI
            // other checks
            Render();
        }
    }
}
