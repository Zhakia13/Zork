using System.Data.Common;
using System; 

namespace Zork
{
   public class Player
    {
        public World World { get; } 
        
        public Room CurrentRoom { get; private set; }

        public Room PreviousRoom { get; set; }

        public int Score { get; set; }

        public int Moves { get; set; }

        public Player(World world, string startingLocation)
        {
            Assert.IsTrue(world != null, "World cannot be null");
            World = world;

            Assert.IsTrue(World.RoomsByName.ContainsKey(startingLocation), "Starting location not found in world.");
            CurrentRoom = World.RoomsByName[startingLocation];
        }

        public bool Move(Directions direction)
        {
            bool didMove = false;
            
            if (CurrentRoom.NeighborNames.ContainsKey(direction))
            {
                PreviousRoom = CurrentRoom;
                string neighnorName = CurrentRoom.NeighborNames[direction];
                CurrentRoom = World.RoomsByName[neighnorName];

                didMove = true;
            }

            return didMove;
        }
    }
}
