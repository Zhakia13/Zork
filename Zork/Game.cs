using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Zork
{
    public class Game
    {
        public World World { get; set; }

        public string StartingLocation { get; set; }

        [JsonIgnore]
        public Player Player { get; set; }

        [JsonIgnore]
        public bool IsRunning { get; set; 
        }
        public void Run()
        {
            IsRunning = true;
            while (IsRunning)
            {            
                Console.Write($"{Player.CurrentRoom}\n");
                if (Player.PreviousRoom != Player.CurrentRoom)
                {
                    Look();
                    Player.PreviousRoom = Player.CurrentRoom;
                }

                Console.Write("> ");
                Commands command = ToCommand(Console.ReadLine().Trim());

                switch (command)
                {
                    case Commands.QUIT:
                        IsRunning = false;                     
                        break;

                    case Commands.LOOK:
                        Look();
                        break;

                    case Commands.NORTH:
                    case Commands.SOUTH:
                    case Commands.EAST:
                    case Commands.WEST:
                        if (Player.Move((Directions)command) == false)
                        {
                            Console.Write("The way is shut! \n");
                        }
                        break;

                    default:
                        Console.WriteLine("Unknown command.");
                        break;
                }

               void Look()
                {
                    Console.WriteLine(Player.CurrentRoom.Description);
                }
                 Commands ToCommand(string commandString) => Enum.TryParse<Commands>(commandString, true, out Commands command) ? command : Commands.UNKNOWN;

             [OnDeserialized]

                 void OnDeserialized(StreamingContext context)
                {
                    Player = new Player(World, StartingLocation);
                }
            }
        }
    }
}

