using System;
using System.Drawing;
using System.Windows.Forms;
using Burgerownia.Back.Model;

namespace Burgerownia.Winforms
{
    public partial class MenuPositionCustomControl : UserControl
    {
        private Item _item;
        public MenuPositionCustomControl((int r, int g, int b) color,Item item)
        {
            _item = item;

            InitializeComponent();

            InitializeMore(color);

            AddEventLisners();
        }

        internal TextBox TextBox_Price { get { return this.textBox_Price; } set { this.textBox_Price = value; } }
        internal ListBox ListBox_for_Ingredients { get { return this.listBox_Ingredients; } set { this.listBox_Ingredients = value; } }
        internal TextBox TextBox_Name { get { return this.textBox_Name; } set { this.textBox_Name = value; } }
        internal Image PictureBox_withIcon_BackgroundImage { get { return this.pictureBox_BurgerPicture.BackgroundImage; } set { this.pictureBox_BurgerPicture.BackgroundImage = value; } }
        internal PictureBox PictureBox_Add { get { return this.pictureBox_Add; } set { this.pictureBox_Add = value; } }
        internal PictureBox PictureBox_Remove { get { return this.pictureBox_Subtract; } set { this.pictureBox_Subtract = value; } }
        internal Image PictureBox_Numbers { get { return this.pictureBox_Numbers.BackgroundImage; } set { this.pictureBox_Numbers.BackgroundImage = value; } }

        private void InitializeMore((int r, int g, int b) color)
        {
            this.textBox_Name.ReadOnly = true;
            this.textBox_Name.TabStop = false;
            this.textBox_Price.ReadOnly = true;
            this.textBox_Price.TabStop = false;
            this.listBox_Ingredients.SelectionMode = SelectionMode.None;
            this.listBox_Ingredients.TabStop = false;

            TextBox_Name.ForeColor = Color.FromArgb(color.r, color.g, color.b);
            TextBox_Price.ForeColor = Color.FromArgb(color.r, color.g, color.b);
            ListBox_for_Ingredients.ForeColor = Color.FromArgb(color.r, color.g, color.b);
        }

        private void AddEventLisners()
        {
            //todo
            PictureBox_Add.Click += new EventHandler(OnClick_Add);
            PictureBox_Remove.Click += new EventHandler(OnClick_Remove);
        }

        internal void OnClick_Add(object sender, EventArgs e)
        {
            Program.order.AddItem(_item.Clone() as Item);
            MessageBox.Show(Program.order.Items.Count.ToString(), $"added {_item.Name}", MessageBoxButtons.OK);
        }

        internal void OnClick_Remove(object sender, EventArgs e)
        {
            Program.order.RemoveItem(_item);
            MessageBox.Show(Program.order.Items.Count.ToString(), $"removed {_item.Name}", MessageBoxButtons.OK);
        }
    }
}
