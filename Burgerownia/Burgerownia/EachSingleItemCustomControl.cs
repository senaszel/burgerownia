using System.Windows.Forms;

namespace Burgerownia.Winforms
{
    public partial class EachSingleItemCustomControl : UserControl
    {
        public EachSingleItemCustomControl()
        {
            InitializeComponent();
        }

        public EachSingleItemCustomControl(Burgerownia.Model.Burger burger)
        {
            InitializeComponent();
            this.textBox_name.Text = burger.Name;
            this.textBox_for_Ingredients.Text = burger.Ingredients.ToString();
        }


    }
}
