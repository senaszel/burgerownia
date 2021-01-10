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
        private List<Refreshment> _refreshments;

        public RefreshmentRepository(IDB db)
        {
            string[] _splitted;
            _db = db;
            _refreshments = new List<Refreshment>();
            _db.GetAll(Tables.Refreshments)
                .ForEach(ingredient =>
                {
                    _splitted = ingredient.Split(',');
                    _refreshments.Add(new Refreshment(
                        Convert.ToInt32(_splitted[0]),
                        _splitted[1],
                        Convert.ToDouble(_splitted[2])
                    ));
                });
        }

        public Refreshment Get(int id) => _refreshments.Find(b => b.Id == id);
        public List<Refreshment> GetAll() => _refreshments;
        public Refreshment SpecialOfADay() => Get((int)System.DateTime.Now.DayOfWeek);


    }
}
