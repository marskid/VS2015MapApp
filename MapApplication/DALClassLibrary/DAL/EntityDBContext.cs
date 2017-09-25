﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace DALClassLibrary
{
    class EntityDBContext: DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx

        public EntityDBContext() : base("DefaultConnection")
        {
        }

        public static EntityDBContext Create()
        {
            return new EntityDBContext();
        }

        public System.Data.Entity.DbSet<Models.Entity1> Entity1 { get; set; }
        public System.Data.Entity.DbSet<Models.Entity2> Entity2 { get; set; }
    }
}
