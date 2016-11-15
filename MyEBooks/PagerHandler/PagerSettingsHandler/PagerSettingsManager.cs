using System.Configuration;
using MyEBooks.LogHandler.Config;
using MyEBooks.PagerHandler.Config;

namespace MyEBooks.PagerHandler.PagerSettingsHandler
{
    public static class PagerSettingsManager
    {
        static PagerSettingsManager()
        {

        }

        public static void LoadSettings()
        {
            PagerManagerSection pms = (PagerManagerSection)ConfigurationManager.GetSection("pagerManager");
            PagerSettings.PagerDisplayLength = pms.PagerDisplayLength;
            PagerSettings.PageSize = pms.PageSize;
        }
    }
}

