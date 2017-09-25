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
            db = EntityDBContext.Create();
        }

        public Models.Entity1 Add(string p1, string p2, string p3, string p4, string p5)
        {
            var entity = new Models.Entity1()
            {
                Property1 = p1,
                Property2 = p2,
                Property3 = p3,
                Entity2 = new Models.Entity2()
                {
                    Property1 = p4,
                    Property2 = p5
                }
            };
            db.Entity1.Add(entity);
            db.SaveChanges();
            return entity;
        }
    }
}
