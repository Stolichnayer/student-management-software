namespace StudentManagementSystem.Controller
{
    public class ConfigurationFileManager
    {
        private static ConfigurationFileManager _instance;

        private ConfigurationFileManager() {}

        public static ConfigurationFileManager GetInstance()
        {
            return _instance ??= new ConfigurationFileManager();
        }
    }
}
