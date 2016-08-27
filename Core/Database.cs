using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Core
{
    public class Database
    {
        Settings settings;
        MySqlConnection conn;

        public Database(String SettingsPath)
        {
            try
            {
                //Datenbank Einstellungen aus Datei laden
                settings = Settings.SettingsLaden(SettingsPath);

                //Connection String mit den neuen Infos aus den Settings bauen
                conn = new MySqlConnection("server=" + settings.Server + ";database=" + settings.Database + ";uid=" + settings.User + ";password=" + settings.Password + ";");
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Fehler: Database(String SettingsPath)\n\n" + ex.ToString());
            }
        }

        public bool connectToDatabase()
        {
            //Verbindung öffnen
            conn.Open();

            if (conn.State == ConnectionState.Open) //Verbindung offen?
                return true;
            else
                return false;
        }

        public bool CloseConnectionToDatabase()
        {
            //Verbindung schließen
            conn.Close();

            if (conn.State == ConnectionState.Closed) //Verbindung geschlossen?
                return true;
            else
                return false;
        }


        public DataTable SelectMySQLQuery(string what, string table, string where, string LIKEorNOTorBLA, string thing)
        {
            //Verbinden und wenns nicht klappt -> return null
            if (!connectToDatabase())
            {
                System.Diagnostics.Debug.WriteLine("Database:SelectMySQLQuery\nVerbindung zur Datenbank nicht möglich!");
                return null;
            }

            //Mysql Befehls String bauen
            MySqlCommand cmd = new MySqlCommand("SELECT " + what + " FROM " + table + " WHERE " + where + " " + LIKEorNOTorBLA + " " + thing, conn);
            //Ich will in der Debug Ausgabe sehen was zum geier da fürn String gebaut wird
            System.Diagnostics.Debug.WriteLine("MYSQL Query: SELECT " + what + " FROM " + table + " WHERE " + where + " " + LIKEorNOTorBLA + " " + thing + "\n");

            //Ergebnisse von der DB holen und im DataReader speichern
            MySqlDataReader dr = cmd.ExecuteReader();

            DataTable dt = new DataTable();

            //Laden der Daten vom Reader in die DatenTabelle
            dt.Load(dr);
            //Brav den Rader schließen
            dr.Close();

            //Datenbankverbindung trennen
            CloseConnectionToDatabase();

            return dt;
        }

        public int GetNewEntryID(string entrytype, string table)
        {
            //Verbinden und wenns nicht klappt -> return null
            if (!connectToDatabase())
            {
                System.Diagnostics.Debug.WriteLine("Database:SelectMySQLQuery\nVerbindung zur Datenbank nicht möglich!");
                return -1;
            }

            int entry = 0;

            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT " + entrytype + " FROM " + table + " ORDER BY entry DESC LIMIT 0, 1;", conn);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entry = Convert.ToInt32(dr[0].ToString()) + 1;
                }
                dr.Close();

                conn.Close();
            }
            catch (MySqlException ex)
            {

                System.Diagnostics.Debug.WriteLine("Fehler: GetNewEntryID(string entrytype, string table)\n\n" + ex.ToString());
            }

            return entry;
        }

        public static bool TryLogin(String _user, String _password, String _server, String _database)
        {
            string connectionString;

            connectionString = "SERVER=" + _server + ";" + "DATABASE=" + _database + "; " + "UID=" + _user + ";" + "PASSWORD=" + _password + ";";

            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Fehler: TryLogin(String _user, String _password, String _server, String _database)\n\n" + ex.ToString());
                return false;
            }
        }
    }
}
