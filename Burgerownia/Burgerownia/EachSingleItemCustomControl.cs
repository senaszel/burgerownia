using System.Windows.Forms;

using Burgerownia.API.Model;

namespace Burgerownia.Winforms
{
    public partial class EachSingleItemCustomControl : UserControl
    {
        public EachSingleItemCustomControl()
        {
            InitializeComponent();
        }

        public EachSingleItemCustomControl(Burger burger)
        {
            InitializeComponent();
            this.textBox_name.Text = burger.Name;
            this.textBox_for_Ingredients.Text = burger.Ingredients.ToString();
        }


    }
}
