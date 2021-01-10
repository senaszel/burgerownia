using System.Collections.Generic;
using Burgerownia.DataBase.SQLite.Enum;

namespace Burgerownia.DataBase.SQLite
{
    public interface IDB
    {
        List<string> Select(Tables fromTable);

        string GetAll_IngredientsIdsOf(int burger_id);

    }
}