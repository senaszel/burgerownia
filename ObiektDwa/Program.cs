using Burgerownia.ConsoleApp.Manager;

namespace Burgerownia.ConsoleApp
{
    class Program
    {
        static void Main()
        {
            //MenuManager menu = new MenuManager();
            //menu.Welcome();
            //menu.BeginingOfService(false);

            Burgerownia.DataBase.SQLite.SQLite_DB db = new DataBase.SQLite.SQLite_DB();
            db.RizeIt();
            System.Console.WriteLine("wyczyscilo");
            System.Console.ReadKey();
            db = new DataBase.SQLite.SQLite_DB();
            System.Console.WriteLine("utworzylo z niczego");
            System.Console.ReadKey();
            db.ReadData("Refreshments");
            System.Console.WriteLine();
            db.ReadData("Ingredients");
            System.Console.WriteLine("przeczytalo");
            System.Console.ReadKey();
            db.RizeIt();
            System.Console.WriteLine("wyczyscilo");
            System.Console.ReadKey();
            db = new DataBase.SQLite.SQLite_DB();
            db.ReadData("Refreshments");
            System.Console.WriteLine();
            db.ReadData("Ingredients");
            System.Console.WriteLine("test success");
        }
    }
}
