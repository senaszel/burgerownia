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
        private IContext _context;
        internal List<MenuPosition_Burger> _menuPositionBurgers;

        public Form_PlaceOrder(IContext context)
        {
            _context = context;

            InitializeComponent();
            InitializeMore();
        }

        private void InitializeMore()
        {
            CreateControlsForEachBurger(_context.BurgerService);
            AddToPanel_Burgers_AsControls();
        }



        private void CreateControlsForEachBurger(IServiceable<Burger> burgerService)
        {
            _menuPositionBurgers = new List<MenuPosition_Burger>();
            int counter = 0;
            burgerService.Items.ForEach(eachBurger =>
            {
                _menuPositionBurgers.Add(
                     new MenuPosition_Burger(eachBurger)
                     {
                         Left = ClientSize.Width - this.Width / 2,
                         Top = ClientSize.Height - this.Height / 2,
                         Location = new System.Drawing.Point(0, 0 + (300 * counter)),
                         Size = new System.Drawing.Size(700, 300),
                     });
                counter += 1;
            });
        }

        private void AddToPanel_Burgers_AsControls()
        {
            _menuPositionBurgers.ForEach(c =>
            {
                this.panel.Controls.Add(c);
            });
        }
    }
}
