using System.Configuration;
using MyEBooks.LogHandler.Config;

namespace MyEBooks.LogHandler.LogSettingsHandler
{
    public static class LogSettingsManager
    {
        static LogSettingsManager()
        {

        }

        public static void LoadSettings()
        {
            LogManagerSection lms = (LogManagerSection)ConfigurationManager.GetSection("logManager");
            LogSettings.Enable = lms.Enable;
            LogSettings.Overwrite = lms.Overwrite;
            foreach (ListenerElement le in lms.Listeners)
            {
                LogSettings.Listeners.Add(new Listener() { ListenerType = le.ListenerType, Path = le.Path });
            }
        }
    }
}
