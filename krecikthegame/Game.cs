using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using krecikthegame.Models;
using Gameplay.Items;
using Gameplay;

namespace krecikthegame
{
    internal partial class Game
    {
        private Gameplay.Player _player;
        private Board _currentboard;
        private string levelname = "level1";

        public UserSettings settings;
        public SettingsManager settingsManager;
        public List<MapObject> mapObjects;
        public List<Board> boards;

        private bool showHUD = true;
        private bool showInventory = true;
        public bool debugMode = false;
        public string lastAction = "";


        public Game() => Init();
        

        private void Init ()
        {
            this.settings = new UserSettings();
            this.settingsManager = new SettingsManager(ref settings, Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "UserSettings.json"));
            settingsManager.ReadSettings(out this.settings);
            mapObjects = ObjectLoader.mapObjects("mapobjects.json");

            boards = new List<Board>();
            boards.Add(new Board("level1"));
            boards.Add(new Board("level2"));
            boards.Add(new Board("level3"));

            InitTriggers();
            _currentboard = boards.Find(b => b.LevelName == "level1");
            _player = GameplayStatics.GetPlayer();
        }

        public void ChangeLevel(string levelname)
        {
            if (this.levelname == "level2" && levelname == "level3" && GameplayStatics.Player.QM.CurrentQuest.Title != "Baw się")
            {
                return;
            }
            else if (this.levelname == "level2" && levelname == "level3" && GameplayStatics.Player.QM.CurrentQuest.Title == "Baw się")
            {
                GameplayStatics.Player.QM.CurrentQuest.SetCompleted();
                GameplayStatics.Player.QM.UpdateState();
            }
                this.levelname = levelname;
            lastAction = "";
            _currentboard.PlayerX = _currentboard.prevPlayerX;
            _currentboard.PlayerY = _currentboard.prevPlayerY;
            _currentboard = boards.Find(b => b.LevelName == levelname);
            Console.Clear();
            if (levelname != "level3") Render(false);
        }

        public void Run()
        {
            
            Gameplay.GameplayStatics.InitPlayer();
            Gameplay.GameplayStatics.Game = this;
            Render(false);
            MainLoop();
        }

        public void Update(bool partial = true)
        {
            // AI
            // other checks
            UpdateTriggers();
            Render(partial);
        }
    }
}
