using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class NPC_HelperClass
    {
        private string settings;

        public NPC_HelperClass(String _settings)
        {
            settings = _settings;
        }

        public static void CreateNPC()
        {
            
        }

        public int CreateEntryID()
        {
            Database db = new Database(settings);
            return db.GetNewEntryID("entry", "creature_template");
        }

        public DataTable SearchNPCbyName(String name)
        {
            Database db = new Database(settings);

            DataTable dt = db.SelectMySQLQuery("entry, name, subname", "creature_template", "name", "LIKE", "'%"+name+"%'");
            return dt;
        }

        public DataTable SearchNPCbyID(int id)
        {
            Database db = new Database(settings);

            DataTable dt = db.SelectMySQLQuery("entry, name, subname", "creature_template", "entry", "=", id.ToString());
            return dt;
        }
    }

    [Serializable]
    public class NPCLastUsed
    {
        public List<NPCLastUsedData> lastUsed { get; set; }

        public NPCLastUsed()
        {
            lastUsed = new List<NPCLastUsedData>();
        }
    }

    [Serializable]
    public class NPCLastUsedData
    {
        public String Name { get; private set; }
        public int entryID { get; private set; }
    }
}
