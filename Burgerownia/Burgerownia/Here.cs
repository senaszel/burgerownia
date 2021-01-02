using System.Collections.Generic;
using System.Windows.Forms;

namespace Burgerownia.Winforms
{
    public partial class Here : Form
    {
        List<EachSingleItemCustomControl> burgers;

        public Here()
        {

            InitializeComponent();
            InitializeMore();

        }

        private void InitializeMore()
        {
            burgers = new List<EachSingleItemCustomControl>();
            int counter = 0;
            API.Repositories.BurgerRepository burgerRepository = new API.Repositories.BurgerRepository();
            burgerRepository.GetAll().ForEach(p =>
            {
                burgers.Add(
                     new EachSingleItemCustomControl(p)
                     {
                         Left = ClientSize.Width - this.Width / 2,
                         Top = ClientSize.Height - this.Height / 2,
                         Name = "burger[" + p.Id + "] " + p.Name,
                         Location = new System.Drawing.Point(0, 0 + (300 * counter)),
                         Size = new System.Drawing.Size(700, 300),
                     });
                counter += 1;
            });

            burgers.ForEach(c =>
            {
                this.panel.Controls.Add(c);
            });
        }
    }
}
