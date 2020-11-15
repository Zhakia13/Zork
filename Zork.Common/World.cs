using Newtonsoft.Json;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ComponentModel;

namespace Zork
{
   public class World : INotifyPropertyChanged
    {
#pragma warning disable CS0067
        public event PropertyChangedEventHandler PropertyChanged;
#pragma warning restore CS0067

        public List<Room> Rooms { get; set; } 

        [JsonIgnore]
        public IReadOnlyDictionary<string, Room> RoomsByName => mRoomsByName;

        public World()
        {
            Rooms = new List<Room>();
            mRoomsByName = new Dictionary<string, Room>();
        }

        [OnDeserialized]
        private void OnDeserialized(StreamingContext context)
        {
            foreach (Room room in Rooms)
            {
                mRoomsByName.Add(room.Name, room);
            }

            foreach (Room room in Rooms)
            {
                room.UpdateNeighbors(this);
            }
        }

        private Dictionary<string, Room> mRoomsByName = new Dictionary<string, Room>();
    }
}
