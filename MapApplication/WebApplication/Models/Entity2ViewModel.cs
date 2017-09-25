using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DALClassLibrary.Models;

namespace WebApplication.Models
{
    public class Entity2ViewModel
    {
        public Entity2ViewModel() { }
        public Entity2ViewModel(Entity2 entity)
        {
            this.Id = entity.Id;
            this.Property1 = entity.Property1;
            this.Property2 = entity.Property2;
        }

        public int Id { get; set; }
        public string Property1 { get; set; }
        public string Property2 { get; set; }

        public List<Entity1ViewModel> Entity1 { get; set; }
    }
}