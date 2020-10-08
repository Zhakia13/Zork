using System;
using System.IO;
using Newtonsoft.Json;

namespace Zork
{
    internal class Program
    { 

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Zork!");

            const string defaultGameFilename = "Zork.json";
            string gameFilename = args.Length > 0 ? args[(int)CommandLineArguments.RoomsFilename] : defaultGameFilename;
                   
           Game game = JsonConvert.DeserializeObject<Game>(File.ReadAllText(gameFilename));
           game.Run();

           Console.WriteLine("Thank you for playing!");

        }
        

        private enum CommandLineArguments
        {
            RoomsFilename = 0
        }
    }
}

