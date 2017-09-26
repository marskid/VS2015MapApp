using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DALClassLibrary.DAL
{
    public class CityOperator
    {
        private EntityDBContext db;

        public CityOperator()
        {
            db = new EntityDBContext();
        }

        public Models.Entity2 Add(string p1, string p2)
        {
            var hasE2 = db.Entity2.Any(s => s.Property1 == p1 && s.Property2 == p2);

            if (hasE2)
            {
                return db.Entity2.First(s => s.Property1 == p1 && s.Property2 == p2);
            } else
            {
                var E2 = new Models.Entity2()
                {
                    Property1 = p1,
                    Property2 = p2
                };

                db.Entity2.Add(E2);

                db.SaveChanges();

                return E2;
            }
        }

        public List<Models.Entity2> GetAll()
        {
            return db.Entity2.ToList();
        }
    }
}
