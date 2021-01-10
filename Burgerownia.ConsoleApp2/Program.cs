using Burgerownia.Back;
using Burgerownia.ConsoleApp2.Manager;

namespace Burgerownia.ConsoleApp2
{
    class Program
    {
        static void Main()
        {
            Context context = new Context();
            MenuManager menu = new MenuManager(context);
            menu.Welcome();
            menu.BeginingOfService(false);

            //Burgerownia.DataBase.SQLite.SQLite_DB db = new DataBase.SQLite.SQLite_DB();
            //db.RizeIt();
            //System.Console.WriteLine("wyczyscilo");
            //System.Console.ReadKey();

            //db = new DataBase.SQLite.SQLite_DB();
            //System.Console.WriteLine("utworzylo z niczego");
            //System.Console.ReadKey();

            //var temp = db.GetAll("Refreshments");
            //temp.ForEach(t => System.Console.WriteLine(t));
            //System.Console.WriteLine();
            //var temp = db.GetAll("Burgers");
            //temp.ForEach(t => System.Console.WriteLine(t));
            //System.Console.WriteLine();
            //temp = db.GetAll("Ingredients");
            //temp.ForEach(t => System.Console.WriteLine(t));
            //System.Console.WriteLine();
            //temp = db.GetAll("Compositions");
            //temp.ForEach(t => System.Console.WriteLine(t));
            //System.Console.WriteLine();
            //System.Console.WriteLine();
            //System.Console.WriteLine("przeczytalo");
            //System.Console.ReadKey();


            //db.ShowBurgerIngredients();
            //db.RizeIt();
            //System.Console.WriteLine("wyczyscilo");
            //System.Console.ReadKey();

            //db = new DataBase.SQLite.SQLite_DB();
            //temp = db.GetAll("Refreshments");
            //temp.ForEach(t => System.Console.WriteLine(t));
            //System.Console.WriteLine();
            //temp = db.GetAll("Burgers");
            //temp.ForEach(t => System.Console.WriteLine(t));
            //System.Console.WriteLine();
            //temp = db.GetAll("Ingredients");
            //temp.ForEach(t => System.Console.WriteLine(t));
            //System.Console.WriteLine();
            //temp = db.GetAll("Compositions");
            //temp.ForEach(t => System.Console.WriteLine(t));
            //System.Console.WriteLine();
            //System.Console.WriteLine();
            //System.Console.WriteLine("test success");
        }
    }
}
