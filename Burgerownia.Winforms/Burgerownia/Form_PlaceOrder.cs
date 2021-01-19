﻿using Burgerownia.Back.Interface;
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
        internal Control_MenuPosition_Burger _menuPosition_BurgerOfADay;


        public Form_PlaceOrder()
        {
            _context = Program.context;
            this.AutoScroll = true;

            InitializeComponent();
            InitializeMore();
            InitializeControls();
        }

        private void AutoscrollToBurgerOfADay(object sender, EventArgs e) => panel_Right.ScrollControlIntoView(_menuPosition_BurgerOfADay);
        private void AutoscrollToRefreshments(object sender, EventArgs e) => panel_Right.ScrollControlIntoView(_menuPositionRefreshments[0]);
        private void AutoscrollToBurgers(object sender, EventArgs e) => panel_Right.ScrollControlIntoView(_menuPositionBurgers[0]);
        private void GoToFinalizeOrder(object sender, EventArgs e)
        {
            Hide();
            Form_WelcomeScreen ws = new Form_WelcomeScreen();
            ws.Show();
        }

        private void InitializeControls()
        {
            Burger specialOfADay_burger = _context.BurgerService.SpecialOfADay();
            Burger burgerOfADay = new Burger(specialOfADay_burger.Id, specialOfADay_burger.Name, new Ingredients(specialOfADay_burger.Ingredients.ToArray()));
            _menuPosition_BurgerOfADay = new Control_MenuPosition_Burger(burgerOfADay, (255, 255, 0))
            {
                Left = ClientSize.Width - this.Width / 2,
                Top = ClientSize.Height - this.Height / 2,
                Location = new System.Drawing.Point(x: 0, y: 0 + (320 * counterForEvaluatingYneccessaryForCurrentCustomFormLocation)),
                Size = new System.Drawing.Size(width: 700, height: 300)
            };
            counterForEvaluatingYneccessaryForCurrentCustomFormLocation += 1;
            panel_Right.Controls.Add(_menuPosition_BurgerOfADay);
            _menuPosition_BurgerOfADay.Click += new EventHandler(_menuPosition_BurgerOfADay.OnClick_EditBurger);
            _menuPosition_BurgerOfADay.TextBox_Name.Click += new EventHandler(_menuPosition_BurgerOfADay.OnClick_EditBurger);
            _menuPosition_BurgerOfADay.TextBox_Price.Click += new EventHandler(_menuPosition_BurgerOfADay.OnClick_EditBurger);
            _menuPosition_BurgerOfADay.ListBox_for_Ingredients.Click += new EventHandler(_menuPosition_BurgerOfADay.OnClick_EditBurger);

            CreateControlsForEachBurger(_context.BurgerService);
            AddToPanel_Burgers_AsControls();
            AddEventListenersForEachBurgerControl();

            CreateControlsForEachRefreshment(_context.RefreshmentService);
            AddToPanel_Refreshments_AsControls();
        }

        private void InitializeMore()
        {
            this.pictureBox_burgerOfADay.Click += new EventHandler(AutoscrollToBurgerOfADay);
            this.pictureBox_refreshmentsIcon.Click += new EventHandler(AutoscrollToRefreshments);
            this.pictureBox_burgersIcon.Click += new EventHandler(AutoscrollToBurgers);
            this.pictureBox_dolarSignIcon.Click += new EventHandler(GoToFinalizeOrder);
            this.FormClosing += new FormClosingEventHandler(Do.Close);

        }

        private void AddToPanel_Refreshments_AsControls()
        {
            _menuPositionRefreshments.ForEach(c =>
            {
                this.panel_Right.Controls.Add(c);
            });
        }

        private void CreateControlsForEachRefreshment(IServiceable<Refreshment> refreshmentService)
        {
            _menuPositionRefreshments = new List<Control_MenuPosition_Refreshment>();
            refreshmentService.Items.ForEach(eachRefreshment =>
            {
                _menuPositionRefreshments.Add(
                     new Control_MenuPosition_Refreshment(eachRefreshment, (0, 72, 186))
                     {
                         Left = ClientSize.Width - this.Width / 2,
                         Top = ClientSize.Height - this.Height / 2,
                         Location = new System.Drawing.Point(x: 0, y: 0 + (320 * counterForEvaluatingYneccessaryForCurrentCustomFormLocation)),
                         Size = new System.Drawing.Size(width: 700, height: 300)
                     });
                counterForEvaluatingYneccessaryForCurrentCustomFormLocation += 1;
            });
        }

        private void AddEventListenersForEachBurgerControl()
        {
            _menuPositionBurgers.ForEach(eachControl =>
            {
                eachControl.Click += new EventHandler(eachControl.OnClick_EditBurger);
                eachControl.TextBox_Name.Click += new EventHandler(_menuPosition_BurgerOfADay.OnClick_EditBurger);
                eachControl.TextBox_Price.Click += new EventHandler(_menuPosition_BurgerOfADay.OnClick_EditBurger);
                eachControl.ListBox_for_Ingredients.Click += new EventHandler(_menuPosition_BurgerOfADay.OnClick_EditBurger);
            });
        }

        private void CreateControlsForEachBurger(IServiceable<Burger> burgerService)
        {
            _menuPositionBurgers = new List<Control_MenuPosition_Burger>();
            burgerService.Items.ForEach(eachBurger =>
            {
                _menuPositionBurgers.Add(
                     new Control_MenuPosition_Burger(eachBurger, (255, 40, 0))
                     {
                         Left = ClientSize.Width - this.Width / 2,
                         Top = ClientSize.Height - this.Height / 2,
                         Location = new System.Drawing.Point(x: 0, y: 0 + (320 * counterForEvaluatingYneccessaryForCurrentCustomFormLocation)),
                         Size = new System.Drawing.Size(width: 700, height: 300)
                     });
                counterForEvaluatingYneccessaryForCurrentCustomFormLocation += 1;
            });
        }

        private void AddToPanel_Burgers_AsControls()
        {
            _menuPositionBurgers.ForEach(c =>
            {
                this.panel_Right.Controls.Add(c);
            });
        }


    }
}
