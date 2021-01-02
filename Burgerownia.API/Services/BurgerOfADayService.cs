using Burgerownia.Back.Repositories;
using Burgerownia.Back.Model;

namespace Burgerownia.Back.Services
{
    public class BurgerOfADayService
    {
        public Burger TodaysSpecial()
        {
            int today = (int)System.DateTime.Now.DayOfWeek;
            return new BurgerRepository().Get(today);
        }
    }
}
