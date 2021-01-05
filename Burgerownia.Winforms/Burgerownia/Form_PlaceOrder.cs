using Burgerownia.Back;
using Burgerownia.Back.Interface;
using Burgerownia.DataBase.SQLite;
using System.Collections.Generic;
using System.Windows.Forms;
using Burgerownia.Back.Model;

namespace Burgerownia.Winforms
{
    public partial class Form_PlaceOrder : Form
    {
        private Context _context;
        internal List<MenuPosition_Burger> _menuPositionBurgers;

        public Form_PlaceOrder()
        {
            _context = new Back.Context();

            InitializeComponent();
            InitializeMore();
        }

        private void InitializeMore()
        {
            _menuPositionBurgers = new List<MenuPosition_Burger>();
            int counter = 0;
            IRepository<Burger> burgerRepository = _context.BurgerRepository;
            burgerRepository.GetAll().ForEach(p =>
            {
                _menuPositionBurgers.Add(
                     new MenuPosition_Burger(p)
                     {
                         Left = ClientSize.Width - this.Width / 2,
                         Top = ClientSize.Height - this.Height / 2,
                         Location = new System.Drawing.Point(0, 0 + (300 * counter)),
                         Size = new System.Drawing.Size(700, 300),
                     });
                counter += 1;
            });

            _menuPositionBurgers.ForEach(c =>
            {
                this.panel.Controls.Add(c);
            });
        }
    }
}
