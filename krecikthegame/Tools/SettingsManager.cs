using System.IO;
using System.Text;
using Newtonsoft.Json;
using krecikthegame.UIComponents;

namespace krecikthegame
{
    internal class SettingsManager
    {
        private UserSettings _userSettings;
        private string _settingsPath;

        public SettingsManager(ref UserSettings settings, string settingsFilePath = "")
        {
            if (string.IsNullOrEmpty(settingsFilePath)) this._settingsPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "UserSettings.json");
            else this._settingsPath = Path.Combine(settingsFilePath);

            ReadSettings(out settings);
            this._userSettings = settings;
        }

        public void ReadSettings(out UserSettings settings)
        {
            if (!File.Exists(_settingsPath))
            {
                // let's assume we want to create this file with default values if it doesn't exist
                WriteDefaultSettings();
            }

            try
            {
                string settingsText = File.ReadAllText(this._settingsPath);
                _userSettings = JsonConvert.DeserializeObject<UserSettings>(settingsText);
            }
            catch (Exception ex)
            {
                // this is a simple project, so we won't validate it
                // simple project = simple solution
                // if something's wrong, let's recreate it
                WriteDefaultSettings();
            }

            settings = this._userSettings;
        }

        void WriteDefaultSettings()
        {
            UserSettings defaultSettings = new UserSettings();
            string settingsJson = JsonConvert.SerializeObject(defaultSettings);
            _userSettings = defaultSettings;
            File.WriteAllText(this._settingsPath, settingsJson);
        }

        public bool WriteSettings(ref UserSettings settings)
        {
            string settingsJson = JsonConvert.SerializeObject(settings);
            try
            {
                File.WriteAllText(this._settingsPath, settingsJson);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }

        }
    }
}
