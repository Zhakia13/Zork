using Design.ViewModel;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Zork.Builder
{
    public partial class NeighborControl : UserControl
    {
      public GameViewModel ViewModel
      {
      get => mViewModel;
      set
      {
          mViewModel = value;
          NeighborscomboBox.DataSource = mViewModel.Rooms;
      
       }
       }    
                public Directions Direction
                {
                    get => mDirections;
                    set
                    {
                        mDirections = value;
                        DirectionstextBox.Text = mDirections.ToString();
                    }
                }
        
                public Room Room { get; set; }
        
                public NeighborControl(List<Room> rooms, Directions direction, Room room)
                {
                    InitializeComponent();
                    Direction = mDirections;
                    rooms.Insert(0, NoNeighbor);
                    NeighborscomboBox.DataSource = rooms;
                    Room = room;
        
                    if (room.Neighbors.TryGetValue(direction, out Room neighbor))
                    {
                        Neighbor = neighbor;
                    }
                }
        
                public Room Neighbor
                {
                    get => (Room)NeighborscomboBox.SelectedItem;
                    set => NeighborscomboBox.SelectedItem = value;
                }
        
        private GameViewModel mViewModel;
        private Directions mDirections;
        private static readonly Room NoNeighbor = new Room("<None>");
  }
}