using System;
using Newtonsoft.Json;
using System.Windows.Forms;
using System.IO;
using Design.ViewModel;
using System.Reflection;
using System.Linq;

namespace Zork.Builder.Forms

{
    public partial class MainForm : Form
    {

        public static string AssemblyTitle = Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyTitleAttribute>().Title;

        private Game Game { get; set; }

        private GameViewModel FullPath;

        private GameViewModel ViewModel
        {
            get => mViewModel;
            set
            {
                if (mViewModel != value)
                {
                    mViewModel = value;
                    gameViewModelBindingSource.DataSource = mViewModel;                 
                }
            }
        }
        private bool IsWorldLoaded
        { get => mIsWorldLoaded;
            set 
            {
                mIsWorldLoaded = value;
                Tab.Enabled = mIsWorldLoaded;
            } 
        }

        public MainForm()
        {
            InitializeComponent();
            ViewModel = new GameViewModel(Game);
            gameViewModelBindingSource.DataSource = mViewModel;
            IsWorldLoaded = false;
            //      UpdateTitle();
            CreateGame();
        }

         private void CreateGame()
         {
             FullPath = null;
             Game = new Game(new World(), null);
         } 
 
        //      private void UpdateTitle()
        //      {
        //          string gameFilename = string.IsNullOrWhiteSpace(GameFilename) ? "Untitled" : Path.GetFileNameWithoutExtension(GameFilename);
        //          Text = $"Zork Builder - {gameFilename}";
        //      }
        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateGame();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            using (AddRoom addRoom = new AddRoom())
            {
                if (addRoom.ShowDialog() == DialogResult.OK)
                {
                    Room room = new Room { Name = addRoom.RoomName };
                    ViewModel.Rooms.Add(room);
                }
            } 
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Delete the Room?", AssemblyTitle, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ViewModel.Rooms.Remove((Room)RoomlistBox.SelectedItem);
                RoomlistBox.SelectedItem = ViewModel.Rooms.FirstOrDefault();
            }
        }

        private void RoomlistBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DeleteButton.Enabled = RoomlistBox.SelectedItem != null;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
             if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ViewModel.Game = JsonConvert.DeserializeObject<Game>(File.ReadAllText(openFileDialog.FileName));
                ViewModel.FullPath = openFileDialog.FileName;
                IsWorldLoaded = true;
            }
        }
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
        private void SaveAsItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ViewModel.FullPath = saveFileDialog.FileName;
                 //   UpdateTitle();
                    ViewModel.SaveGame();
                }
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewModel.SaveGame();
        }

        private GameViewModel mViewModel;

        private bool mIsWorldLoaded;

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}