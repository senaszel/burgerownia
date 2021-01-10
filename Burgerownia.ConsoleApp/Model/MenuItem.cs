using System;

namespace Burgerownia.ConsoleApp
{
    public class MenuItem
    {
        public string ItemName { get; set; }
        public Action<object> Function { get; set; }
        public bool IsSelected { get; set; }
        public void Invoke(object parameterObject = null) => Function.Invoke(parameterObject);
        public object ParameterObject { get; set; }


    }
}