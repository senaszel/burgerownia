using Burgerownia.Back;
using Burgerownia.Back.Interface;
using Burgerownia.DataBase.SQLite;
using System.Collections.Generic;
using System.Windows.Forms;
using Burgerownia.Back.Model;
using System;

namespace Burgerownia.Winforms
{
    public partial class Form_PlaceOrder : Form
    {
        private IContext _context;
        internal List<MenuPosition_Burger> _menuPositionBurgers;

        public Form_PlaceOrder()
        {
            _context = Program.context;

            InitializeComponent();
            InitializeMore();
        }

        private void InitializeMore()
        {
            CreateControlsForEachBurger(_context.BurgerService);
            AddToPanel_Burgers_AsControls();
            AddEventListenersForEachBurgerControl();
        }

        private void AddEventListenersForEachBurgerControl()
        {
            _menuPositionBurgers.ForEach(eachControl =>
                eachControl.Click += new EventHandler(eachControl.OnClick_EditBurger)
                );
        }

        private void CreateControlsForEachBurger(IServiceable<Burger> burgerService)
        {
            _menuPositionBurgers = new List<MenuPosition_Burger>();
            int counterForEvaluatingYneccessaryForCurrentBurgerFormLocation = 0;
            burgerService.Items.ForEach(eachBurger =>
            {
                _menuPositionBurgers.Add(
                     new MenuPosition_Burger(eachBurger)
                     {
                         Left = ClientSize.Width - this.Width / 2,
                         Top = ClientSize.Height - this.Height / 2,
                         Location = new System.Drawing.Point(x: 0, y: 0 + (300 * counterForEvaluatingYneccessaryForCurrentBurgerFormLocation)),
                         Size = new System.Drawing.Size(width: 700, height: 300)
                     });
                counterForEvaluatingYneccessaryForCurrentBurgerFormLocation += 1;
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
