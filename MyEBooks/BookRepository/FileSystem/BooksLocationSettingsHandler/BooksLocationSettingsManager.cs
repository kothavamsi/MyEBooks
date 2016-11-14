﻿using System.Configuration;
using MyEBooks.BookRepository.FileSystem.BooksLocationSettingsHandler;
using MyEBooks.LogHandler.Config;
using System.IO;

namespace MyEBooks.LogHandler.LogSettingsHandler
{
    public static class BooksLocationSettingsManager
    {
        static BooksLocationSettingsManager()
        {

        }

        public static void LoadSettings()
        {
            BooksLocationManagerSection blms = (BooksLocationManagerSection)ConfigurationManager.GetSection("booksLocationManager");
            foreach (LocationElement le in blms.Listeners)
            {
                BooksLocationSettings.Locations.Add(le.Location);
            }

            foreach (var location in BooksLocationSettings.Locations)
            {
                var categoryLocations = Directory.GetDirectories(location);
                foreach(string categoryLocation in categoryLocations)
                {

                }
            }
        }
    }
}
