using System;
using System.Linq;

namespace Zork
{

    internal class Program
    {
        private static string CurrentRoom
        {
            get
            {
                return Rooms[Location.Row, Location.Column];
            }
        
            set
            {
                for (int column = 0; column < Rooms.Length; column++)
                {
                    if (Rooms[Location.Column, Location.Row] == value)
                    {
                        Location.Column = column;
                        break;
                    }
                
               }
                throw new Exception("Room not found.");
            }
        }
         static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Zork!");

            Commands command = Commands.UNKNOWN;
            while (command != Commands.QUIT)
            {
                Console.Write($"{CurrentRoom}\n>");
                command = ToCommand(Console.ReadLine().Trim());

                string outputString;
                switch (command)
                {
                    case Commands.QUIT:
                        outputString = "Thank you for playing!";
                        break;

                    case Commands.LOOK:
                        outputString = "This is an open field west of a white house, with a boarded front door.\n A rubber mat saying 'Welcome to Zork!' lies by the door.";
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

            bool found = false;
            foreach (Commands direction in IsDirections)
            {
                if (command == direction)
                {
                    found = true;
                    break;
                }
            }
            if (found == false)
            {
                throw new InvalidOperationException("Invalid Direction");
            }

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
      
        private static readonly string[,] Rooms =
        {

           { "Rocky Trail", "South of House",  "Canyon View" },
           { "Forest", "West of House", "Behind House" },
           { "Dense Woods", "North of House", "Clearing" }

              };
 
        private static readonly Commands[] IsDirections =
            {
            Commands.NORTH,
            Commands.SOUTH,
            Commands.EAST,
            Commands.WEST
            };

        private static (int Row, int Column) Location = (1, 1);
    }
} 

