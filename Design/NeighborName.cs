using Design.ViewModel;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Zork.Builder
{
    public partial class NeighborName : UserControl
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
        public Room Room { get; set; }

        public NeighborName()
        {
            InitializeComponent();
            NeighborscomboBox.DataSource = Array.Empty<Room>();
        }

        public Room Neighbor
        {
            get => (Room)NeighborscomboBox.SelectedItem;
            set => NeighborscomboBox.SelectedItem = value;
        }

        private GameViewModel mViewModel;
        private static readonly Room NoNeighbor = new Room("<None>");
    }
}
