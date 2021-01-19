using System.Collections.Generic;

namespace Burgerownia.Back.Interface
{
    public interface IRepository<T> 
    {
        List<T> GetAll();
        T Get(int id);


    }
}
