using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Zork.Builder
{
    public partial class NeighborsForm : Form
    {
        public static readonly Room NoNeighbor = new Room() { Name = "None" };

        public Directions Direction 
        {
            get => (Directions)Enum.Parse(typeof(Directions), DirectiontextBox.Text, true);
            set => DirectiontextBox.Text = value.ToString();
        }
        public Room Room { get; set; }

        public Room Neighbor
        {
            get => (Room)RoomscomboBox.SelectedItem;
            set => RoomscomboBox.SelectedItem = value; 
        }

        public NeighborsForm(List<Room> rooms, Directions direction, Room room)
        {
            InitializeComponent();
            rooms.Insert(0, NoNeighbor);
            RoomscomboBox.DataSource = rooms;
            Direction = direction;
            Room = room;

            if (room.Neighbors.TryGetValue(direction, out Room neighbor))
            {
                Neighbor = neighbor;
            }
        }

        private void OKNeighborbutton_Click(object sender, EventArgs e)
        {

        }
    }
}
