using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Collections.Generic;
using Zork.Common;
using System.Linq;

namespace Zork
{
    public class Game : INotifyPropertyChanged
    {
#pragma warning disable CS0067
        public event PropertyChangedEventHandler PropertyChanged;
#pragma warning restore CS0067

        public World World { get; set; }

        public string StartingLocation { get; set; }

        public string WelcomeMessage { get; set; }

        public string ExitMessage { get; set; }

        [JsonIgnore]
        public Player Player { get; set; }

        [JsonIgnore]
        public bool IsRunning { get; set; }

        [JsonIgnore]
        public Dictionary<string, Command> Commands { get; private set; }

        public Game(World world, Player player)
        {

            World = world;
            Player = player;

            Commands = new Dictionary<string, Command>()
            {
               {"Quit", new Command("Quit", new string []{ "Q", "Quit"}, Quit)},
               {"Look", new Command("Look", new string []{ "L", "Look"}, Look)},
               {"North", new Command("North", new string []{ "N", "North"}, game => Move(game, Directions.NORTH))},
               {"South", new Command("South", new string []{ "S", "South"}, game => Move(game, Directions.SOUTH))},
               {"East", new Command("East", new string []{ "E", "East"}, game => Move(game, Directions.EAST))},
               {"West", new Command("West", new string []{ "W", "West"}, game => Move(game, Directions.WEST))},
            };
        }

        public void Run()
        {
            Console.WriteLine(string.IsNullOrWhiteSpace(WelcomeMessage) ? "Welcome to Zork!" : WelcomeMessage);

            IsRunning = true;
            while (IsRunning)
            {
                Console.Write($"{Player.Location}\n");
                if (Player.PreviousRoom != Player.Location)
                {
                    Look(this);
                    Player.PreviousRoom = Player.Location;
                }

                Console.Write("> ");
                string commandString = Console.ReadLine().Trim().ToUpper();

                Command foundCommand = null;
                foreach (Command command in Commands.Values)
                {
                    if (command.Verbs.Contains(commandString))
                    {
                        foundCommand = command;
                        break;
                    }
                }

                if (foundCommand != null)
                {
                    foundCommand.Action(this);
                }
                else
                {
                    Console.WriteLine("Unkown command.");
                }
            }

            Console.WriteLine(string.IsNullOrWhiteSpace(ExitMessage) ? "Thank you for playing!" : ExitMessage);
        }

        static void Move(Game game, Directions direction)
        {
            if (game.Player.Move(direction) == false)
            {
                Console.WriteLine("The way is shut!");
            }
        }

        static void Look(Game game)
        {
            Console.WriteLine(game.Player.Location.Description);
        }

        static void Quit(Game game)
        {
            game.IsRunning = false;
        }

        [OnDeserialized]

        void OnDeserialized(StreamingContext context) => Player = new Player(World, StartingLocation);
    }
}

