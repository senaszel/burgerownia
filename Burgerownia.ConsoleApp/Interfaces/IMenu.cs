namespace Burgerownia.ConsoleApp
{
    public interface IMenu
    {
        void Add(MenuItem menuItem);
        void Invoke(object parameter = null);
        void MoveBack();
        void MoveNext();
        void Print();
    }
}