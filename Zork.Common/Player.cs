using Newtonsoft.Json;

namespace Zork
{
   public class Player
    {
        public World World { get; } 
        
        [JsonIgnore]
        public Room Location { get; private set; }

        public Room PreviousRoom { get; set; }

        public Player(World world, string startingLocation)
        {
            Assert.IsTrue(world != null, "World cannot be null");
            World = world;

            Assert.IsTrue(World.RoomsByName.ContainsKey(startingLocation), "Starting location not found in world.");
            Location = world.RoomsByName[startingLocation];
        }

        public bool Move(Directions direction)
        {
            bool didMove = Location.Neighbors.TryGetValue(direction, out Room destination);
            
            if (didMove)
            {
                Location = destination;
            }

            return didMove;
        }
    }
}
