﻿using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel;
using System;


namespace Zork
{
    public class Room : IEquatable<Room>
    {
#pragma warning disable CS0067
        public event PropertyChangedEventHandler PropertyChanged;
#pragma warning restore CS0067

        [JsonProperty(Order = 1)]
        public string Name { get; set; }

        [JsonProperty(Order = 2)]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "Neighbors", Order = 3)]
        public Dictionary<Directions, string> NeighborNames { get; set; }

        [JsonIgnore]
        public IReadOnlyDictionary<Directions, Room> Neighbors { get; private set; }

        public Room(string name = null)
        {
            Name = name;
        }

        public static bool operator == (Room lhs, Room rhs)
        {
            if (ReferenceEquals(lhs, rhs))
            {
                return true;
            }
            if (lhs is null || rhs is null)
            {
                return false;
            }
            return lhs.Name == rhs.Name;
        }

        public static bool operator !=(Room lhs, Room rhs) => !(lhs == rhs);

        public override bool Equals(object obj) => obj is Room room ? this == room : false;

        public bool Equals(Room other) => this == other;

        public override string ToString() => Name;

        public override int GetHashCode() => Name.GetHashCode();

        public void UpdateNeighbors(World world)
        {
            var neighbors = new Dictionary<Directions, Room>();

            foreach (var entry in NeighborNames)
            {
                neighbors.Add(entry.Key, world.RoomsByName[entry.Value]);
            }
            Neighbors = neighbors;
        }
        
      
    }
}
