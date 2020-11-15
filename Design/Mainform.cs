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

        private string GameFilename;

        private GameViewModel ViewModel
        {
            get => mViewModel;
            set
            {
                if (mViewModel != value)
                {
                    mViewModel = value;
                    gameViewModelBindingSource.DataSource = mViewModel;
                    roomsBindingSource.DataSource = mViewModel?.Rooms;
              }
            }
        }
        private bool IsWorldLoaded
        { get => mIsWorldLoaded;
            set 
            {
                mIsWorldLoaded = value;
                Tab.Enabled = mIsWorldLoaded;
                saveToolStripMenuItem.Enabled = mIsWorldLoaded;
                SaveAsItem.Enabled = mIsWorldLoaded;
            } 
        }

        public MainForm()
        {
            InitializeComponent();
            ViewModel = new GameViewModel(Game);
            gameViewModelBindingSource.DataSource = mViewModel;
            roomsBindingSource.DataSource = mViewModel?.Rooms;
            IsWorldLoaded = false;
            CreateGame();
        }

         private void CreateGame()
         {
             GameFilename = null;
             Game = new Game(new World(), null);
         } 

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateGame();
            IsWorldLoaded = true;
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

        private void SaveAsItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK || string.IsNullOrWhiteSpace(GameFilename))
                {
                    ViewModel.FullPath = saveFileDialog.FileName;
                    ViewModel.SaveGame();
                }
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewModel.SaveGame();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            using (AddRoom addRoom = new AddRoom())
            {
                if (addRoom.ShowDialog() == DialogResult.OK)
                {
                    bool existingRoom = false;

                    if (existingRoom == false)
                    { 

                    Room room = new Room(addRoom.RoomName );
                    ViewModel.Rooms.Add(room);
                    }
                    else
                    {
                        MessageBox.Show($"Room named \" {addRoom.RoomName}\" already exits.");
                    }
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

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private GameViewModel mViewModel;

        private bool mIsWorldLoaded;

    }
}