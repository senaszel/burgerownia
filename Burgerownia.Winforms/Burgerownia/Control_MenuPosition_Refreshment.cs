using System.Drawing;
using System.Windows.Forms;
using Burgerownia.Back.Model;

namespace Burgerownia.Winforms
{
    public class Control_MenuPosition_Refreshment : MenuPositionCustomControl
    {
        private Refreshment _refreshment;        

        public Control_MenuPosition_Refreshment(Refreshment refreshment, (int r, int g, int b) color)
            : base(color)
        {
            _refreshment = refreshment;

            TextBox_Name.DataBindings.Add(new Binding("Text", _refreshment, "Name"));
            this.TextBox_Price.Text = (_refreshment.Price / 100).ToString() + " zł";
        }


    }
}
