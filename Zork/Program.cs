﻿using System.IO;
using Newtonsoft.Json;

namespace Zork
{
    internal class Program
    {

        static void Main(string[] args)
        {

            const string defaultGameFilename = "Zork.json";
            string gameFilename = args.Length > 0 ? args[(int)CommandLineArguments.RoomsFilename] : defaultGameFilename;

            Game game = JsonConvert.DeserializeObject<Game>(File.ReadAllText(gameFilename));
            game.Run();

        }

        private enum CommandLineArguments
        {
            RoomsFilename = 0
        }
    }
}

