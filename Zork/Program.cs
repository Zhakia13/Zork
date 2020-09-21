using System;
using System.Collections.Generic;
using System.Linq;

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
            InitializeRoomDescription();

            Commands command = Commands.UNKNOWN;
            while (command != Commands.QUIT)
            {
                Console.Write($"{CurrentRoom}\n>");
                string inputString = Console.ReadLine().Trim();
                command = ToCommand(inputString);

                string outputString;
                switch (command)
                {
                    case Commands.QUIT:
                        outputString = "Thank you for playing!";
                        break;

                    case Commands.LOOK:
                        outputString = $"{CurrentRoom.Description}";
                        break;

                    case Commands.NORTH:
                    case Commands.SOUTH:
                    case Commands.EAST:
                    case Commands.WEST:
                        outputString = Move(command) ? $"You moved {command}" : "The way is shut!";
                        break;

                    default:
                        outputString = "Unknown command.";
                        break;
                }
                Console.WriteLine(outputString);
            }
        }
        private static Commands ToCommand(string commandString) => Enum.TryParse<Commands>(commandString, true, out Commands command) ? command : Commands.UNKNOWN;
        
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

        private static bool IsDirection(Commands command) => IsDirections.Contains(command);
      
        private static void InitializeRoomDescription()
        {

            Rooms[0,0].Description = "You are own a rock-strewn trail.";
            Rooms[0,1].Description = "You are facing the south side of a white house. There is no door here, and all the windows are barred.s";
            Rooms[0,2].Description = "You are at the top of the Grand Canyon on its south wall.";
                
            Rooms[1,0].Description = "This is a forest, with trees in all directions around you.";
            Rooms[1,1].Description = "This is an open field west of a white house, with a boarded front door.";
            Rooms[1,2].Description = "You are behind the white house. In one corner of the house there is a small window which is slighty ajar.";
                 
            Rooms[2,0].Description = "This is a dimly lit forest, with large trees all around. To the east, there appears to be sunlight.";
            Rooms[2,1].Description = "You are facing the north side of the white house. There is no door here, and all the windowws are barred.";
            Rooms[2,2].Description = "You are in a clearing, with a forest surrounding you on the west and south.";
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

        private static (int Row, int Column) Location = (1,1);

        
    }
} 

