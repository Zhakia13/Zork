using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace Zork
{
    public class Room
    {
        public string Name { get; set; }

        public string Description { get; set; }

        [JsonProperty(PropertyName = "Neighbors")]
        public Dictionary<Directions, string> NeighborNames;

       [JsonIgnore]
        public Dictionary<Directions, Room> Neighbors;

        public Room(string name, string description = null)
        {
            Name = name;
            Description = description;
        }

        public override string ToString() => Name;

        [OnDeserialized]
        private void OnDeserialized(StreamingContext context)
        {
            
        }

    }
}
