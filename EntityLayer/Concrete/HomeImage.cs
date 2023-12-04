using CoreLayer.Entity;
using System;

namespace EntityLayer.Concrete
{
    public class HomeImage : IEntity
    {
        public int Id { get; set; }
        public int HomeId { get; set; }
        public string Image { get; set; }
        public Home Home { get; set; }
    }
}
