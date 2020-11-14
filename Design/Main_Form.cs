using System;
using Newtonsoft.Json;
using System.Windows.Forms;
using System.IO;
using Zork;
using Design.ViewModel;

namespace Zork.Builder
{
    public partial class Main_Form : Form
    {
        private Game Game { get; set; }

        private string GameFilename { get; set; }

        private GameViewModel ViewModel
        {
            get => mViewModel;
            set
            {
                if (mViewModel != value)
                {
                    mViewModel = value;
                    gameViewModelbindingSource.DataSource = mViewModel;
                }
            }
        }

        public Main_Form()
        {
            InitializeComponent();
            //      UpdateTitle();
            //       CreateGame();
            ViewModel = new GameViewModel();
            gameViewModelbindingSource.DataSource = mViewModel;
        }

        //    private void newToolStripMenuItem1_Click(object sender, EventArgs e)
        //    {
        //        CreateGame();
        //    }
        //
        //    private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        //    {
        //
        //        if (string.IsNullOrWhiteSpace(GameFilename))
        //        {
        //            saveToolStripMenuItem.PerformClick();
        //        }
        //        else
        //        {
        //            SaveGame();
        //        }
        //
        //    }
        //
        //    private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        //    {
        //        if (saveFileDialog.ShowDialog() == DialogResult.OK)
        //        {
        //            GameFilename = saveFileDialog.FileName;
        //            UpdateTitle();
        //            SaveGame();
        //        }
        //    }
        //
        //   private void CreateGame()
        //   {
        //       GameFilename = null;
        //       Game = new Game(new World(), null);
        //   }
        //
        //  private void SaveGame()
        //  {
        //      JsonSerializer jsonSerializer = new JsonSerializer() { Formatting = Formatting.Indented };
        //
        //      using (StreamWriter streamWriter = new StreamWriter(GameFilename))
        //      using (JsonWriter jsonWriter = new JsonTextWriter(streamWriter))
        //      {
        //          jsonSerializer.Serialize(jsonWriter, Game);
        //      }
        //  }
        //
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        //      private void UpdateTitle()
        //      {
        //          string gameFilename = string.IsNullOrWhiteSpace(GameFilename) ? "Untitled" : Path.GetFileNameWithoutExtension(GameFilename);
        //          Text = $"Zork Builder - {gameFilename}";
        //      }

        private GameViewModel mViewModel;

        private void FilenameButton_Click(object sender, EventArgs e)
        {
            ViewModel.Game = JsonConvert.DeserializeObject<Game>(File.ReadAllText(openFileDialog.FileName));
            ViewModel.FullPath = openFileDialog.FileName;
        }
    }
}