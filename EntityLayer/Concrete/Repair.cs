using CoreLayer.Entity;
using System;

namespace EntityLayer.Concrete
{
    public class Repair : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Home> Homes { get; set; }
    }
}
