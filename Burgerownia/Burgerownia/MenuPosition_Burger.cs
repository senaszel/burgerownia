using System.Windows.Forms;
using Burgerownia.Back.Model;

namespace Burgerownia.Winforms
{
    public class MenuPosition_Burger : MenuPositionCustomControl
    {
        public MenuPosition_Burger(Burger burger)
            : base()
        {
            TextBox_name.DataBindings.Add(new Binding("Text", burger, "Name"));
            TextBox_for_Ingredients.DataBindings.Add(new Binding("Text", burger, "IngredientsToString"));
        }

    }
}
