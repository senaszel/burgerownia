using System.Windows.Forms;

namespace Burgerownia.Winforms
{
    public partial class MenuPositionCustomControl : UserControl
    {
        public MenuPositionCustomControl()
        {
            Init();
        }

        public void Init()
        {
            InitializeComponent();
        }

        public TextBox TextBox_for_Ingredients { get { return this.textBox_for_Ingredients; } set { this.textBox_for_Ingredients = value; } }

        public TextBox TextBox_name { get { return this.textBox_name; } set { this.textBox_name = value; } }

    }
}
