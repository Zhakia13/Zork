using Design.ViewModel;
using System.Windows.Forms;

namespace Zork.Builder
{
    public partial class DirectionsNeighbor : UserControl
    {
        public GameViewModel ViewModel
        {
            get => mViewModel;
            set
            {
                mViewModel = value;

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

        public DirectionsNeighbor()
        {
            InitializeComponent();
            Direction = mDirections;
        }

        private GameViewModel mViewModel;
        private Directions mDirections;
    }
}
