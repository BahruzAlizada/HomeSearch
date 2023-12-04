using CoreLayer.Entity;
using System;


namespace EntityLayer.Concrete
{
    public class City : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsDeactive { get; set; }
        public List<Home> Homes { get; set; }
    }
}
