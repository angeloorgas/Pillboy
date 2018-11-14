using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using System.IO;
using proj441.iOS;
using SQLite;

[assembly: Xamarin.Forms.Dependency(typeof(DatabaseConnection_iOS))]
namespace proj441.iOS
{
    public class DatabaseConnection_iOS : IDatabaseConnection //references IDatabaseConnection
    {
        public SQLiteConnection DbConnection()
        {
            var dbName = "PillboyDB.db";
            string personalFolder = System.Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string libraryFolder = Path.Combine(personalFolder, "..", "Library");
            var path = Path.Combine(libraryFolder, dbName);
            return new SQLiteConnection(path);
        }
    }
}