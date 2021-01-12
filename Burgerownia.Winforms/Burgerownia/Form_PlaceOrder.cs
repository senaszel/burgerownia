using Burgerownia.Back.Interface;
using System.Collections.Generic;
using System.Windows.Forms;
using Burgerownia.Back.Model;
using System;

namespace Burgerownia.Winforms
{
    public partial class Form_PlaceOrder : Form
    {
        private IContext _context;
        private int counterForEvaluatingYneccessaryForCurrentCustomFormLocation = 0;
        internal List<Control_MenuPosition_Burger> _menuPositionBurgers;
        internal List<Control_MenuPosition_Refreshment> _menuPositionRefreshments;


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

            counterForEvaluatingYneccessaryForCurrentCustomFormLocation += 1;
            CreateControlsForEachRefreshment(_context.RefreshmentService);
            AddToPanel_Refreshments_AsControls();
            AddEventListenersForEachRefreshmentControl();
        }

        private void AddEventListenersForEachRefreshmentControl()
        {
           // _menuPositionRefreshments.ForEach(eachControl =>
             //   eachControl.Click += new EventHandler(eachControl.OnClick_EditBurger)
               // );
        }

        private void AddToPanel_Refreshments_AsControls()
        {
            _menuPositionRefreshments.ForEach(c =>
            {
                this.panel.Controls.Add(c);
            });
        }

        private void CreateControlsForEachRefreshment(IServiceable<Refreshment> refreshmentService)
        {
            _menuPositionRefreshments = new List<Control_MenuPosition_Refreshment>();
            refreshmentService.Items.ForEach(eachRefreshment =>
            {
                _menuPositionRefreshments.Add(
                     new Control_MenuPosition_Refreshment(eachRefreshment)
                     {
                         Left = ClientSize.Width - this.Width / 2,
                         Top = ClientSize.Height - this.Height / 2,
                         Location = new System.Drawing.Point(x: 0, y: 0 + (300 * counterForEvaluatingYneccessaryForCurrentCustomFormLocation)),
                         Size = new System.Drawing.Size(width: 700, height: 300)
                     });
                counterForEvaluatingYneccessaryForCurrentCustomFormLocation += 1;
            });
        }

        private void AddEventListenersForEachBurgerControl()
        {
            _menuPositionBurgers.ForEach(eachControl =>
                eachControl.Click += new EventHandler(eachControl.OnClick_EditBurger)
                );
        }

        private void CreateControlsForEachBurger(IServiceable<Burger> burgerService)
        {
            _menuPositionBurgers = new List<Control_MenuPosition_Burger>();
            burgerService.Items.ForEach(eachBurger =>
            {
                _menuPositionBurgers.Add(
                     new Control_MenuPosition_Burger(eachBurger)
                     {
                         Left = ClientSize.Width - this.Width / 2,
                         Top = ClientSize.Height - this.Height / 2,
                         Location = new System.Drawing.Point(x: 0, y: 0 + (300 * counterForEvaluatingYneccessaryForCurrentCustomFormLocation)),
                         Size = new System.Drawing.Size(width: 700, height: 300)
                     });
                counterForEvaluatingYneccessaryForCurrentCustomFormLocation += 1;
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
