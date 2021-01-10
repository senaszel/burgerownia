using System;
using System.Collections.Generic;

namespace Burgerownia.ConsoleApp
{
    /// <summary>
    /// Class inheritings from List<MenuItem> created for faster adding MenuItems to Menu's Items lists 
    /// </summary>
    internal class MenuItems : List<MenuItem>
    {
        /// <summary>
        /// Add MenuItem by passing its name and function, [object]parameter is also possible.
        /// </summary>
        /// <param name="itemName">Name of this option in Menu.</param>
        /// <param name="function">Function called by this MenuItem.</param>
        /// <param name="parameterObject">1 and only parameter allowed for function. It has to be object.</param>
        public void Add(string itemName, Action<object> function, object parameterObject = null)
        {
            Add(new MenuItem()
            {
                IsSelected = Count == 0,
                ItemName = itemName.ToString(),
                Function = function,
                ParameterObject = parameterObject
            });
        }


    }
}