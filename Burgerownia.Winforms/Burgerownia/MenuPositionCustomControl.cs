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

        internal ListBox ListBox_for_Ingredients { get { return this.listBox_forIngredients; } set { this.listBox_forIngredients = value; } }
        internal TextBox TextBox_name { get { return this.textBox_name; } set { this.textBox_name = value; } }

    }
}
