﻿using System;
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

        static Program()
        {
            RoomsByName = new Dictionary<string, Room>();
            foreach (Room room in Rooms)
            {
                RoomsByName.Add(room.Name, room);
            }
        }

        static void Main(string[] args)
        {

            const string roomsFilename = "Rooms.txt"; 

            Console.WriteLine("Welcome to Zork!");
            InitializeRoomDescriptions(roomsFilename);

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

        private static void InitializeRoomDescriptions(string roomsFilename)
        {
            const string separator = "##";
            const int expectedFieldCount = 2;

            string[] lines = File.ReadAllLines(roomsFilename);
            foreach (string line in lines)
            {
                string[] fields = line.Split(separator);
                if (fields.Length != expectedFieldCount)
                {
                    throw new InvalidDataException("Invalid record in file.");
                }

                string name = fields[(int)Fields.Name];
                string description = fields[(int)Fields.Description];
                RoomsByName[name].Description = description;
            }
 }

        private static readonly Room[,] Rooms =
        {

           {new Room ("Rocky Trail"), new Room("South of House"), new Room("Canyon View")},
           {new Room ("Forest"), new Room("West of House"), new Room("Behind House")},
           {new Room ("Dense Woods"), new Room("North of House"), new Room("Clearing")}

              };

        private static readonly Commands[] IsDirections =
            {
            Commands.NORTH,
            Commands.SOUTH,
            Commands.EAST,
            Commands.WEST
            };

        private static readonly Dictionary<string, Room> RoomsByName;

        private static (int Row, int Column) Location = (1, 1);

        private enum Fields
        {
            Name = 0,
            Description = 1
        }
    }
}

