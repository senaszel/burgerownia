using Burgerownia.API.Repositories;
using Burgerownia.Model;

namespace Burgerownia.API.Services
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
