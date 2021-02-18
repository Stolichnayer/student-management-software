using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_management_system.Controller
{
    public class ConfigManager
    {
        private static ConfigManager _instance;

        private ConfigManager() {}

        public static ConfigManager GetInstance()
        {
            return _instance ??= new ConfigManager();
        }

}
}
