using Zork;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.IO;
using Newtonsoft.Json;
using System;

namespace Design.ViewModel
{
   public class GameViewModel: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        
        public BindingList<Room> Rooms { get; set; }

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


        public string FullPath
        { get => mFullPath;
            set 
            {
                if (mFullPath != value)
                {
                    mFullPath = value;
                    OnPropertyChanged();
                }
            }
        }


        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));           
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

        private string mFullPath;

        private Game mGame;

    }
}
