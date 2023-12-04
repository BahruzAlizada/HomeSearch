using CoreLayer.Entity;
using System;

namespace EntityLayer.Concrete
{
    public class Room : IEntity
    {
        public int Id { get; set; }
        public int RoomCount { get; set; }
        public List<Home> Homes { get; set; }
    }
}
