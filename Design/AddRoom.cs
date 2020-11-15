using System.Windows.Forms;

namespace Zork.Builder
{
    public partial class AddRoom : Form
    {
        public string RoomName 
        { 
            get => RoomNametextBox.Text;
            set => RoomNametextBox.Text = value;
        }

        public AddRoom()
        {
            InitializeComponent();
        }

        private void RoomNametextBox_TextChanged(object sender, System.EventArgs e)
        {
            OKButton.Enabled = !string.IsNullOrEmpty(RoomName);
        }

    }
}
