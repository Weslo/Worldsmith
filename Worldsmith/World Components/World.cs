using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Worldsmith
{
    public class World
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string WorldMapName { get; set; }
        public Dictionary<string, Map> Maps { get; set; }

        public World(string name)
        {
            Name = name;
            Maps = new Dictionary<string, Map>();
        }

        public void AddMap(Map map)
        {
            Maps.Add(map.Name, map);
        }

        public override string ToString()
        {
            string output = JsonConvert.SerializeObject(this, Formatting.Indented);
            return output;
        }
    }
}
