using Burgerownia.ConsoleApp.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Burgerownia.ConsoleApp
{
    public class Menu : IMenu, IMenuStart
    {
        protected List<MenuItem> Items { get; set; }

        public Menu()
        {
            Items = new List<MenuItem>();
        }

        public Menu(List<MenuItem> menuItems)
        {
            Items = menuItems;
        }

        /// <summary>
        /// 
        /// </summary>
        internal MenuItem SelectedItem => Items.FirstOrDefault(x => x.IsSelected == true);

        /// <summary>
        /// 
        /// </summary>
        private int SelectedIndex => Items.IndexOf(SelectedItem);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="parameter"></param>
        public void Invoke(object parameter = null) => SelectedItem.Invoke(parameter);

        /// <summary>
        /// 
        /// </summary>
        public void MoveNext()
        {
            if (SelectedItem != Items.Last())
            {
                var newIndex = SelectedIndex + 1;
                SelectedItem.IsSelected = false;
                Items[newIndex].IsSelected = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void MoveBack()
        {
            if (SelectedItem != Items.First())
            {
                var newIndex = SelectedIndex - 1;
                SelectedItem.IsSelected = false;
                Items[newIndex].IsSelected = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="menuItem"></param>
        public void Add(MenuItem menuItem)
        {
            Items.Add(menuItem);
            if (Items.Count == 1)
            {
                menuItem.IsSelected = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Print()
        {
            Console.Clear();
            foreach (var item in Items)
            {
                if (item.IsSelected) item.ItemName.Print_Item_That_Is_Selected();
                else item.ItemName.Print_As_Normal_Item();
            }
            Console.WriteLine();
        }

        public void Start()
        {
            while (true)
            {
                Print();
                var key = Console.ReadKey(true).Key;

                switch (key)
                {
                    case ConsoleKey.DownArrow:
                        MoveNext();
                        break;
                    case ConsoleKey.UpArrow:
                        MoveBack();
                        break;
                    case ConsoleKey.Enter:
                        Invoke(SelectedItem.ParameterObject);
                        break;
                    case ConsoleKey.Q:
                        return;
                    default:
                        continue;
                }
            }
        }

    }
}