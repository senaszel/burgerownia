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
            _refreshment = refreshment;

            ListBox_for_Ingredients.ForeColor = Color.FromArgb(240, 248, 255);


            TextBox_Name.DataBindings.Add(new Binding("Text", _refreshment, "Name"));
        }


    }
}
