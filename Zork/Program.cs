using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace Zork
{
    internal class Program
    {
        private static Room CurrentRoom
        {
            get
            {
                return Rooms[Location.Row, Location.Column];
            }
            set
            {
                for (int row = 0; row < Rooms.GetLength(0); row++)
                {
                    for (int column = 0; column < Rooms.GetLength(1); column++)
                    {
                        if (Rooms[Location.Row, Location.Column] == value)
                        {
                            Location = (row, column);
                            return;
                        }
                    }
                }
                throw new Exception("Room not found.");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Zork!");

            const string defaultroomsFilename = "Rooms.json";
            string roomsFilename = args.Length > 0 ? args[(int)CommandLineArguments.RoomsFilename] : defaultroomsFilename;
            InitializeRooms(roomsFilename);

            Room previousRoom = null;
            Commands command = Commands.UNKNOWN;
            while (command != Commands.QUIT)
            {
                Console.Write($"{CurrentRoom}\n");
                if (previousRoom != CurrentRoom)
                {
                    Look();
                    previousRoom = CurrentRoom;
                }

                Console.Write(">");
                string inputString = Console.ReadLine().Trim();
                command = ToCommand(inputString);

                switch (command)
                {
                    case Commands.QUIT:
                        Console.WriteLine("Thank you for playing!");
                        break;

                    case Commands.LOOK:
                        Look();
                        break;

                    case Commands.NORTH:
                    case Commands.SOUTH:
                    case Commands.EAST:
                    case Commands.WEST:
                        if (Move(command) == false)
                        {
                            Console.Write("The way is shut! \n");
                        }
                        break;

                    default:
                        Console.WriteLine("Unknown command.");
                        break;
                }
            }
        }
        private static Commands ToCommand(string commandString) => Enum.TryParse<Commands>(commandString, true, out Commands command) ? command : Commands.UNKNOWN;

        private static void Look()
        {
            Console.WriteLine(CurrentRoom.Description);
        }

        private static bool Move(Commands command)
        {
            Assert.IsTrue(IsDirections.Contains(command), "Invalid command");

            bool didMove = true;
            switch (command)
            {
                case Commands.NORTH when Location.Row < Rooms.GetLength(0) - 1:
                    Location.Row++;
                    break;

                case Commands.SOUTH when Location.Row > 0:
                    Location.Row--;
                    break;

                case Commands.EAST when Location.Column < Rooms.GetLength(1) - 1:
                    Location.Column++;
                    break;

                case Commands.WEST when Location.Column > 0:
                    Location.Column--;
                    break;

                default:
                    didMove = false;
                    break;
            }
            return didMove;
        }

        private static void InitializeRooms(string roomsFilename)
        {
            Rooms = JsonConvert.DeserializeObject<Room[,]>(File.ReadAllText(roomsFilename));

            RoomsByName = new Dictionary<string, Room>();
            foreach (Room room in Rooms)
            {
                RoomsByName.Add(room.Name, room);
            }
        }

        private static Room[,] Rooms;

        private static readonly Commands[] IsDirections =
            {
            Commands.NORTH,
            Commands.SOUTH,
            Commands.EAST,
            Commands.WEST
            };

        private static Dictionary<string, Room> RoomsByName;

        private static (int Row, int Column) Location = (1, 1);

        private enum CommandLineArguments
        {
            RoomsFilename = 0
        }
    }
}

