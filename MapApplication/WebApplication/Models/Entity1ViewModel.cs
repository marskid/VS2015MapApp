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
            this.name = entity.Property1;
            this.longitude = entity.Property2;
            this.latitude = entity.Property3;
            this.Entity2 = new Entity2ViewModel(entity.Entity2);
        }
        public int Id { get; set; }
        public string name { get; set; }
        public string longitude { get; set; }
        public string latitude { get; set; }

        public Entity2ViewModel Entity2 { get; set; }
    }
}