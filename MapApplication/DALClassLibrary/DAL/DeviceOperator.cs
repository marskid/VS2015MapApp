using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DALClassLibrary.DAL
{
    public class DeviceOperator
    {
        private EntityDBContext db;

        public DeviceOperator()
        {
            db = new EntityDBContext();
        }

        public Models.Entity1 Add(string p1, string p2, string p3, string p4, string p5)
        {
            var E2 = new Models.Entity2()
            {
                Property1 = p4,
                Property2 = p5
            };
            var hasE2 = db.Entity2.Any(s => s.Property1 == p1 && s.Property2 == p2);

            if (hasE2)
            {
                E2 = db.Entity2.First(s => s.Property1 == p1 && s.Property2 == p2);
            }

            var entity = new Models.Entity1()
            {
                Property1 = p1,
                Property2 = p2,
                Property3 = p3,
                Entity2 = E2
            };
            entity = db.Entity1.Add(entity);

            db.SaveChanges();

            return entity;
        }

        public List<Models.Entity1> GetAll()
        {
            return db.Entity1.ToList();
        }

        public List<Models.Entity1> Get(string p1)
        {
            return db.Entity1.Where(s => s.Entity2.Property1 == p1).ToList();
        }
    }
}
