using CoreLayer.Entity;
using System;

namespace EntityLayer.Concrete
{
    public class Service : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public string Description { get; set; }
        public bool IsDeactvie { get; set; }
    }
}
