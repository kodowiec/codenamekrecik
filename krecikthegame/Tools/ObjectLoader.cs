using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using krecikthegame.Models;

namespace krecikthegame
{
    internal class ObjectLoader
    {
        public static List<MapObject> mapObjects(string filename)
        {
            string objlist = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "maps", filename));
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<MapObject>>(objlist);
        }
    }
}
