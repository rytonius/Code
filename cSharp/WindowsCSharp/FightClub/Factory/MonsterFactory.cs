using FightClub.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClub.Factory
{
    public class MonsterFactory
    {
        string jsonString;
        List<NPCEnemy> NPCList = new List<NPCEnemy>();


        public MonsterFactory() {

            jsonString = File.ReadAllText(".\\Data\\MonsterStats.json");
            NPCList = JsonConvert.DeserializeObject<List<NPCEnemy>>(jsonString);
        }
        public NPCEnemy CreateNPC(int idToFind)
        {
            NPCEnemy NPC = NPCList.Find(p => p.Id == idToFind);
            NPC.Init();
            return NPC;
        }
    }
}
