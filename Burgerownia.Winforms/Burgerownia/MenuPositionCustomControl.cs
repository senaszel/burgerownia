using System.Drawing;
using System.Windows.Forms;

namespace Burgerownia.Winforms
{
    public partial class MenuPositionCustomControl : UserControl
    {
        public MenuPositionCustomControl((int r, int g, int b) color)
        {
            InitializeComponent();

            this.TextBox_Name.ReadOnly = true;
            this.textBox_Price.ReadOnly = true;

            TextBox_Name.ForeColor = Color.FromArgb(color.r, color.g, color.b);
            TextBox_Price.ForeColor = Color.FromArgb(color.r, color.g, color.b);
            ListBox_for_Ingredients.ForeColor = Color.FromArgb(color.r, color.g, color.b);
        }

        internal TextBox TextBox_Price { get { return this.textBox_Price; } set { this.textBox_Price = value; } }
        internal ListBox ListBox_for_Ingredients { get { return this.listBox_Ingredients; } set { this.listBox_Ingredients = value; } }
        internal TextBox TextBox_Name { get { return this.textBox_Name; } set { this.textBox_Name = value; } }
        internal Image PictureBox_withIcon_BackgroundImage { get { return this.pictureBox_BurgerPicture.BackgroundImage; } set { this.pictureBox_BurgerPicture.BackgroundImage = value; } }


    }
}
