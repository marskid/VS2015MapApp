using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DALClassLibrary.Models;

namespace WebApplication.Models
{
    public class Entity1ViewModel
    {
        public Entity1ViewModel() { }
        public Entity1ViewModel(Entity1 entity)
        {
            this.Id = entity.Id;
            this.Property1 = entity.Property1;
            this.Property2 = entity.Property2;
            this.Property3 = entity.Property3;
            this.Entity2 = new Entity2ViewModel(entity.Entity2);
        }
        public int Id { get; set; }
        public string Property1 { get; set; }
        public string Property2 { get; set; }
        public string Property3 { get; set; }

        public Entity2ViewModel Entity2 { get; set; }
    }
}