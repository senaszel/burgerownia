using System.Drawing;
using System.Windows.Forms;
using Burgerownia.Back.Model;

namespace Burgerownia.Winforms
{
    public class Control_MenuPosition_Refreshment : MenuPositionCustomControl
    {
        private Refreshment _refreshment;

        public Control_MenuPosition_Refreshment(Refreshment refreshment)
            : base()
        {
            ListBox_for_Ingredients.ForeColor = Color.FromArgb(240, 248, 255);

            _refreshment = refreshment;

            TextBox_name.DataBindings.Add(new Binding("Text", _refreshment, "Name"));
        }


    }
}
