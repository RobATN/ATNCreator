using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Serializable]
    public class Settings
    {
        public Settings(String _user, String _password, String _server, String _database)
        {
            User = _user;
            Password = _password;
            Server = _server;
            Database = _database;
        }

        public String User { get; private set; }
        public String Password { get; private set; }
        public String Server { get; private set; }
        public String Database { get; private set; }

        public static Settings SettingsLaden(String Path)
        {
            Settings settings;
            using (FileStream stream = new FileStream(Path, FileMode.Open))
            {

                BinaryFormatter bf = new BinaryFormatter();

                settings = (Settings)bf.Deserialize(stream);
            }

            return settings;
        }

        public static void SettingsSpeichern(Settings s, String Path)
        {
            using (FileStream stream = new FileStream(Path, FileMode.Create))
            {

                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(stream, s);
            }
        }
    }
}
