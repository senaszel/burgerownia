using Burgerownia.DataBase.SQLite;
using Burgerownia.Back.Interface;
using Burgerownia.Back.Model;
using System.Collections.Generic;
using Burgerownia.DataBase.SQLite.Enum;
using System;

namespace Burgerownia.Back.Repositories
{
    public class RefreshmentRepository : IRepository<Refreshment>
    {
        private IDB _db;
        private string[] _splitted;
        private List<Refreshment> Refreshments;

        public RefreshmentRepository(IDB db)
        {
            _db = db;
            Refreshments = new List<Refreshment>();
            _db.GetAll(Tables.Refreshments)
                .ForEach(ingredient =>
                {
                    _splitted = ingredient.Split(',');
                    Refreshments.Add(new Refreshment(
                        Convert.ToInt32(_splitted[0]),
                        _splitted[1],
                        Convert.ToDouble(_splitted[2])
                    ));
                });
        }

        public Refreshment Get(int id) => Refreshments.Find(b => b.Id == id);
        public List<Refreshment> GetAll() => Refreshments;
        public Refreshment SpecialOfADay() => Get((int)System.DateTime.Now.DayOfWeek);


    }
}
