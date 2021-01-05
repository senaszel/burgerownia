using System.Collections.Generic;
using Burgerownia.DataBase.SQLite.Enum;

namespace Burgerownia.DataBase.SQLite
{
    public interface IDB
    {
        List<string> GetAll(Tables fromTable);


    }
}