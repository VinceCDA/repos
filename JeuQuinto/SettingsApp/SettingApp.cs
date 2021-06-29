using System;

namespace SettingsApp
{

    public class SettingApp
    {
        private string _path;
        private int _settingNbRound;
        private int _settingNbpointByError;
        private int _settingNbError;
        private int _settingNbPointByTick;

        public string Path { get => _path; set => _path = value; }
        public int SettingNbRound { get => _settingNbRound; set => _settingNbRound = value; }
        public int SettingNbpointByError { get => _settingNbpointByError; set => _settingNbpointByError = value; }
        public int SettingNbError { get => _settingNbError; set => _settingNbError = value; }
        public int SettingNbPointByTick { get => _settingNbPointByTick; set => _settingNbPointByTick = value; }
        
    }
}
