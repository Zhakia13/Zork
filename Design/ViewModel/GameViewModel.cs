using Zork;
using System.ComponentModel;
using System.IO;
using Newtonsoft.Json;
using System;

namespace Design.ViewModel
{
   public class GameViewModel: INotifyPropertyChanged
    {
#pragma warning disable CS0067
        public event PropertyChangedEventHandler PropertyChanged;
#pragma warning restore CS0067

        public Game Game
        {       
            set
            {
                if (mGame != value)
                {
                    mGame = value;

                    if (mGame != null)
                    {
                       Rooms = new BindingList<Room>(mGame.World.Rooms);
                    }
                    else
                    {
                        Rooms = new BindingList<Room>(Array.Empty<Room>());
                    }
                }
            }
        }

        public BindingList<Room> Rooms { get; set; }

        public string FullPath { get; set; }

        public string ExitMessage
        {
            get => mGame.ExitMessage;
            set => mGame.ExitMessage = value;
        }

        public string WelcomeMessage
        {
            get => mGame.WelcomeMessage;
            set => mGame.WelcomeMessage = value;
        }

        public string StartingLocation
        {
            get => mGame.StartingLocation;
            set => mGame.StartingLocation = value;
        }

        public GameViewModel( Game game = null)
        {
            Game = game;
        }

        public void SaveGame()
        {
            if (string.IsNullOrEmpty(FullPath))
            {
                throw new InvalidProgramException("Filename expected.");
            }

            JsonSerializer jsonSerializer = new JsonSerializer() { Formatting = Formatting.Indented };

            using (StreamWriter streamWriter = new StreamWriter(FullPath))
            using (JsonWriter jsonWriter = new JsonTextWriter(streamWriter))
            {
                jsonSerializer.Serialize(jsonWriter, mGame);
            }
        }

        private Game mGame;
    }
}
