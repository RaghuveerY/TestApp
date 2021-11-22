using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SecurityAPI
{
    public class ApplicationSettingManager
    {
        private const string _settingFilePath = "appsettings.json";
        public DataSetting LoadSettings()
        {
            var text = File.ReadAllText(_settingFilePath);
            if (string.IsNullOrEmpty(text))
                return new DataSetting();

            //get data settings from the JSON file  
            DataSetting settings = JsonConvert.DeserializeObject<DataSetting>(text);
            return settings;
        }

    }
}
