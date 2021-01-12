using System.Drawing;
using System.Windows.Forms;

namespace Burgerownia.Winforms
{
    public partial class MenuPositionCustomControl : UserControl
    {
        public MenuPositionCustomControl()
        {
            InitializeComponent();

            this.TextBox_Name.ReadOnly = true;
            this.textBox_Price.ReadOnly = true;
        }

        internal TextBox TextBox_Price { get; set; }
        internal ListBox ListBox_for_Ingredients { get { return this.listBox_Ingredients; } set { this.listBox_Ingredients = value; } }
        internal TextBox TextBox_Name { get { return this.textBox_Name; } set { this.textBox_Name = value; } }
        internal Image PictureBox_withIcon_BackgroundImage { get { return this.pictureBox_BurgerPicture.BackgroundImage; } set { this.pictureBox_BurgerPicture.BackgroundImage = value; } }


    }
}
